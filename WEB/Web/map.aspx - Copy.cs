using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace Web
{
    public partial class map : System.Web.UI.Page
    {
        struct MyNode 
        {
            public int Id;
            public string Name;
            public int SuperId;
        };

        public StringBuilder sb = new StringBuilder();
        public StringBuilder zNodes = new StringBuilder();
        List<int> range = new List<int>();

        Dictionary<int, List<MyNode>> dic = new Dictionary<int, List<MyNode>>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                initInfoWindows();
            }
        }
        
        private void initInfoWindows()
        {
            int id;
            int i, j;
            LEDMonitor.BLL.Nodes bll = new LEDMonitor.BLL.Nodes();
            LEDMonitor.BLL.NodeModule MBll = new LEDMonitor.BLL.NodeModule();
            LEDMonitor.Model.NodeModule model = new LEDMonitor.Model.NodeModule();
            
            DataTable dt = MBll.GetList("").Tables[0];
            int count = dt.Rows.Count;
            
            
            Dictionary<int, int> map = new Dictionary<int,int>();
            Dictionary<int, string> map2 = new Dictionary<int,string>();

            int leafId = 0;
            for (i = 0; i < count; i++)
            {
                id = int.Parse(dt.Rows[i]["Id"].ToString());
                int superId = int.Parse(dt.Rows[i]["SuperModuleId"].ToString());
                if ((dt.Rows[i]["IsLeaf"].ToString().ToLower() == "true")
                    || (dt.Rows[i]["IsLeaf"].ToString() == "1"))
                {
                    leafId = id;
                }

                DataTable dt2 = bll.GetList("NodeModuleId=" + id).Tables[0];
                List<MyNode> list = new List<MyNode>();
                

                for (j = 0; j < dt2.Rows.Count; j++)
                {
                    MyNode n = new MyNode();
                    n.Id = int.Parse(dt2.Rows[j]["Id"].ToString());
                    n.Name = dt2.Rows[j]["Name"].ToString();
                    n.SuperId = int.Parse(dt2.Rows[j]["ParentId"].ToString());
                    list.Add(n);
                }
                


                map.Add(id, superId);
                map2.Add(id, dt.Rows[i]["Name"].ToString());
                dic.Add(id, list);
            }
            
            

            
            while (leafId != 0)
            {
                range.Add(leafId);

                leafId = map[leafId];
            }

            
            int size = range.Count;

            sb.AppendFormat("\"<div style='width:300px,height:{0}px'><h4 style='margin:5px'>添加标注点</h4>", 300 + 30 * size);
            sb.Append("<table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>");
            sb.Append("<tr><td height='30'>标注名称：<td><td><input name='name' type='text'id='name' style='width:160px'><td>");
            sb.Append("<tr><td height='30'>标注地址：<td><td><input name='addr' type='text'id='addr' style='width:160px'><td>");
            sb.Append("<tr><td height='30'>所属区域：<td><td><table width='100%' border='0' align='center' cellpadding='0' cellspacing='0'>");
            for (i = size - 1, j = 1; i >= 0; i--, j++)
            {
                id = range[i];
                sb.AppendFormat("<tr><td height='30'><select id='select{0}' name='select{0}' style='width:160px'>", j, j);
                sb.AppendFormat("<option value='-1' selected='selected'>{0}</option>", map2[id]);
                foreach (MyNode node in dic[id])
                {
                    sb.AppendFormat("<option value='{0}'>{1}</option>", node.Id, node.Name);
                }

                sb.Append("</select></td></tr>");
            }

            sb.Append("</table></td><tr><td height='30' colspan='2' align='center'>");
            sb.Append("<input id='btnSubmit' type='button' value='提交' onclick='addMark()'></td></tr></table>");
            sb.AppendFormat("<input id='point' name='point' type='hidden'/><input id='size' name='size' type='hidden' value='{0}'/></div>\"", size);


            StringBuilder sb2 = new StringBuilder();
            for (i = size - 1, j = 1; i >= 0; i--, j++)
            {
                id = range[i];
                sb2.AppendFormat("<span style='padding:5px 2px 1px 5px'><select id='area{0}' name='area{0}'", j, j);
                sb2.AppendFormat("<option value='-1' selected='selected'>{0}</option>", map2[id]);
                foreach (MyNode node in dic[id])
                {
                    sb2.AppendFormat("<option value='{0}'>{1}</option>", node.Id, node.Name);
                }

                sb2.Append("</select></span>");
            }
            if (size > 0)
            {
                sb2.Append("<span style='padding:10px 2px 1px 5px'><input value='搜索'type='button'onclick='search();'/><span>");
            }

            i = size - 1;
            zNodes.Append("[");
            
            id = range[i];
            foreach (MyNode node in dic[id])
            {
                LoadNode(i, 0, dic[id]);
                i = size - 1;
            }

            //根据标注点与叶子节点关系，添加集中控制器；然后添加单灯控制器
            LEDMonitor.BLL.MarkLocalCtrls MLCBll = new LEDMonitor.BLL.MarkLocalCtrls();
            DataSet ds = MLCBll.GetAllLocalCtrls();

            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                zNodes.Append("{");
                zNodes.AppendFormat("id:\"S{0}\", pId:\"N{1}\", name:\"{2}\"", ds.Tables[0].Rows[i]["Id"], ds.Tables[0].Rows[i]["PId"], ds.Tables[0].Rows[i]["Name"]);
                zNodes.Append("},");
            }
            
            ds.Clear();

            ds = MLCBll.GetAllLEDCtrls();
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                zNodes.Append("{");
                zNodes.AppendFormat("id:\"C{0}\", pId:\"S{1}\", name:\"{2}\"", ds.Tables[0].Rows[i]["Id"], ds.Tables[0].Rows[i]["PId"], ds.Tables[0].Rows[i]["Name"]);
                zNodes.Append("},");
            }

            zNodes = zNodes.Remove(zNodes.Length - 1, 1);
            zNodes.Append("]");
            this.ltlArea.Text = sb2.ToString();
            
        }

        private void LoadNode(int rangeIndex, int parentId, List<MyNode> list)
        {
            int index = 0;
            
            foreach (MyNode node in list)
            {
                index = rangeIndex;
                if (node.SuperId == parentId)
                {
                    zNodes.Append("{");
                    zNodes.AppendFormat("id:\"N{0}\", pId:\"N{1}\", name:\"{2}\"", node.Id, parentId, node.Name);
                    zNodes.Append("},");
                    index--;
                    if (index >= 0)
                    {
                        int id = range[index];
                        LoadNode(index, node.Id, dic[id]);
                    }
                    else
                    {
                        ////根据标注点与叶子节点关系，添加集中控制器；然后添加单灯控制器
                        //LEDMonitor.BLL.MarkLocalCtrls bll = new LEDMonitor.BLL.MarkLocalCtrls();
                        //DataSet ds = bll.GetLocalCtrls(node.Id);

                        //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        //{
                        //    zNodes.Append("{");
                        //    zNodes.AppendFormat("id:\"S{0}\", pId:{1}, name:\"{2}\"", ds.Tables[0].Rows[i]["Id"], node.Id, ds.Tables[0].Rows[i]["Name"]);
                        //    zNodes.Append("},");
                        //}
                    }
                }
            }
        }
    }
}

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
        Tree tree = null;
        public string infoStr = string.Empty;
        public string zNodesStr = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (!SessionBox.CheckUserSession())
                //{
                //    Response.Redirect("~/Login.aspx");
                //}
                //else
                //{
                //    tree = Tree.Instance();
                //    Dictionary<int, List<int>> authDic = SessionBox.GetUserSession().AuthDic;

                //    StringBuilder zNodes = new StringBuilder();
                //    //NodesHelper helperBll = NodesHelper.Instance();
                    
                //    //zNodes.Append("[");
                    
                //    //if (authDic.ContainsKey(2))
                //    //{
                //    //    foreach (int nodeId in authDic[2])
                //    //    {
                //    //        //ESMonitor.Model.Nodes model = helperBll.GetNodeModel(nodeId);
                //    //        zNodes.Append("{");

                //    //        zNodes.AppendFormat("id:\"N{0}\",pId:\"N{1}\",name:\"{2}\",isParent:true", nodeId, model.ParentId, model.Name);
                //    //        zNodes.Append("},");
                //    //    }
                //    //}

                //    //if (zNodes.Length > 1)
                //    //{
                //    //    zNodes = zNodes.Remove(zNodes.Length - 1, 1);
                //    //}

                //    //zNodes.Append("]");
                    
                //    //zNodesStr = zNodes.ToString();
                    
                //    //InitTree();
                //    InitInfoWindows();
                //    InitSearch();
                //}
            }
        }
        
        private void InitTree()
        {
            zNodesStr = tree.GetTree(true, true, false, false);
        }

        private void InitInfoWindows()
        {
            infoStr = tree.GetInfoWindows();
        }

        private void InitSearch()
        {
            this.ltlArea.Text = tree.GetSearch();
        }
    }
}

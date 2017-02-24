using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Web
{
    public partial class MapService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ParseAction();
        }

        //private void ParseAction()
        //{
        //    switch (Request.QueryString["action"])
        //    {
        //        case "addMark":
        //            AddMark();
        //            break;
        //        case "markInfo":
        //            GetMarkInfo();
        //            break;
        //        case "center":
        //            GetCenterInArea();
        //            break;
        //        case "getMarks":
        //            GetMarks();
        //            break;
        //        //case "localCtrlInfo":
        //        //    GetLocalCtrlMark();
        //        //    break;
        //        case "getAreaNodes":
        //            GetAreaNodes();
        //            break;
        //        case "getNavi":
        //            GetNavi();
        //            break;
        //        default:
        //            Response.Write("无法提供此项服务");
        //            break;
        //    }

        //    Response.End();
        //}

        //#region 添加标注
        //private void AddMark()
        //{
        //    if (Request.QueryString["name"] == null)
        //    {
        //        Response.Write("参数错误");
        //        return;
        //    }

        //    if (Request.QueryString["addr"] == null)
        //    {
        //        Response.Write("参数错误");
        //        return;
        //    }

        //    if (Request.QueryString["point"] == null)
        //    {
        //        Response.Write("参数错误");
        //        return;
        //    }

        //    string name = Request.QueryString["name"].Trim().ToString();
        //    ESMonitor.BLL.Marks bll = new ESMonitor.BLL.Marks();

        //    if (bll.Exists(name))
        //    {
        //        Response.Write("该名称标注已录入");
        //        return;
        //    }

        //    string addr = Request.QueryString["addr"].Trim().ToString();
        //    string point = Request.QueryString["point"].Trim().ToString();
        //    string nodes = Request.QueryString["nodes"].Trim().ToString();
        //    string[] s = point.Split(';');

        //    ESMonitor.Model.Marks model = new ESMonitor.Model.Marks();
        //    model.Name = name;
        //    model.Addr = addr;
        //    model.Long = Convert.ToInt32(double.Parse(s[0]) * 1000000);
        //    model.Lant = Convert.ToInt32(double.Parse(s[1]) * 1000000);

        //    int markId = bll.Add(model);
        //    if (markId > 0)
        //    {
        //        string[] node = nodes.Split(';');
        //        ESMonitor.BLL.NodeMarks NBll = new ESMonitor.BLL.NodeMarks();
        //        int i = 1;
        //        foreach (string n in node)
        //        {
        //            if (i != node.Length)
        //            {
        //                NBll.Add(int.Parse(n), markId, 0);
        //            }
        //            else
        //            {
        //                NBll.Add(int.Parse(n), markId, 1);
        //            }
        //            i++;
        //        }

        //        Response.Write("成功添加标注");
        //    }
        //    else
        //    {
        //        Response.Write("添加标注失败");
        //    }
        //}
        //#endregion

        //#region 根据标注Id或者标注信息
        //private void GetMarkInfo()
        //{
        //    if (Request.QueryString["id"] == null)
        //    {
        //        Response.Write("参数错误");
        //        return;
        //    }

        //    ESMonitor.BLL.Marks bll = new ESMonitor.BLL.Marks();
        //    int id = int.Parse(Request.QueryString["id"].ToString());

        //    ESMonitor.Model.Marks model = bll.GetModel(id);

        //    if (model != null)
        //    {
        //        string str = Convert.ToDouble(model.Long / 1000000.0).ToString() + ";" + Convert.ToDouble(model.Lant / 1000000.0).ToString();
        //        Response.Write(str);
        //    }
        //    else
        //    {
        //        Response.Write("err");
        //    }
        //}
        //#endregion

        //#region 获取某个区域内的标注信息
        //private void GetCenterInArea()
        //{
        //    if (Request.QueryString["id"] == null)
        //    {
        //        Response.Write("参数错误");
        //        return;
        //    }

        //    if (Request.QueryString["type"] == null)
        //    {
        //        Response.Write("参数错误");
        //        return;
        //    }

        //    string nodeId = Request.QueryString["id"].ToString();
        //    string type = Request.QueryString["type"].ToString();
        //    int id = int.Parse(nodeId);
            
        //    int Long = 0, Lant = 0;
        //    if (type == "N")
        //    {
        //        ESMonitor.BLL.Nodes bll = new ESMonitor.BLL.Nodes();
        //        ESMonitor.Model.Nodes model = bll.GetModel(id);
        //        Long = model.Long;
        //        Lant = model.Lant;
        //    }
        //    else if (type == "S")
        //    {
        //        ESMonitor.BLL.LocalControls bll = new ESMonitor.BLL.LocalControls();
        //        ESMonitor.Model.LocalControls model = bll.GetModel(id);
        //        Long = model.Long;
        //        Lant = model.Lant;
        //    }
        //    else if (type == "C")
        //    {
        //        ESMonitor.BLL.LEDControls bll = new ESMonitor.BLL.LEDControls();
        //        ESMonitor.Model.LEDControls model = bll.GetModel(id);
        //        Long = model.Long;
        //        Lant = model.Lant;
        //    }


        //    if (Long != 0 && Lant != 0)
        //    {
        //        string str = Convert.ToDouble(Long / 1000000.0).ToString() + ";" + Convert.ToDouble(Lant / 1000000.0).ToString();
        //        Response.Write(str);
        //    }
        //    else
        //    {
        //        Response.Write("err");
        //    }
        //}
        //#endregion

        //#region 获取某个区域内的标注信息
        //private void GetMarks()
        //{
        //    string nodeId = Request.QueryString["id"].ToString();
        //    string type = Request.QueryString["type"].ToString();

        //    int id = int.Parse(nodeId);
            
        //    if (type == "N") //动态对象节点
        //    {
        //        GetLocalCtrlMarks(id);
        //    }
        //    else if (type == "S") //集中控制器下的
        //    {
        //        GetLEDCtrlMarks(id);
        //    }
        //    else if (type == "C") //单灯控制器
        //    {
        //        GetLEDCtrlMark(id);
        //    }
        //    else if (type == "G")
        //    {
        //        GetLEDCtrlMarkInGroup(id);
        //    }
        //}

        //private void GetLocalCtrlMarks(int nodeId)
        //{
        //    double Lant, Long;
        //    ESMonitor.BLL.Nodes bll = new ESMonitor.BLL.Nodes();

        //    DataTable dt = bll.GetLocalCtrls(nodeId).Tables[0];
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("[");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        Long = Convert.ToDouble(dt.Rows[i]["Long"]) / 1000000.0;
        //        Lant = Convert.ToDouble(dt.Rows[i]["Lant"]) / 1000000.0;
        //        sb.AppendFormat("{{id:{0},name:\"{1}\",Long:\"{2}\",Lant:\"{3}\",status:{4},no:\"{5}\"}},", dt.Rows[i]["Id"],
        //            dt.Rows[i]["Name"], Long, Lant, dt.Rows[i]["Status"], dt.Rows[i]["No"]);
        //    }

        //    if (sb.Length > 1)
        //    {
        //        sb = sb.Remove(sb.Length - 1, 1);
        //    }
        //    sb.Append("]");
        //    if (sb.Length > 2)
        //    {
        //        Response.Write(sb.ToString());
        //    }
        //    else
        //    {
        //        Response.Write("err");
        //    }

            
        //}

        //private void GetLEDCtrlMarks(int localCtrlId)
        //{
        //    double Lant, Long;
        //    ESMonitor.BLL.Nodes bll = new ESMonitor.BLL.Nodes();

        //    DataTable dt = bll.GetLEDCtrls(localCtrlId).Tables[0];
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("[");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        Long = Convert.ToDouble(dt.Rows[i]["Long"]) / 1000000.0;
        //        Lant = Convert.ToDouble(dt.Rows[i]["Lant"]) / 1000000.0;
        //        sb.AppendFormat("{{id:{0},name:\"{1}\",Long:\"{2}\",Lant:\"{3}\",status:{4},no:\"{5}\",placeNo:\"{6}\"}},", dt.Rows[i]["Id"],
        //            dt.Rows[i]["Name"], Long, Lant, dt.Rows[i]["Status"], dt.Rows[i]["No"], dt.Rows[i]["PlaceNo"]);
        //    }

        //    if (sb.Length > 1)
        //    {
        //        sb = sb.Remove(sb.Length - 1, 1);
        //    }
        //    sb.Append("]");
        //    if (sb.Length > 2)
        //    {
        //        Response.Write(sb.ToString());
        //    }
        //    else
        //    {
        //        Response.Write("err");
        //    }
        //}

        //private void GetLEDCtrlMarkInGroup(int logicGroupId)
        //{
        //    double Lant, Long;
        //    ESMonitor.BLL.LogicGroups bll = new ESMonitor.BLL.LogicGroups();

        //    DataTable dt = bll.GetLEDCtrls(logicGroupId).Tables[0];
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("[");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        Long = Convert.ToDouble(dt.Rows[i]["Long"]) / 1000000.0;
        //        Lant = Convert.ToDouble(dt.Rows[i]["Lant"]) / 1000000.0;
        //        sb.AppendFormat("{{id:{0},name:\"{1}\",Long:\"{2}\",Lant:\"{3}\",status:{4},no:\"{5}\",placeNo:\"{6}\"}},", dt.Rows[i]["Id"],
        //            dt.Rows[i]["Name"], Long, Lant, dt.Rows[i]["Status"], dt.Rows[i]["No"], dt.Rows[i]["PlaceNo"]);
        //    }

        //    if (sb.Length > 1)
        //    {
        //        sb = sb.Remove(sb.Length - 1, 1);
        //    }
        //    sb.Append("]");
        //    if (sb.Length > 2)
        //    {
        //        Response.Write(sb.ToString());
        //    }
        //    else
        //    {
        //        Response.Write("err");
        //    }
        //}

        //private void GetLEDCtrlMark(int ledCtrlId)
        //{
        //    double Lant, Long;
        //    ESMonitor.BLL.LEDControls bll = new ESMonitor.BLL.LEDControls();

        //    ESMonitor.Model.LEDControls model = bll.GetModel(ledCtrlId);
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("[");
        //    if (model != null)
        //    {
        //        Long = Convert.ToDouble(model.Long) / 1000000.0;
        //        Lant = Convert.ToDouble(model.Lant) / 1000000.0;
        //        sb.AppendFormat("{{id:{0},name:\"{1}\",Long:\"{2}\",Lant:\"{3}\",status:{4},no:\"{5}\",placeNo:\"{6}\"}},", model.Id, model.Name, Long, Lant, model.Status, model.No, model.PlaceNo);
        //    }

        //    if (sb.Length > 1)
        //    {
        //        sb = sb.Remove(sb.Length - 1, 1);
        //    }

        //    sb.Append("]");

        //    if (sb.Length > 2)
        //    {
        //        Response.Write(sb.ToString());
        //    }
        //    else
        //    {
        //        Response.Write("err");
        //    }
        //}
        //#endregion

        //#region 获取集中控制器标注
        
        //#endregion

        //#region 获取下一个节点内容
        //private void GetAreaNodes()
        //{
        //    string parentId = Request.QueryString["id"].ToString();
        //    if (parentId == null)
        //    {
        //        Response.Write("err");
        //        return;
        //    }

        //    ESMonitor.BLL.Nodes bll = new ESMonitor.BLL.Nodes();
        //    StringBuilder sb = new StringBuilder();
        //    DataTable dt = bll.GetList("ParentId=" + parentId).Tables[0];

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        sb.AppendFormat("{0},{1}|", dt.Rows[i]["Name"], dt.Rows[i]["Id"]);
        //    }

        //    if (sb.Length > 1)
        //    {
        //        sb = sb.Remove(sb.Length - 1, 1);
        //    }

        //    Response.Write(sb.ToString());
        //}
        //#endregion

        //#region 获取父辈节点
        //private void GetNavi()
        //{
        //    string parentId = Request.QueryString["id"].ToString();
        //    if (parentId == null)
        //    {
        //        Response.Write("err");
        //        return;
        //    }


        //}
        //#endregion
    }
}

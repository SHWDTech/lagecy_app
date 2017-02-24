using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace Web
{
    public partial class DustDistrict : System.Web.UI.Page
    {
        //private UInt32 nodeId = 0xFFFFFFFF;
        //private ESMonitor.BLL.Tasks bll = new ESMonitor.BLL.Tasks();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnSearchCPM_Click(object sender, EventArgs e)
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
        //    cmd.NodeId = nodeId;
        //    cmd.EncodeCMPReadCmd();
        //    cmd.GetTaskModel(2, ref model);
        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    //UInt16 data = get_u16_from_data(dt.Rows[0]["Data"]);
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    //string strcpm1 = Convert.ToString(data1[0]);
        //            //    //string strcpm2 = Convert.ToString(data1[1]);
        //            //    //string strcpm = strcpm1 + strcpm2;
        //            //    //int intcpm = Convert.ToInt32(strcpm, 16);
        //            //    int intcpm = Convert.ToInt32(data1[0]) * 256 + Convert.ToInt32(data1[1]);
        //            //    txtCPMShow.Text = Convert.ToString(intcpm);
        //            //    break;
        //            //}
        //        }

        //    }
        //    else
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
        //    }
        //}


       

        //protected void btnSearchNoisy_Click(object sender, EventArgs e)//噪音
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
        //    cmd.NodeId = nodeId;
        //    cmd.EncodeSetAWCmd();
        //    cmd.GetTaskModel(2, ref model);

        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    string  strcpm = Convert.ToString(data1[0])  +'.'+ Convert.ToString(data1[1]);
        //            //    txtNoisyShow.Text = Convert.ToString(strcpm);
        //            //    break;
        //            //}
        //        }

        //    }
        //    else
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
        //    }
        //}

        //protected void btnSearchWinDir_Click(object sender, EventArgs e)//查询风向
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();
        //    cmd.NodeId = nodeId;
        //    cmd.EncodeReadWindDirCmd(0x01);
        //    cmd.GetTaskModel(2, ref model);
        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    int intcpm = Convert.ToInt32(data1[1]) * 256 + Convert.ToInt32(data1[2]);
        //            //    txtWinDirShow.Text = Convert.ToString(intcpm)+"。";
        //            //    break;
        //            //}
        //        }

        //    }
        //    else
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
        //    }
        //}

        //protected void btnSearchWinSpeed_Click(object sender, EventArgs e)//测风速
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
        //    cmd.NodeId = nodeId;
        //    cmd.EncodeReadWindSpeedCmd(0x01);
        //    cmd.GetTaskModel(2, ref model);
        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    string strcpm = Convert.ToString(data1[1]) + '.' + Convert.ToString(data1[2]);
        //            //    txtWinSpeedShow.Text = Convert.ToString(strcpm);
        //            //    break;
        //            //}
        //        }

        //    }
        //}

        //protected void btnSearchTempareture_Click(object sender, EventArgs e)//测温度
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
        //    cmd.NodeId = nodeId;
        //    cmd.EncodeReadESDataCmd();
        //    cmd.GetTaskModel(2, ref model);

        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //       // ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    string strcpm = Convert.ToString(data1[0]) + '.' + Convert.ToString(data1[1]);
        //            //    txtTemparetureShow.Text = Convert.ToString(strcpm);
        //            //    break;
        //            //}
        //        }

        //    }
        //}

        //protected void btnSearchHumidy_Click(object sender, EventArgs e)
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
        //    cmd.NodeId = nodeId;
        //    cmd.EncodeReadESDataCmd();
        //    cmd.GetTaskModel(2, ref model);

        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    string strcpm = Convert.ToString(data1[2]) + '.' + Convert.ToString(data1[3]);
        //            //    txtHumidyShow.Text = Convert.ToString(strcpm);
        //            //    break;
        //            //}
        //        }

        //    }
        //}
        //protected void btnAllIndex_Click(object sender, EventArgs e)//测试全部
        //{
        //    ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
        //    DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
        //    cmd.NodeId = nodeId;
        //    //cmd.EncodeReaAllIndexCmd();
        //    cmd.GetTaskModel(2, ref model);
        //    long i = 0;
        //    i = bll.Add(model);



        //    if (i > 0)
        //    {
        //        //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
        //        while (true)
        //        {
        //            //StringBuilder str = new StringBuilder();
        //            //string strWh = string.Empty;
        //            //str.AppendFormat("TaskId={0}", i);
        //            //strWh = str.ToString();
        //            //DataSet ds = new DataSet();
        //            //ds = bll.GetSearchResultFromTaskNotice(strWh);
        //            //byte[] data = new byte[1000];
        //            //DataTable dt = ds.Tables[0];
        //            //if (dt.Rows.Count == 1)
        //            //{
        //            //    string index1, index2, index3, index4, index5, index6;
        //            //    var data1 = dt.Rows[0]["Data"] as byte[];
        //            //    if ((data1[1] & 0x01) != 0)//扬尘
        //            //    {
        //            //        int intcpm = Convert.ToInt32(data1[2]) * 256 + Convert.ToInt32(data1[3]);
        //            //        index1 = Convert.ToString(intcpm);
        //            //    }
        //            //    else
        //            //    {
        //            //        index1 = "无数据";                        
        //            //    }
        //            //    if ((data1[1] & 0x02) != 0)//噪音
        //            //    {

        //            //        //var data1 = dt.Rows[0]["Data"] as byte[];
        //            //        //string strcpm = Convert.ToString(data1[0]) + '.' + Convert.ToString(data1[1]);
        //            //        //txtNoisyShow.Text = Convert.ToString(strcpm);
        //            //        //int intcpm = Convert.ToInt32(data1[4]) * 256 + Convert.ToInt32(data1[5]);
        //            //        index2 = Convert.ToString(data1[4]) + '.' + Convert.ToString(data1[5]);
        //            //    }
        //            //    else
        //            //    {
        //            //        index2 = "无数据";
        //            //    }

        //            //    if ((data1[1] & 0x04) != 0)//风向
        //            //    {

        //            //        //var data1 = dt.Rows[0]["Data"] as byte[];
        //            //        //int intcpm = Convert.ToInt32(data1[1]) * 256 + Convert.ToInt32(data1[2]);
        //            //        //txtWinDirShow.Text = Convert.ToString(intcpm) + "。";
        //            //        int intcpm = Convert.ToInt32(data1[7]) * 256 + Convert.ToInt32(data1[8]);
        //            //        index3 = Convert.ToString(intcpm);
        //            //    }
        //            //    else
        //            //    {
        //            //        index3 = "无数据";
        //            //    }


        //            //    if ((data1[1] & 0x08) != 0)//风速
        //            //    {

        //            //        //var data1 = dt.Rows[0]["Data"] as byte[];
        //            //        //string strcpm = Convert.ToString(data1[1]) + '.' + Convert.ToString(data1[2]);
        //            //        //txtWinSpeedShow.Text = Convert.ToString(strcpm);
        //            //        //int intcpm = Convert.ToInt32(data1[10]) * 256 + Convert.ToInt32(data1[11]);
        //            //        index4 = Convert.ToString(data1[10]) + '.' + Convert.ToString(data1[11]);
        //            //    }
        //            //    else
        //            //    {
        //            //        index4 = "无数据";
        //            //    }

        //            //    if ((data1[1] & 0x08) != 0)//测温湿度
        //            //    {

        //            //        //string strcpm = Convert.ToString(data1[0]) + '.' + Convert.ToString(data1[1]);
        //            //        //txtTemparetureShow.Text = Convert.ToString(strcpm);
        //            //        //int intcpm = Convert.ToInt32(data1[12]) * 256 + Convert.ToInt32(data1[13]);
        //            //        index5 = Convert.ToString(data1[12]) + '.' + Convert.ToString(data1[13]);
        //            //        //intcpm = Convert.ToInt32(data1[14]) * 256 + Convert.ToInt32(data1[15]);
        //            //        index6 = Convert.ToString(data1[14]) + '.' + Convert.ToString(data1[15]);
        //            //    }
        //            //    else
        //            //    {
        //            //        index6 = index5= "无数据";
        //            //    }


        //            //    DataSet dsforAllIndex = new DataSet();
        //            //    DataTable dtforAllIndex = new DataTable();
        //            //    DataColumn colum1 = new DataColumn("颗粒物", typeof(string));
        //            //    DataColumn colum2 = new DataColumn("噪音", typeof(string));
        //            //    DataColumn colum3 = new DataColumn("风向", typeof(string));
        //            //    DataColumn colum4 = new DataColumn("风速", typeof(string));
        //            //    DataColumn colum5 = new DataColumn("温度", typeof(string));
        //            //    DataColumn colum6 = new DataColumn("湿度", typeof(string));
        //            //    dtforAllIndex.Columns.Add(colum1);
        //            //    dtforAllIndex.Columns.Add(colum2);
        //            //    dtforAllIndex.Columns.Add(colum3);
        //            //    dtforAllIndex.Columns.Add(colum4);
        //            //    dtforAllIndex.Columns.Add(colum5);
        //            //    dtforAllIndex.Columns.Add(colum6);

        //            //    DataRow row = dtforAllIndex.NewRow();
        //            //    row["颗粒物"] = index1;
        //            //    row["噪音"] = index2;
        //            //    row["风向"] = index3;
        //            //    row["风速"] = index4;
        //            //    row["温度"] = index5;
        //            //    row["湿度"] = index6;
        //            //    dtforAllIndex.Rows.Add(row);
        //            //    dsforAllIndex.Tables.Add(dtforAllIndex);
        //            //    gvShowAllIndex.DataSource = dsforAllIndex;
        //            //    gvShowAllIndex.DataBind();

        //            //    break;
        //            //}
        //        }

        //    }
        //    else
        //    {
        //        ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
        //    }
        //}



    }
}

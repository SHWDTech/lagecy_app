using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace Web
{
    public partial class HistoryDataQuery : System.Web.UI.Page
    {
        private readonly ESMonitor.BLL.HistoryQuery bll = new ESMonitor.BLL.HistoryQuery();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            { 
               ddlQueryContentBind();
               ddlfactoryBind();
               ddldevBind();
               ViewState["SortOrder"] = "UpdateTime";
               ViewState["OrderDire"] = "ASC";
            }
            
        }
        public void ddlfactoryBind()
        {
            ListItem item0 = new ListItem("中央商场", "0");
            this.ddlfactory.Items.Add(item0);
           
        }
        public void  ddldevBind()
        {
            ListItem item0 = new ListItem("中央商场1号", "3");
            this.ddldev.Items.Add(item0);

        }

        public void ddlQueryContentBind()
        {
            ListItem item1 = new ListItem("每分钟均值", "1");  
            ListItem item2 = new ListItem("每小时均值", "2"); 
            ListItem item3 = new ListItem("每天均值", "3");

            this.ddlQueryContent.Items.Add(item1);
            this.ddlQueryContent.Items.Add(item2);
            this.ddlQueryContent.Items.Add(item3);
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime startTime;
            DateTime endTime;
            if (txtStartTime.Text.ToString() == "" || txtEndTime.Text.ToString() == "")
            {
                //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"请输入起始日期\");</script>");
                lblShowError.Text = "请输入起始日期";
                lblShowError.Visible = true;
            }
            else
            {
                startTime = DateTime.Parse(txtStartTime.Text);
                endTime = DateTime.Parse(txtEndTime.Text);
                if (startTime >= endTime)
                {
                    //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"输入起始日期有误，开始日期应大于结束日期\");</script>");
                    lblShowError.Text = "输入起始日期有误，开始日期应大于结束日期";
                    lblShowError.Visible = true;
                }
                else
                {
                    bind();
                }
            }
        }


        public void bind()
        {
            StringBuilder str = new StringBuilder();
            string strWh = string.Empty;

            int control = System.Int32.Parse(this.ddlQueryContent.SelectedValue);
            DateTime statetime = DateTime.Parse(this.txtStartTime.Text.Trim());//DataTime.Parse(String inString); 
            DateTime endtime = DateTime.Parse(this.txtEndTime.Text.Trim());

            DataSet HistoryDataDs = bll.GetSearchResualt(control, 2, statetime, endtime);
            DataColumn dc = HistoryDataDs.Tables[0].Columns[3];


            DataSet Ds = bll.GetSearchResualt1(control, 2, statetime, endtime);


            DataView view = HistoryDataDs.Tables[0].DefaultView;
            string sort = (string)ViewState["SortOrder"] + " " + (string)ViewState["OrderDire"];
            view.Sort = sort;
            gvHistoryShow.DataSource = view;
            //gvHistoryShow.DataKeyNames = new string[] { "UpdateTime" };
            gvHistoryShow.DataBind();
            //gvHistoryShow.ShowFooter = false;
        }


        protected void gvHistoryShow_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            bind();
            gvHistoryShow.PageIndex = e.NewPageIndex;
            gvHistoryShow.DataBind();
        }

        protected void gvHistoryShow_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sPage = e.SortExpression;
            if (ViewState["SortOrder"].ToString() == sPage)
            {
                if (ViewState["OrderDire"].ToString() == "Desc")
                    ViewState["OrderDire"] = "ASC";
                else
                    ViewState["OrderDire"] = "Desc";
            }
            else
            {
                ViewState["SortOrder"] = e.SortExpression;
            }
            bind();
        }



    }
}
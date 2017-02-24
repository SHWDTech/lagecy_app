using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class StatPicsView : System.Web.UI.Page
    {
        private const int PageSize = 15;
        private ESMonitor.BLL.Photos bll = new ESMonitor.BLL.Photos();
        ESMonitor.BLL.Stats _bllStats = new ESMonitor.BLL.Stats();
        ESMonitor.BLL.Devs _bllDevs = new ESMonitor.BLL.Devs();
        public string statName;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetDevs();
            if (!IsPostBack)
            {
                StrWhere = "";
                if (Request.Params["sid"] != null)
                {
                    HiddenstatId.Value = Request.Params["sid"];
                    StrWhere = "T_Devs.StatId = " + Request.Params["sid"].ToString().Trim();
                }
                labPageIndex.Text = "1";
                int recordCount = bll.GetRecordCount(StrWhere);
                int pageCount = recordCount / PageSize;
                if (recordCount == 0 || recordCount % PageSize != 0)
                {
                    pageCount++;
                }
                labPageCount.Text = pageCount.ToString();
                labCount.Text = recordCount.ToString();
                BindDevs();
            }
        }

        private void BindDevs()
        {
            int currentPageIndex = int.Parse(labPageIndex.Text);
            var ds = bll.GetList(PageSize, currentPageIndex, StrWhere);
            firstPage.Enabled = true;
            prevPage.Enabled = true;
            nextPage.Enabled = true;
            lastPage.Enabled = true;

            if (labPageIndex.Text == "1")
            {
                firstPage.Enabled = false;
                prevPage.Enabled = false;
            }
            if (labPageIndex.Text == labPageCount.Text)
            {
                nextPage.Enabled = false;
                lastPage.Enabled = false;
            }
            Repeater.DataSource = ds.Tables[0];
            Repeater.DataBind();
        }

        protected void GetDevs()
        {
            string statId = Request.Params["sid"];
            if (statId == "") return;
            ddlDevs.Items.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("StatId = ");
            sb.Append(statId);
            DataSet ds = _bllDevs.GetList(sb.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem { Text = dr["DevCode"].ToString(), Value = dr["Id"].ToString() };
                ddlDevs.Items.Add(item);
            }
            statName = _bllStats.GetModel(int.Parse(statId)).StatName;
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            string statId = HiddenstatId.Value;
            string devId = ddlDevs.SelectedValue.ToString();
            string strStartTime = startTime.Text;
            string strEndTIme = endTime.Text;

            str.AppendFormat(" T_Devs.StatId = {0}", statId);
            if (devId != "")
            {
                str.AppendFormat(" AND T_Devs.Id = {0}", devId);
            }
            if (strStartTime != "")
            {
                str.AppendFormat(" AND T_Photos.AddTime > '{0}'", strStartTime);
            }
            if (strEndTIme != "")
            {
                str.AppendFormat(" AND T_Photos.AddTime < '{0}'", strEndTIme);
            }


            StrWhere = str.ToString();
            int recordCount = bll.GetRecordCount(StrWhere);
            int pageCount = recordCount / PageSize;
            if (recordCount == 0 || recordCount % PageSize != 0)
            {
                pageCount++;
            }
            labPageCount.Text = pageCount.ToString();
            labCount.Text = recordCount.ToString();

            BindDevs();
        }

        private string StrWhere
        {
            get { return ViewState["strWhere"].ToString(); }
            set { ViewState["strWhere"] = value; }
        }

        protected void firstPage_Click(object sender, ImageClickEventArgs e)
        {
            labPageIndex.Text = "1";
            BindDevs();
        }

        protected void prevPage_Click(object sender, ImageClickEventArgs e)
        {
            int currenPageIndex = int.Parse(labPageIndex.Text) - 1;
            labPageIndex.Text = currenPageIndex.ToString();
            BindDevs();
        }

        protected void nextPage_Click(object sender, ImageClickEventArgs e)
        {
            int currenPageIndex = int.Parse(labPageIndex.Text) + 1;
            labPageIndex.Text = currenPageIndex.ToString();
            BindDevs();
        }

        protected void lastPage_Click(object sender, ImageClickEventArgs e)
        {
            labPageIndex.Text = labPageCount.Text;
            BindDevs();
        }

        protected void goPage_Click(object sender, ImageClickEventArgs e)
        {
            int pageIndex;
            try
            {
                pageIndex = int.Parse(txtPageIndex.Text);
            }
            catch (Exception)
            {
                return;
            }
            int pageCount = int.Parse(labPageCount.Text);
            if (pageIndex >= 1 && pageIndex <= pageCount)
            {
                labPageIndex.Text = pageIndex.ToString();
                BindDevs();
            }
        }
    }
}
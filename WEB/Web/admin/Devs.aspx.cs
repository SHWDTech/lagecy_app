using System;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.admin
{
    public partial class Devs : Page
    {
        private readonly ESMonitor.BLL.Devs _bll = new ESMonitor.BLL.Devs();

        private const int PageSize = 10;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                labPageIndex.Text = "1";
                StrWhere = "";
                int recordCount = _bll.GetRecordCount(StrWhere);
                int pageCount = recordCount / PageSize;
                if (recordCount == 0 || recordCount % PageSize != 0)
                {
                    pageCount++;
                }
                labPageCount.Text = pageCount.ToString();
                labCount.Text = recordCount.ToString();
                BindDevs();

                btnSubmit.Attributes.Add("OnClick", "return search()");
                //}
            }
        }

        private void BindDevs()
        {
            int currentPageIndex = int.Parse(labPageIndex.Text);
            var ds = _bll.GetList(PageSize, currentPageIndex, StrWhere);
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

        protected void Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Del")
            {
                var id = int.Parse(e.CommandArgument.ToString());
                if (_bll.Delete(id))
                {
                    int recordCount = int.Parse(labCount.Text) - 1;
                    int pageCount = recordCount / PageSize;
                    if (recordCount == 0 || recordCount % PageSize != 0)
                    {
                        pageCount++;
                    }
                    labPageCount.Text = pageCount.ToString();
                    labCount.Text = recordCount.ToString();
                }
            }

            BindDevs();

        }

        protected void Repeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)e.Item.DataItem;
                Literal ltl = (Literal)e.Item.FindControl("ltlDevStatus");

                if (Convert.ToInt32(drv["DevStatus"]) == 1)
                {
                    ltl.Text = "是";
                }
                else
                {
                    ltl.Text = "否";
                }

                ((LinkButton)e.Item.FindControl("lbtnDel")).Attributes.Add("onclick", "javascript:return confirm('确认删除吗?')");
            }
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

        private string StrWhere
        {
            get { return ViewState["strWhere"].ToString(); }
            set { ViewState["strWhere"] = value; }
        }

        protected void OnSubmit(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();

            string statCode = txtStatCode.Text.Trim();

            if (statCode.Length > 0)
            {
                str.AppendFormat("StatCode=\'{0}\'", statCode);
            }
            StrWhere = str.ToString();
            int recordCount = _bll.GetRecordCount(StrWhere);
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
}

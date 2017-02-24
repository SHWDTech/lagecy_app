using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Web
{
    public partial class UserGroup : System.Web.UI.Page
    {
        private readonly ESMonitor.BLL.UserGroup bll = new ESMonitor.BLL.UserGroup();

        private const int pageSize = 10;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //if (!SessionBox.CheckUserSession())
                //{
                //    Response.Redirect("~/Login.aspx");
                //}
                //else
                //{

                    this.labPageIndex.Text = "1";
                    this.strWhere = "";
                    int recordCount = bll.GetRecordCount(strWhere);
                    int pageCount = recordCount / pageSize;
                    if (recordCount == 0 || recordCount % pageSize != 0)
                    {
                        pageCount++;
                    }
                    this.labPageCount.Text = pageCount.ToString();
                    this.labCount.Text = recordCount.ToString();
                    BindUserGroups();
                //}
            }
        }

        private void BindUserGroups()
        {
            DataSet ds = new DataSet();
            int currentPageIndex = int.Parse(this.labPageIndex.Text);
            ds = bll.GetList(pageSize, currentPageIndex, strWhere);
            this.firstPage.Enabled = true;
            this.prevPage.Enabled = true;
            this.nextPage.Enabled = true;
            this.lastPage.Enabled = true;

            if (this.labPageIndex.Text == "1")
            {
                this.firstPage.Enabled = false;
                this.prevPage.Enabled = false;
            }
            if (this.labPageIndex.Text == this.labPageCount.Text)
            {
                this.nextPage.Enabled = false;
                this.lastPage.Enabled = false;
            }
            this.Repeater.DataSource = ds.Tables[0];
            this.Repeater.DataBind();
        }

        protected void Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = 0;
            if (e.CommandName == "Del")
            {
                id = int.Parse(e.CommandArgument.ToString());
                if (bll.Delete(id))
                {
                    int recordCount = int.Parse(this.labCount.Text) - 1;
                    int pageCount = recordCount / pageSize;
                    if (recordCount == 0 || recordCount % pageSize != 0)
                    {
                        pageCount++;
                    }
                    this.labPageCount.Text = pageCount.ToString();
                    this.labCount.Text = recordCount.ToString();
                }
            }

            BindUserGroups();

        }

        protected void Repeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)e.Item.DataItem;
                

                ((LinkButton)e.Item.FindControl("lbtnDel")).Attributes.Add("onclick", "javascript:return confirm('确认删除吗?')");
            }
        }


        protected void firstPage_Click(object sender, ImageClickEventArgs e)
        {
            this.labPageIndex.Text = "1";
            BindUserGroups();
        }

        protected void prevPage_Click(object sender, ImageClickEventArgs e)
        {
            int currenPageIndex = int.Parse(this.labPageIndex.Text) - 1;
            this.labPageIndex.Text = currenPageIndex.ToString();
            this.BindUserGroups();
        }

        protected void nextPage_Click(object sender, ImageClickEventArgs e)
        {
            int currenPageIndex = int.Parse(this.labPageIndex.Text) + 1;
            this.labPageIndex.Text = currenPageIndex.ToString();
            this.BindUserGroups();
        }

        protected void lastPage_Click(object sender, ImageClickEventArgs e)
        {
            this.labPageIndex.Text = this.labPageCount.Text;
            this.BindUserGroups();
        }

        protected void goPage_Click(object sender, ImageClickEventArgs e)
        {
            int pageIndex = 0;
            try
            {
                pageIndex = int.Parse(this.txtPageIndex.Text);
            }
            catch (System.Exception ex)
            {
                return;
            }
            int pageCount = int.Parse(this.labPageCount.Text);
            if (pageIndex >= 1 && pageIndex <= pageCount)
            {
                this.labPageIndex.Text = pageIndex.ToString();
                BindUserGroups();
            }
        }

        protected void OnSubmit(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            string strWh = string.Empty;
            string name = this.txtName.Text.Trim();

            if (name.Length != 0)
            {
                str.AppendFormat("Name='{0}'", name);
            }

            strWh = str.ToString();
            if (strWh != strWhere)
            {
                strWhere = strWh;
                int recordCount = bll.GetRecordCount(strWhere);
                int pageCount = recordCount / pageSize;
                if (recordCount == 0 || recordCount % pageSize != 0)
                {
                    pageCount++;
                }
                this.labPageCount.Text = pageCount.ToString();
                this.labCount.Text = recordCount.ToString();
                BindUserGroups();
            }
        }

        private string strWhere
        {
            get { return ViewState["strWhere"].ToString(); }
            set { ViewState["strWhere"] = value; }
        }
    }
}

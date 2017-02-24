using System;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.BLL;
using Web.Common;

namespace Web.admin
{
    public partial class User : Page
    {
        private readonly Users _bll = new Users();

        private const int PageSize = 10;
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
                    BindUsers();
                //}
            }
        }

        private void BindUsers()
        {
            int currentPageIndex = int.Parse(labPageIndex.Text);
            DataSet ds = _bll.GetList(PageSize, currentPageIndex, StrWhere);
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
            int id = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "Del")
            {
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
            else if (e.CommandName == "Pass")
            {
                _bll.UpdateStatus(id, 2); //审核通过
            }
            else if (e.CommandName == "Lock")
            {
                _bll.UpdateStatus(id, 0); //锁定
            }
            
            BindUsers();

        }

        protected void Repeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)e.Item.DataItem;
                
                int roleId = int.Parse(drv["RoleId"].ToString());
                Literal ltl = (Literal)e.Item.FindControl("ltlRole");
                switch (roleId)
                {
                    case 1:
                        ltl.Text = "超级管理员";
                        break;
                    case 2:
                        ltl.Text = "管理员";
                        break;
                }

                string countryId = drv["Remark"].ToString();
                string countrName = Country.GetName(countryId);
                ltl = (Literal)e.Item.FindControl("ltlCountry");
                ltl.Text = countrName;
                
                byte status = byte.Parse(drv["Status"].ToString());
                ltl = (Literal)e.Item.FindControl("ltlStatus");

                LinkButton lbtnLock = (LinkButton)e.Item.FindControl("lbtnLock");
                LinkButton lbtnPass = (LinkButton)e.Item.FindControl("lbtnPass");
                
                switch (status)
                {
                    case 0:
                        ltl.Text = "锁定";
                        lbtnLock.Visible = false;
                        lbtnPass.Visible = true;
                        break;
                    case 1:
                        ltl.Text = "待审核";
                        lbtnLock.Visible = false;
                        lbtnPass.Visible = true;
                        break;
                    case 2:
                        ltl.Text = "审核通过";
                        lbtnLock.Visible = true;
                        lbtnPass.Visible = false;
                        break;
                }

                ((LinkButton)e.Item.FindControl("lbtnDel")).Attributes.Add("onclick", "javascript:return confirm('确认删除吗?')");
            }
        }


        protected void firstPage_Click(object sender, ImageClickEventArgs e)
        {
            labPageIndex.Text = "1";
            BindUsers();
        }

        protected void prevPage_Click(object sender, ImageClickEventArgs e)
        {
            int currenPageIndex = int.Parse(labPageIndex.Text) - 1;
            labPageIndex.Text = currenPageIndex.ToString();
            BindUsers();
        }

        protected void nextPage_Click(object sender, ImageClickEventArgs e)
        {
            int currenPageIndex = int.Parse(labPageIndex.Text) + 1;
            labPageIndex.Text = currenPageIndex.ToString();
            BindUsers();
        }

        protected void lastPage_Click(object sender, ImageClickEventArgs e)
        {
            labPageIndex.Text = labPageCount.Text;
            BindUsers();
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
                BindUsers();
            }
        }

        protected void OnSubmit(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            string name = txtUserName.Text.Trim();

            if (name.Length != 0)
            {
                str.AppendFormat("UserName='{0}'", name);
            }

            string strWh = str.ToString();
            if (strWh != StrWhere)
            {
                StrWhere = strWh;
                int recordCount = _bll.GetRecordCount(StrWhere);
                int pageCount = recordCount / PageSize;
                if (recordCount == 0 || recordCount % PageSize != 0)
                {
                    pageCount++;
                }
                labPageCount.Text = pageCount.ToString();
                labCount.Text = recordCount.ToString();
                BindUsers();
            }
        }

        private string StrWhere
        {
            get { return ViewState["strWhere"].ToString(); }
            set { ViewState["strWhere"] = value; }
        }
    }
}

using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.BLL;
using Web.Common;

namespace Web.admin
{
    public partial class UserAdd : Page
    {
        private readonly Users _bll = new Users();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCountry();
            if (IsPostBack)
            {
                OnSubmit();
            }
        }

        private void LoadCountry()
        {
            ArrayList arr = Country.GetData();
            foreach (object t in arr)
            {
                var item = (CountryItem)t;
                var litem = new ListItem {Text = item.Name, Value = item.Id};
                textRemark.Items.Add(litem);
            }
        }

        protected void OnSubmit()
        {
            string tip = "";
            string username = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string repwd = txtConfirmPwd.Text.Trim();
            string remark = textRemark.SelectedItem.Value.Trim();
            ESMonitor.Model.Users model = new ESMonitor.Model.Users();

            if (username != "" && pwd != "" && repwd != "")
            {
                //两次密码必须输入必须相同
                if (String.Compare(pwd, repwd, true) == 0)
                {
                    if (!_bll.Exists(username))//用户不存在
                    {
                        model.UserName = username;
                        model.Pwd = Utility.MD5(pwd.ToLower(), 32);
                        model.Mobile = txtPhone.Text.Trim();
                        model.Email = txtEmail.Text.Trim();
                        model.NowTime = DateTime.Now;
                        model.Status = 1; //待审核
                        model.ReMark = remark;

                        model.RoleId = rbtn1.Checked ? 2 : 1;

                        var ledCtrlId = _bll.Add(model);
                        if (ledCtrlId > 0)
                        {
                            Response.Redirect("User.aspx");
                        }
                    }
                    else
                    {
                        tip = "用户名已使用";
                    }
                }
                else
                {
                    tip = "两次密码不一致";
                }
            }
            else
            {
                tip = "用户名、密码、确认密码不能为空";
            }


            ClientScript.RegisterStartupScript(GetType(), "", "<script>window.parent.zAlert(\"" + tip + "\");</script>");


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPwd.Text = "";
            txtConfirmPwd.Text = "";
            txtPhone.Text = "";
            rbtn1.Checked = true;
        }
    }
}

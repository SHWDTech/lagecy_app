using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.BLL;
using Web.Common;

namespace Web.admin
{
    public partial class ChangePwd : Page
    {
        Users _bll = new Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUser();
            if (IsPostBack)
            {
                OnSubmit();
            }
        }

        private void LoadUser()
        {
            DataSet userDataSet = _bll.GetList();
            foreach (DataRow dr in userDataSet.Tables[0].Rows)
            {
                ListItem userItem = new ListItem();
                userItem.Text = dr["UserName"].ToString();
                userItem.Value = dr["UserId"].ToString();
                Users.Items.Add(userItem);
            }
        }

        protected void OnSubmit()
        {
            int userId = Convert.ToInt32(Users.SelectedValue);
            string userpwd = Utility.MD5(txtCurPwd.Text.ToLower(), 32);
            string newpwd = Utility.MD5(txtPwd.Text.ToLower(), 32);
            string tip = "更新密码成功！";
            if (_bll.VerifyPassword(userId, userpwd))
            {
                if (!_bll.ChangePassword(userId, newpwd))
                {
                    tip = "更新密码失败！";
                }
            }
            else
            {
                tip = "当前密码错误，请重新输入当前密码！";
            }

            ClientScript.RegisterStartupScript(GetType(), "", "<script>window.parent.zAlert(\"" + tip + "\");</script>");
        }
    }
}
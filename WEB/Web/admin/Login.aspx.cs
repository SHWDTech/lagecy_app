using System;
using System.Web.UI;
using ESMonitor.BLL;
using Web.Common;

namespace Web.admin
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void UserLogin(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            pwd = Utility.MD5(pwd.ToLower(), 32);
            string verifycode = txtVerify.Text.Trim();
            if (Request.Cookies["VerifyCode"] == null)
            {
                //lblMsg.Text = "您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统";
            }
            //验证码是否证确
            else if (String.Compare(Request.Cookies["VerifyCode"].Value, verifycode.ToUpper(), true) == 0)
            {
                Users bll = new Users();
                ESMonitor.Model.Users model = new ESMonitor.Model.Users();
                lbName.Text = string.Empty;
                lbPwd.Text = string.Empty;
                lbVerify.Text = string.Empty;
                if (bll.Exists(username))
                {
                    if (bll.CheckLogin(username, pwd))
                    {
                        model = bll.GetModel(username);                        
                        if (model.RoleId == 1)
                        {
                            bll.UpdateLastTime(model.UserId);
                            SessionBox.CreateUserSession(new UserSession(model.UserId, model.UserName, model.RoleId, model.ReMark));                            
                            Response.Redirect("index.html");
                        }
                        else
                        {
                            lbName.Text = "无权访问";
                        }
                    }
                    else
                    {
                        lbPwd.Text = "密码错误";
                    }
                }
                else
                {
                    lbName.Text = "用户不存在";
                }
            }
            else
            {
                lbVerify.Text = "验证码错误!";
            }
        }

       
        
    }
}

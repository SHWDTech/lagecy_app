using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

namespace Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                UserLogin();
            }
        }

        protected void UserLogin()
        {
            bool flag = false;
            string username = Request.Form["username"].ToString();
            string pwd = Request.Form["pwd"].ToString();
            pwd = Utility.MD5(pwd.ToLower(), 32);
            string verifycode = Request.Form["verify"].ToString();
            if (Request.Cookies["VerifyCode"] == null)
            {
                //lblMsg.Text = "您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统";
            }
            //验证码是否证确
            else if (String.Compare(Request.Cookies["VerifyCode"].Value, verifycode.ToUpper(), true) == 0)
            {
                ESMonitor.BLL.Users bll = new ESMonitor.BLL.Users();
                ESMonitor.Model.Users model = new ESMonitor.Model.Users();
                if (bll.Exists(username))
                {
                    if (bll.CheckLogin(username, pwd))
                    {
                        model = bll.GetModel(username);
                        bll.UpdateLastTime(model.UserId);
                        if (model.Status == 2)
                        {
                            SessionBox.CreateUserSession(new UserSession(model.UserId, model.UserName, model.RoleId, model.ReMark));
                            Response.Redirect("home.aspx?cityId=" + model.ReMark);
                            flag = true;
                        }
                    }
                }
            }

            if (!flag)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>failure();</script>");

            }
        }
    }
}

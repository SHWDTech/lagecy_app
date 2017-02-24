using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

namespace Web
{
    public partial class ChangePwd : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {         
            if (!IsPostBack)
            {
                if (!SessionBox.CheckUserSession())
                {
                    Response.Redirect("Login.aspx");
                }
                this.ltlUserName.Text = SessionBox.GetUserSession().UserName;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtPwd.Text != "" && this.txtNewPwd.Text != "" && this.txtRepeatPwd.Text != "")
            {
                int id = SessionBox.GetUserSession().UserId;
                
                ESMonitor.BLL.Users bll = new ESMonitor.BLL.Users();

                if (bll.VerifyPassword(id, Web.Common.Utility.MD5(this.txtPwd.Text.Trim().ToLower(), 32)))
                {
                    //两次密码必须输入必须相同
                    if (String.Compare(this.txtNewPwd.Text.Trim(), this.txtRepeatPwd.Text.Trim(), true) == 0)
                    {
                        if (bll.ChangePassword(id, Web.Common.Utility.MD5(this.txtRepeatPwd.Text.Trim().ToLower(), 32)))
                        {
                            //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>window.parent.zAlert(\"密码修改成功!\",\"1500\");</script>");
                        }
                        else
                        {
                            //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>window.parent.zAlert(\"密码修改失败!\",\"1500\");</script>");
                        }
                    }
                    else
                    {
                        this.lbNewPwd.Text = "确认密码与新密码不同";
                    }
                }
                else
                {
                    this.lbPwd.Text = "原密码错误";
                }
            }
        }

    }
}

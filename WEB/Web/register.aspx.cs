using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Web.Common;
using System.Text;

namespace Web
{
    public partial class register : System.Web.UI.Page
    {
        public string zCountry;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Cookies.Add(new HttpCookie("VerifyCode", ""));
                OnRegister();
            }
            else
            {
                LoadCountry();
            }
        }

        private void LoadCountry()
        {
            ArrayList arr = Country.GetData();
            CountryItem item = null;
            StringBuilder sb = new StringBuilder();
            
            sb.Append("[");
            for (int i = 0; i < arr.Count; i++)
            {
                item = (CountryItem)arr[i];
                if (i != arr.Count - 1)
                {
                    sb.AppendFormat("{0}Key:'{1}',Val:'{2}'{3},", "{", item.Id, item.Name, "}");
                }
                else
                {
                    sb.AppendFormat("{0}Key:'{1}',Val:'{2}'{3}", "{", item.Id, item.Name, "}");
                }    
            }
            
            sb.Append("]");
            
            zCountry = sb.ToString();    
        }
        
        
        protected void OnRegister()
        {
            string username = Request.Form["txtUserName"].Trim();
            string pwd = Request.Form["txtPwd"].Trim();
            string repwd = Request.Form["txtConfirmPwd"].Trim();
            string email = Request.Form["txtEmail"].Trim();
            string mobile = Request.Form["txtPhone"].Trim();
            string verifycode = Request.Form["txtValidateCode"].Trim();
            string remark = Request.Form["txtCountry"].Trim();
            if (Request.Cookies["VerifyCode"] == null)
            {
                //lblMsg.Text = "您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统";
            }
            //验证码是否证确
            else if (String.Compare(Request.Cookies["VerifyCode"].Value, verifycode.ToUpper(), true) == 0)
            {
                if (username != "" && pwd != "" && repwd != "" && email != "" && verifycode != "")
                {
                    //两次密码必须输入必须相同
                    if (String.Compare(pwd, repwd, true) == 0)
                    {
                        ESMonitor.BLL.Users bll = new ESMonitor.BLL.Users();
                        ESMonitor.Model.Users model = new ESMonitor.Model.Users();
                        
                        if (!bll.Exists(username))//用户不存在
                        {
                            model.UserName = username;
                            model.Pwd = Utility.MD5(pwd.ToLower(), 32);
                            model.Email = email;
                            model.Mobile = mobile;
                            model.NowTime = DateTime.Now;
                            model.RoleId = 2; //普通会员
                            model.Status = 1; //待审核
                            model.ReMark = remark;

                            int n = bll.Add(model);

                            if (n >= 1)
                            {
                                Response.Redirect("home.aspx?cityId=" + remark);
                            }
                            else
                            {
                                //this.ltlName.Text = "注册失败";
                            }
                        }
                        else
                        {
                            //this.ltlName.Text = "用户名已使用";
                        }
                    }
                    else
                    {

                    }
                    //lblMsg.Text = "两次密码不一致";
                }
            }
            else
            {
                //lblMsg.Text = "验证码错误";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Web
{
    public partial class UserAuths : System.Web.UI.Page
    {
        public string zAreaNodeStr = string.Empty;
        public string zCmdNodeStr = string.Empty;
        public string zUserNodeStr = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitAreaTree();
                InitCmdTree();
                InitUserTree();
//                this.btnAdd.Attributes.Add("OnClick", "return validate();");
            }
        }

        private void InitAreaTree()
        {
            zAreaNodeStr = Tree.Instance().GetTree(false, false, false, false);
        }

        private void InitCmdTree()
        {
            //StringBuilder sb = new StringBuilder();
            //ESMonitor.BLL.CmdDictionary bll = new ESMonitor.BLL.CmdDictionary();
            //DataTable dt = bll.GetList("ConfigEnable=1").Tables[0];
            
            //sb.Append("[");
            //foreach (DataRow dr in dt.Rows)
            //{
            //    sb.AppendFormat("{0}id:{1},pId:0,name:\"{2}\",checked:true{3},", "{", dr["Id"], dr["Name"], "}"); 
            //}

            //if (sb.Length > 1)
            //{
            //    sb = sb.Remove(sb.Length - 1, 1);
            //}

            //sb.Append("]");
            //zCmdNodeStr = sb.ToString();
        }

        private void InitUserTree()
        {
            StringBuilder sb = new StringBuilder();
            ESMonitor.BLL.Users bll = new ESMonitor.BLL.Users();
            List<string> list = bll.GetUsesList("");

            sb.Append("[");
            foreach (string str in list)
            {
                string[] s = str.Split(',');

                sb.AppendFormat("{0}id:{1},pId:0,name:\"{2}\",checked:true{3},", "{", s[0], s[1], "}");
            }

            if (sb.Length > 1)
            {
                sb = sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("]");

            zUserNodeStr = sb.ToString();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //string tip = string.Empty;
            //string pictureName = string.Empty;
            //string email = string.Empty;
            //string username = this.txtUserName.Text.Trim();
            //string pwd = this.txtPwd.Text.Trim();
            //string repwd = this.txtConfirmPwd.Text.Trim();
            //ESMonitor.Model.Users model = new ESMonitor.Model.Users();

            //if (username != "" && pwd != "" && repwd != "")
            //{
            //    //两次密码必须输入必须相同
            //    if (String.Compare(pwd, repwd, true) == 0)
            //    {
            //        if (!bll.Exists(username))//用户不存在
            //        {
            //            model.UserName = username;
            //            model.Pwd = Common.MD5(pwd.ToLower(), 32);
            //            model.Mobile = this.txtMobile.Text.Trim();
            //            model.Email = this.txtEmail.Text.Trim();
            //            model.NowTime = DateTime.Now;
            //            model.Status = 1; //待审核
                        
            //            if (this.rbtn1.Checked)
            //            {
            //                model.RoleId = 2; //管理员
            //            }
            //            else
            //            {
            //                model.RoleId = 1; //超级管理员
            //            }

            //            if (bll.Add(model) > 0)
            //            {
            //                tip = "成功添加用户！";
            //            }
            //            else
            //            {
            //                tip = "添加用户失败...";
            //            }
            //        }
            //        else
            //        {
            //            tip = "用户名已使用";
            //        }
            //    }
            //    else
            //    {
            //        tip = "两次密码不一致";
            //    }
            //}
            //else
            //{
            //    tip = "用户名、密码、确认密码不能为空";
            //}


            //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>window.parent.zAlert(\"" + tip + "\");</script>");


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            //this.txtUserName.Text = "";
            //this.txtPwd.Text = "";
            //this.txtConfirmPwd.Text = "";
            //this.txtMobile.Text = "";
            //this.rbtn1.Checked = true;
        }
    }
}

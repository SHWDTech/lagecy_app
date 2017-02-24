using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Collections;

namespace Web
{
    public partial class UserInGroup : System.Web.UI.Page
    {
        private readonly ESMonitor.BLL.UserInGroups bll = new ESMonitor.BLL.UserInGroups();

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
                    BindUserGroups();
                //}
            }
        }

        private void BindUserGroups()
        {
            ESMonitor.BLL.UserGroup GBll = new ESMonitor.BLL.UserGroup();
            DataTable dt = GBll.GetList("").Tables[0];
            this.ddlGroup.DataSource = dt;
            this.ddlGroup.DataTextField = "Name";
            this.ddlGroup.DataValueField = "Id";
            this.ddlGroup.DataBind();
        }

        private void BindUserInGroup()
        {
            UserList.Items.Clear();
            DataTable dt = bll.GetList("GroupId=" + this.ddlGroup.SelectedValue).Tables[0];

            StringBuilder sb = new StringBuilder();
            string strwhere = string.Empty;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string UserName = dt.Rows[i]["Name"].ToString();
                string UserId = dt.Rows[i]["Id"].ToString();
                UserList.Items.Add(new ListItem(UserName, UserId));
                sb.AppendFormat("{0},", UserId);
            }

            if (sb.Length > 0)
            {
                sb = sb.Remove(sb.Length - 1, 1);
                OldUserList.Text = sb.ToString();
            }

            DataTable dt2 = bll.GetList("GroupId=" + this.ddlGroup.SelectedValue).Tables[0];
            this.FromGroupList.DataSource = dt2;
            this.FromGroupList.DataTextField = "Name";
            this.FromGroupList.DataValueField = "Id";
            this.FromGroupList.DataBind();
        }

        //改变下面的用户组列表信息
        protected void ddlGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlGroup.SelectedIndex > 0)
            {
                BindUserInGroup();
            }
        }

        protected void btn_saverole_Click(object sender, EventArgs e)
        {
            string s = this.TUserList.Text.ToString();

            ESMonitor.BLL.UserInGroups bll = new ESMonitor.BLL.UserInGroups();
            ArrayList ar = new ArrayList();//加加表
            ArrayList dr = new ArrayList();//删除表

            string groupId = this.ddlGroup.SelectedValue;

            if (s != "")
            {
                string[] str = s.Substring(0, s.Length - 1).Split(',');
                string[] ostr = OldUserList.Text.ToString().Split(',');

                Dictionary<string, byte> dic = new Dictionary<string, byte>();
                Dictionary<string, byte> dic2 = new Dictionary<string, byte>();

                foreach (string p in str)
                {
                    dic.Add(p, 0);
                }

                foreach (string p in ostr)
                {
                    dic2.Add(p, 0);
                }

                foreach (string p in str)
                {
                    if (!dic2.ContainsKey(p))
                    {
                        //不存在则添加到插入记录列表
                        ar.Add(groupId + "," + p);
                    }
                }

                foreach (string p in ostr)
                {
                    if (!dic.ContainsKey(p))
                    {
                        //不存在则添加到删除记录列表
                        dr.Add(groupId + "," + p);
                    }
                }
            }
            else
            {
                //如果提交用户为空则删除该用户的所有角色
                string[] ostr = this.OldUserList.Text.ToString().Split(',');
                foreach (string p in ostr)
                {
                    //不存在则添加到删除记录列表
                    dr.Add(groupId + "," + p);
                }
            }

            try
            {
                if (ar.Count != 0) { bll.AddUserInGroups(ar); }
                if (dr.Count != 0) { bll.DeleteUserInGroups(dr); }
                BindUserInGroup();
            }
            catch
            { }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace Web
{
    public partial class left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitMenu();
            }
        }

        /// <summary>
        /// 初始化菜单
        /// </summary>
        protected void InitMenu()
        {
            StringBuilder sb = new StringBuilder();
            ESMonitor.BLL.ModuleType bll = new ESMonitor.BLL.ModuleType();
            ESMonitor.BLL.Modules Mbll = new ESMonitor.BLL.Modules();
            TreeNode node = new TreeNode();
            DataTable ModuleTable = bll.GetList("SuperiorId=0").Tables[0];  //取得所有数据得到DataTable 

            DataView dvList = new DataView(ModuleTable);
            foreach (DataRowView dv in dvList)
            {
                DataTable dt = Mbll.GetList("TypeId=" + dv["Id"].ToString()).Tables[0];
                sb.AppendFormat("<li><a class='head'>{0}</a><ul>", dv["Name"]);
                if (dt.Rows.Count > 0)
                {         
                    foreach (DataRow row in dt.Rows)
                    {
                        if (((row["Disabled"].ToString().ToLower() == "false") 
                            || row["Disabled"].ToString() == "0")
                            && ((row["IsMenu"].ToString().ToLower() == "true")
                            || (row["IsMenu"].ToString() == "1")))

                        {
                            sb.AppendFormat("<li><a href='{0}' target='rightFrame'>{1}</a></li>", row["URL"], row["Name"]);

                        }
                    }
                    
                }
                sb.Append("</ul></li>");
            }

            this.ltlContent.Text = sb.ToString();
        }
    }
}

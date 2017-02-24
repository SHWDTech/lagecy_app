using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;

namespace Web.admin
{
    public partial class top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (!SessionBox.CheckUserSession())
                //{
                //    Response.Redirect("Login.aspx");
                //}
                //this.ltlUserName.Text = SessionBox.GetUserSession().UserName;
            }
        }

       
    }
}

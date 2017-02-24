using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.admin
{
    public partial class CameraAdd : System.Web.UI.Page
    {
        ESMonitor.BLL.Stats _bllStats = new ESMonitor.BLL.Stats();
        ESMonitor.BLL.Devs _bllDevs = new ESMonitor.BLL.Devs();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Request["__EVENTTARGET"] != "ddlState")
                {
                    OnSubmit();
                }
            }
            else
            {
                GetStat();
            }
        }

        protected void GetStat()
        {
            DataSet ds = _bllStats.GetAllList("");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem { Text = dr["StatName"].ToString(), Value = dr["Id"].ToString() };
                ddlState.Items.Add(item);
            }
        }

        protected void GetDevs(object sender, EventArgs e)
        {
            ddlDev.Items.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("StatId = ");
            string statid = ddlState.SelectedValue;
            sb.Append(statid);
            DataSet ds = _bllDevs.GetList(sb.ToString());
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem { Text = dr["DevCode"].ToString(), Value = dr["Id"].ToString() };
                ddlDev.Items.Add(item);
            }
        }

        protected void OnSubmit()
        {
            ESMonitor.Model.Camera model = new ESMonitor.Model.Camera();
            ESMonitor.BLL.Camera _bll = new ESMonitor.BLL.Camera();
            string dnsAddr = txtDnsAddr.Text;
            if (!_bll.Exists(dnsAddr))
            {
                model.DevId = int.Parse(ddlDev.SelectedValue);
                model.DnsAddr = dnsAddr;
                model.UserName = txtUserName.Text.Trim();
                model.PassWord = txtPwd.Text.Trim();

                int camId = _bll.Add(model);
                if (camId > 0)
                {
                    Response.Redirect("CameraAdd.aspx");
                }
            }
            else
            {
                string tip = "已录入该记录";
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert(\"" + tip + "\");</script>");
            }
        }
    }
}
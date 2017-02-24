using System;
using System.Collections;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

namespace Web.admin
{
    public partial class DevAdd : Page
    {
        private readonly ESMonitor.BLL.Devs _bll = new ESMonitor.BLL.Devs();
        private readonly ESMonitor.BLL.Stats _bllStats = new ESMonitor.BLL.Stats();

        private const int PageSize = 10;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Request["__EVENTTARGET"] != "ddlCountry")
                {
                    OnSubmit();                    
                }
            }
            else
            {
                BindCountry();                
            }
        }

        private void BindCountry()
        {
            ArrayList array = Country.GetData();
            ddlCountry.DataSource = array;
            ddlCountry.DataValueField = "Id";
            ddlCountry.DataTextField = "Name";
            ddlCountry.DataBind();
        }

        public void GetStat(object sender, EventArgs e)
        {
            ddlState.Items.Clear();
            string country = ddlCountry.SelectedValue;
            string strWhere = "country=" + country;
            DataSet ds = _bllStats.GetList(strWhere);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem(dr["Statname"].ToString(), dr["Id"].ToString());
                ddlState.Items.Add(item);
            }
        }

        protected void OnSubmit()
        {
            ESMonitor.Model.Devs model = new ESMonitor.Model.Devs();

            string devCode = txtNo.Text.Trim();
            if (!_bll.Exists(devCode))
            {
                model.DevCode = devCode;
                model.StatId = int.Parse(ddlState.SelectedValue);
                model.StartTime = Convert.ToDateTime(txtStartTime.Text);
                model.PreEndTime = Convert.ToDateTime(txtPreEndTime.Text);
                model.EndTime = Convert.ToDateTime(txtRealEndTime.Text);
                model.VideoURL = txtVideoURL.Text.Trim();
                if (rbtn1.Checked)
                {
                    model.DevStatus = 1;
                }
                else
                {
                    model.DevStatus = 0;
                }

                int devId = _bll.Add(model);
                if (devId > 0)
                {
                    string addr = txtAddr.Text.Trim();
                    if ((addr.IndexOf("0x") != -1) || (addr.IndexOf("0X") != -1))
                    {
                        byte[] nodeId = Utility.StringToHexByte(addr.Substring(2, addr.Length - 2));
                        _bll.AddAddr(devId, nodeId);
                    }

                    Response.Redirect("Devs.aspx");
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
using System;
using System.Collections;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.DAL;
using Web.Common;

namespace Web.admin
{
    public partial class StatAdd : Page
    {
        private readonly ESMonitor.BLL.Stats _bll = new ESMonitor.BLL.Stats();

        //private const int PageSize = 10;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCountry();
            if (IsPostBack)
            {
                OnSubmit();
            }
        }

        private void BindCountry()
        {
            ArrayList array = Country.GetData();
            ddlCountry.DataSource = array;
            ddlCountry.DataValueField = "Id";
            ddlCountry.DataTextField = "Name";
            ddlCountry.DataBind();
            const string queryAlarmType = "SELECT * FROM T_AlarmType";
            DataSet ds = DbHelperSQL.Query(queryAlarmType);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem(dr["Name"].ToString().Trim(), dr["ID"].ToString());
                ddlAlarmType.Items.Add(item);
            }
        }

        protected void OnSubmit()
        {
            ESMonitor.Model.Stats model = new ESMonitor.Model.Stats();

            string stateCode = txtStatNo.Text.Trim();
            if (!_bll.Exists(stateCode))
            {
                model.StatName = txtStatName.Text.Trim();
                model.StatCode = stateCode;
                model.Address = txtAddr.Text.Trim();
                model.ChargeMan = txtChargeMan.Text.Trim();
                model.Telepone = txtPhone.Text.Trim();
                model.Department = txtDept.Text.Trim();
                model.Country = ddlCountry.SelectedValue;
                model.Street = txtStreet.Text.Trim();
                model.Square = decimal.Parse(txtSquare.Text.Trim());
                model.Stage = int.Parse(ddlStage.SelectedValue);
                model.ProStartTime = Convert.ToDateTime(txtStartTime.Text);
                string[] location = txtLocation.Text.Trim().Split(';');

                model.Longitude = decimal.Parse(location[0]);
                model.Latitude = decimal.Parse(location[1]);
                model.AlarmType = int.Parse(ddlAlarmType.SelectedValue);

                int ledCtrlId = _bll.Add(model);

                if (ledCtrlId > 0)
                {
                    Response.Redirect("Stats.aspx");
                }
            }
            else
            {
                const string tip = "已录入该记录";
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert(\"" + tip + "\");</script>");
            }
        }


    }
}

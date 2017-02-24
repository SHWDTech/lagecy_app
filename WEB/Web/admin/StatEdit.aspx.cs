using ESMonitor.DAL;
using System;
using System.Collections;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

namespace Web.admin
{
    public partial class StatEdit : Page
    {
        private readonly ESMonitor.BLL.Stats _bll = new ESMonitor.BLL.Stats();
        private readonly ESMonitor.BLL.Devs _devBll = new ESMonitor.BLL.Devs();

        public string statIdPage;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCountry();

                if (Request.Params["id"] != null)
                {
                    int statId = Convert.ToInt32(Request.Params["id"]);
                    GetStat(statId);
                }
            }
            statIdPage = HiddenId.Value = Request.Params["id"];
        }

        private void BindCountry()
        {
            ArrayList array = Country.GetData();
            ddlCountry.DataSource = array;
            ddlCountry.DataValueField = "Id";
            ddlCountry.DataTextField = "Name";
            ddlCountry.DataBind();
            DataSet ds = new DataSet();
            string queryAlarmType = "SELECT * FROM T_AlarmType";
            ds = DbHelperSQL.Query(queryAlarmType);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem(dr["Name"].ToString(), dr["ID"].ToString());
                ddlAlarmType.Items.Add(item);
            }

            string strWhere = string.Format("StatId = {0}", Request.Params["id"]);
            ds = _devBll.GetList(strWhere);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem(dr["DevCode"].ToString(), dr["Id"].ToString());
                ddlDevs.Items.Add(item);
            }
        }

        private void GetStat(int statId)
        {
            ESMonitor.Model.Stats model = _bll.GetModel(statId);

            txtNo.Text = model.StatCode;
            txtName.Text = model.StatName;

            txtAddr.Text = model.Address;
            txtChargeMan.Text = model.ChargeMan;
            txtMobile.Text = model.Telepone;
            txtDept.Text = model.Department;

            foreach (ListItem item in ddlCountry.Items)
            {
                if (item.Value == model.Country)
                {
                    item.Selected = true;
                    break;
                }
            }

            txtStreet.Text = model.Street;
            txtSquare.Text = string.Format("{0:F}", model.Square);

            string stage = model.Stage.ToString();
            foreach (ListItem item in ddlStage.Items)
            {
                if (item.Value == stage)
                {
                    item.Selected = true;
                    break;
                }
            }

            txtStartTime.Text = model.ProStartTime.ToString("yyyy-MM-dd");

            txtLocation.Text = model.Longitude + ";" + model.Latitude;
        }

        protected void OnSubmit(object sender, EventArgs e)
        {
            ESMonitor.Model.Stats model = new ESMonitor.Model.Stats();

            string stateCode = txtNo.Text.Trim();
            model.Id = Convert.ToInt32(HiddenId.Value);
            model.StatName = txtName.Text.Trim();
            model.StatCode = stateCode;
            model.Address = txtAddr.Text.Trim();
            model.ChargeMan = txtChargeMan.Text.Trim();
            model.Telepone = txtMobile.Text.Trim();
            model.Department = txtDept.Text.Trim();
            model.Country = ddlCountry.SelectedValue;
            model.Street = txtStreet.Text.Trim();
            model.Square = decimal.Parse(txtSquare.Text.Trim());
            model.Stage = int.Parse(ddlStage.SelectedValue);
            model.ProStartTime = Convert.ToDateTime(txtStartTime.Text);
            string[] location = txtLocation.Text.Trim().Split(';');

            model.Longitude = decimal.Parse(location[0]);
            model.Latitude = decimal.Parse(location[1]);

            if (_bll.Update(model))
            {
                Response.Redirect("Stats.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert(\"更新失败\");</script>");
            }
        }
    }
}
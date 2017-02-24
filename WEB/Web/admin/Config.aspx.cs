using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.DAL;
using AlarmType = ESMonitor.BLL.AlarmType;

namespace Web.admin
{
    public partial class Config : Page
    {
        public double? OffSetCpm, OffSetPlusCpm, OffSetNoise, OffSetPlusNoise;
        private readonly AlarmType _bll = new AlarmType();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsOffset = DbHelperSQL.Query("SELECT * FROM [T_Offset]");
            OffSetCpm = dsOffset.Tables[0].Rows[0]["OffSetCpm"] as double?;
            OffSetPlusCpm = dsOffset.Tables[0].Rows[0]["OffSetPlusCpm"] as double?;
            OffSetNoise = dsOffset.Tables[0].Rows[0]["OffSetNoise"] as double?;
            OffSetPlusNoise = dsOffset.Tables[0].Rows[0]["OffSetPlusNoise"] as double?;
            t_offsetcpm.Text = string.Format("{0:F}", OffSetCpm);
            t_offsetcpmplus.Text = string.Format("{0:F}", OffSetPlusCpm);
            t_offsetnoise.Text = string.Format("{0:F}", OffSetNoise);
            t_offsetnoiseplus.Text = string.Format("{0:F}", OffSetPlusNoise);
            if (!IsPostBack)
            {
                BindStats();
            }
        }

        private void BindStats()
        {
            DataSet ds = _bll.GetList("");
            Repeater.DataSource = ds.Tables[0];
            Repeater.DataBind();
        }

        protected void Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Del")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                _bll.Delete(id);
            }

            BindStats();

        }

        protected void alarmTypeAdd_Click(object sender, EventArgs e)
        {
            if (alarmName.Text != "" || alarmName.Text.Trim() != "")
            {
                double dustRange = (DustAlarm.Text == "") ? 0.0 : double.Parse(DustAlarm.Text);
                double dbRange = (DbAlarm.Text == "") ? 0.0 : double.Parse(DbAlarm.Text);
                ESMonitor.Model.AlarmType model = new ESMonitor.Model.AlarmType
                {
                    Name = alarmName.Text,
                    DustRange = dustRange,
                    DbRange = dbRange
                };
                _bll.Add(model);
                BindStats();
            }
            else
            {
                const string tip = "请输入报警类型！";
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert(\"" + tip + "\");</script>");
            }
        }

        protected void alarmTypeModify_Click(object sender, EventArgs e)
        {
            if (alarmNameModify.Text != "" || alarmNameModify.Text.Trim() != "")
            {
                double dustRange = (DustAlarmModify.Text == "") ? 0.0 : double.Parse(DustAlarmModify.Text);
                double dbRange = (DbAlarmModify.Text == "") ? 0.0 : double.Parse(DbAlarmModify.Text);
                ESMonitor.Model.AlarmType model = new ESMonitor.Model.AlarmType
                {
                    Id = int.Parse(HiddenField1.Value),
                    Name = alarmNameModify.Text,
                    DustRange = dustRange,
                    DbRange = dbRange
                };
                _bll.Update(model);
                BindStats();
            }
            else
            {
                const string tip = "请输入报警类型！";
                ClientScript.RegisterStartupScript(GetType(), "", "<script>alert(\"" + tip + "\");</script>");
            }
        }
    }
}
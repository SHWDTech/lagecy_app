using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web;
using System.Web.Configuration;
using ESMonitor.DAL;

namespace Web.action
{
	/// <summary>
	/// Config 的摘要说明
	/// </summary>
	public class Config : IHttpHandler
	{

		private readonly JSONHelper _json = new JSONHelper();
		readonly ESMonitor.BLL.AlarmType _bll = new ESMonitor.BLL.AlarmType();
		ESMonitor.Model.AlarmType _model = new ESMonitor.Model.AlarmType();

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/plain";

			if (context.Request.Params["action"] == null)
			{
				_json.error = "非法请求";
			}
			else
			{
				ParseUrlRequset(context);
			}

			context.Response.Write(_json.ToString());
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}

		private void ParseUrlRequset(HttpContext context)
		{
			int action = Convert.ToInt32(context.Request.Params["action"]);

			switch (action)
			{
				case 1:
					ModifyOffSet(context);
					break;
				case 2:
					ModifyAlarmRange(context);
					break;
				case 3:
					ReadALarmRange(context);
					break;
			}
		}

		private void ModifyOffSet(HttpContext context)
		{
			try
			{
				string offsetcpm = context.Request.Params["offsetcpm"];
				string offsetpluscpm = context.Request.Params["offsetpluscpm"];
				string offsetnoise = context.Request.Params["offsetnoise"];
				string offsetplusnoise = context.Request.Params["offsetplusnoise"];
				Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
				AppSettingsSection app = config.AppSettings;
				app.Settings["OffSetCpm"].Value = offsetcpm;
				app.Settings["OffSetPlusCpm"].Value = offsetpluscpm;
				app.Settings["OffSetNoise"].Value = offsetnoise;
				app.Settings["OffSetPlusNoise"].Value = offsetplusnoise;
				config.Save(ConfigurationSaveMode.Modified);
			}
			catch (Exception e)
			{
				_json.error = e.Message;
			}
			_json.ItemOk();
		}

		private void ModifyAlarmRange(HttpContext context)
		{
			try
			{
				string dustRange = context.Request.Params["dustAlarm"];
				string dbRange = context.Request.Params["DbAlarm"];
				string id = context.Request.Params["id"];
				IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8),
					new SqlParameter("@DustRange", SqlDbType.Float, 8),
					new SqlParameter("@DbRange", SqlDbType.Float,8) 
			};
				parameters[0].Value = id;
				parameters[1].Value = dustRange;
				parameters[2].Value = dbRange;
				DbHelperSQL.RunProcedure("T_AlarmType_Update", parameters);
			}
			catch (Exception e)
			{
				_json.error = e.Message;
			}
			_json.success = true;
			_json.ItemOk();
		}

		private void ReadALarmRange(HttpContext context)
		{
			if (context.Request.Params["id"] == null)
			{
				return;
			}
			int id = int.Parse(context.Request.Params["id"]);
			try
			{
				_model = _bll.GetModel(id);
				_json.AddItem("Name", _model.Name.Trim());
				_json.AddItem("DustRange", _model.DustRange.ToString(CultureInfo.CurrentCulture));
				_json.AddItem("DbRange", _model.DbRange.ToString(CultureInfo.CurrentCulture));
			}
			catch (Exception e)
			{
				_json.error = e.Message;
			}
			_json.success = true;
			_json.ItemOk();
		}
	}
}
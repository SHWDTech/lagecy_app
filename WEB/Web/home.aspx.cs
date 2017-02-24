using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Web.UI;
using ESMonitor.BLL;

namespace Web
{
    public partial class Home : Page
    {
        private readonly Alarms _bll = new Alarms();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadAlarmData();
        }

        protected void LoadAlarmData()
        {
            StringBuilder sb = new StringBuilder();
            string cityId = Request.Params["cityId"];
            string startTime = DateTime.Now.ToShortDateString();
            string endTime = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and Country=\'{2}\'", startTime, endTime, cityId);

            DataTable dataTable = _bll.GetDustOverDataCount(sb.ToString()).Tables[0];
            int? tpNum = 0;
            int? dbNum = 0;
            int? totalNum = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                tpNum += dr["TPNum"] as Int32?;
                dbNum += dr["DBNum"] as Int32?;
                totalNum += dr["Total"] as Int32?;
            }
            alarmCMP.Text = string.Format("今日颗粒物报警数：<a href='Analysis.aspx?cityId={0}&id=4'>{1}</a>", cityId, tpNum);
            alarmDB.Text = string.Format("今日噪音值报警数：<a href='Analysis.aspx?cityId={0}&id=4'>{1}</a>", cityId, dbNum);
            alarmTotal.Text = string.Format("今日总报警数：<a href='Analysis.aspx?cityId={0}&id=4'>{1}</a>", cityId, totalNum);
        }
    }
}

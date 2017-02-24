using System;
using System.Data;
using System.Web.UI;
using ESMonitor.BLL;

namespace Web
{
    public partial class ProjectCompare : Page
    {
        private readonly HistoryQuery _bll = new HistoryQuery();
        private int _cityId;
        protected void Page_Load(object sender, EventArgs e)
        {
            _cityId = int.Parse(Request.QueryString["cityId"]);
            DateTime now = DateTime.Now;
            DateTime endtime = new DateTime(now.Year, now.Month, 1);
            DateTime stattime = endtime.AddMonths(-1);
            DataSet historyDataDs = _bll.GetList(4, stattime, endtime, 1, _cityId);
            foreach (DataRow drRow in historyDataDs.Tables[0].Rows)
            {
                drRow["TPAVG"] = (double)drRow["TPAVG"] / 1000.0;
                drRow["PM25AVG"] = (double)drRow["PM25AVG"] / 1000.0;
                drRow["PM100AVG"] = (double)drRow["PM100AVG"] / 1000.0;
            }

            gvProjectCompare.DataSource = historyDataDs;
            gvProjectCompare.DataBind();
        }
    }
}
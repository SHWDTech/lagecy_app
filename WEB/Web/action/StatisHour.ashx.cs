using System;
using System.Data;
using System.Text;
using System.Web;
using ESMonitor.BLL;

namespace Web.action
{
    public class StatisHour : IHttpHandler
    {
        private readonly ESHour _bll = new ESHour();
        private DataTable _dataTable = new DataTable();
        private readonly JSONHelper _json = new JSONHelper();

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

        /// <summary>
        /// 解析数据
        /// </summary>
        /// <param name="context"></param>
        private void ParseUrlRequset(HttpContext context)
        {
            int action = Convert.ToInt32(context.Request.Params["action"]);

            switch (action)
            {
                case 1:
                    GetLastDayEsData(context);
                    break;
                case 2:
                    GetStatDustHourData(context);
                    break;
            }
        }

        
        /// <summary>
        /// 小时均值
        /// </summary>
        /// <param name="context"></param>
        private void GetStatDustHourData(HttpContext context)
        {
            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            if (context.Request.Params["dusttype"] == null)
            {
                return;
            }

            if (context.Request.Params["cityId"] == null)
            {
                return;
            }

            if (context.Request.Params["datetype"] == null)
            {
                return;
            }

            int datetype = int.Parse(context.Request.Params["datetype"]);
            string startTime, endTime;
            if (datetype == 1)
            {
                startTime = DateTime.Now.AddDays(-1).ToShortDateString() + " " + DateTime.Now.AddDays(-1).Hour + ":00";
                endTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            }
            else
            {
                startTime = DateTime.Now.ToShortDateString();
                endTime = startTime + " " + DateTime.Now.ToShortTimeString();
            }
            string dusttype = context.Request.Params["dusttype"];
            string cityId = context.Request.Params["cityId"];
            string sid = context.Request.Params["sid"];
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and StatId ={2}", startTime, endTime, sid);

            if (dusttype == "0")
            {
                _dataTable = _bll.GetAvgCMPStatList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("StatId", dr["StatId"].ToString());
                    _json.AddItem("Val", string.Format("{0:F}",((double)dr["AvgTP"] / 1000.0)));
                    _json.AddItem("Time", DateTime.Parse(dr["UpdateTime"].ToString()).Hour.ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "1")
            {
                _dataTable = _bll.GetAvgNoiseStatList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("StatId", dr["StatId"].ToString());
                    _json.AddItem("Val", string.Format("{0:F}",dr["AvgDB"]));
                    _json.AddItem("Time", DateTime.Parse(dr["UpdateTime"].ToString()).Hour.ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "2")
            {
                _dataTable = _bll.GetAvgPM25StatList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("StatId", dr["StatId"].ToString());
                    _json.AddItem("Val", string.Format("{0:F}", dr["AvgPM25"]));
                    _json.AddItem("Time", DateTime.Parse(dr["UpdateTime"].ToString()).Hour.ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "3")
            {
                _dataTable = _bll.GetAvgPM100StatList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("StatId", dr["StatId"].ToString());
                    _json.AddItem("Val", string.Format("{0:F}", dr["AvgPM100"]));
                    _json.AddItem("Time", DateTime.Parse(dr["UpdateTime"].ToString()).Hour.ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }
        private void GetLastDayEsData(HttpContext context)
        {
            int numOfRecords = 0;
            string strWhere = string.Empty;

            if (context.Request.Params["cityId"] != null)
            {
                strWhere = "Country=" + context.Request.Params["cityId"];
            }

            _dataTable = _bll.GetList(1, strWhere, "UpdateTime DESC").Tables[0];

            foreach (DataRow dr in _dataTable.Rows)
            {
                _json.AddItem("Id", dr["Id"].ToString());
                _json.AddItem("CMP", string.Format("{0:F}",((double)dr["TP"] / 1000.0)));
                _json.AddItem("Noise", string.Format("{0:F}",dr["DB"]));
                _json.AddItem("Time", dr["UpdateTime"].ToString());
                _json.ItemOk();
                numOfRecords++;
                break;
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        
        //#region 不分页
        //private void GetList(string strWhere)
        //{
        //    _dataTable = _bll.GetList(strWhere).Tables[0];
        //}
        //#endregion

        //#region 分页数据

        //private int GetPageCount(string strWhere)
        //{
        //    int ret = _bll.GetRecordCount(strWhere);

        //    return ret;
        //}

        //private void GetPageList(int pageSize, int curPageIndex, string strWhere)
        //{
        //    _dataTable = _bll.GetList(pageSize, curPageIndex, strWhere).Tables[0];
        //}

        //#endregion
    }
}

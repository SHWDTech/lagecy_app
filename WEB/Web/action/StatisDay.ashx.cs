using System;
using System.Data;
using System.Text;
using System.Web;
using ESMonitor.BLL;

namespace Web.action
{
    public class StatisDay : IHttpHandler
    {
        private readonly ESDay _bll = new ESDay();
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

        #region 解析数据
        private void ParseUrlRequset(HttpContext context)
        {
            int action = Convert.ToInt32(context.Request.Params["action"]);

            switch (action)
            {
                case 1:
                    GetLastDayEsData(context);
                    break;
                case 2: //当时均值
                    GetAvgChangeData(context);
                    break;
                case 3: //区县污染物均值排名情况
                    GetDustAvgOrderData(context);
                    break;
                case 4: //历史污染物均值变化情况
                    GetStatDustHistroyData(context);
                    break;
                case 5: //最近一周每日均值变化情况
                    GetStatDustLastWeekData(context);
                    break;
            }
        }
        #endregion

        /// <summary>
        /// 当时均值
        /// </summary>
        /// <param name="context"></param>
        private void GetAvgChangeData(HttpContext context)
        {
            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            if (context.Request.Params["starttime"] == null)
            {
                
            }
            
            if (context.Request.Params["endtime"] == null)
            {
                
            }
            
            if (context.Request.Params["dusttype"] == null)
            {
                
            }

            if (context.Request.Params["cityId"] == null)
            {

            }
            
            string startTime = context.Request.Params["starttime"];
            string endTime = context.Request.Params["endtime"];
            string dusttype = context.Request.Params["dusttype"];
            string cityId = context.Request.Params["cityId"];
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and Country=\'{2}\'", startTime, endTime, cityId);

            if (dusttype == "0")
            {
                _dataTable = _bll.GetAvgCMPList(sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Val", string.Format("{0:F}",((double)(dr["AvgTP"]) / 1000.0)));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.AddItem("type", "颗粒物浓度");
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "1")
            {
                _dataTable = _bll.GetAvgNoiseList(sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Val", string.Format("{0:F}",dr["AvgDB"]));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.AddItem("type", "噪音值");
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "2")
            {
                _dataTable = _bll.GetAvgPM25List(sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Val", string.Format("{0:F}", dr["AvgPM25"]));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.AddItem("type", "PM2.5值");
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "3")
            {
                _dataTable = _bll.GetAvgPM100List(sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Val", string.Format("{0:F}", dr["AvgPM25"]));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.AddItem("type", "PM2.5值");
                    _json.ItemOk();
                    numOfRecords++;
                }
            }


            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        /// <summary>
        /// 查询污染物均值排名情况
        /// </summary>
        /// <param name="context"></param>
        private void GetDustAvgOrderData(HttpContext context)
        {
            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            if (context.Request.Params["starttime"] == null)
            {

            }

            if (context.Request.Params["endtime"] == null)
            {

            }
            
            if (context.Request.Params["dusttype"] == null)
            {

            }
            
            if (context.Request.Params["cityId"] == null)
            {

            }

            string startTime = context.Request.Params["starttime"];
            string endTime = context.Request.Params["endtime"];
            string dusttype = context.Request.Params["dusttype"];
            string cityId = context.Request.Params["cityId"];
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}'", startTime, endTime);

            if (dusttype == "0")
            {
                _dataTable = _bll.GetAvgCMPOrderList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Name", dr["StatName"].ToString());
                    _json.AddItem("Code", dr["DevCode"].ToString());
                    _json.AddItem("Avg", string.Format("{0:F}",(double)dr["AvgTP"] / 1000.0));
                    _json.AddItem("Max", string.Format("{0:F}",(double)dr["MaxTP"] / 1000.0));
                    _json.AddItem("Min", string.Format("{0:F}",(double)dr["MinTP"] / 1000.0));
                    _json.AddItem("ValidDataNum", dr["ValidDataNum"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "1")
            {
                _dataTable = _bll.GetAvgNoiseOrderList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Name", dr["StatName"].ToString());
                    _json.AddItem("Code", dr["DevCode"].ToString());
                    _json.AddItem("Avg", string.Format("{0:F}",dr["AvgDB"]));
                    _json.AddItem("Max", string.Format("{0:F}",dr["MaxDB"]));
                    _json.AddItem("Min", string.Format("{0:F}",dr["MinDB"]));
                    _json.AddItem("ValidDataNum", dr["ValidDataNum"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "2")
            {
                _dataTable = _bll.GetAvgPM25OrderList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Name", dr["StatName"].ToString());
                    _json.AddItem("Code", dr["DevCode"].ToString());
                    _json.AddItem("Avg", string.Format("{0:F}", (double)dr["AvgPM25"] / 1000.0));
                    _json.AddItem("Max", string.Format("{0:F}", (double)dr["MaxPM25"] / 1000.0));
                    _json.AddItem("Min", string.Format("{0:F}", (double)dr["MinPM25"] / 1000.0));
                    _json.AddItem("ValidDataNum", dr["ValidDataNum"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "3")
            {
                _dataTable = _bll.GetAvgPM100OrderList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Name", dr["StatName"].ToString());
                    _json.AddItem("Code", dr["DevCode"].ToString());
                    _json.AddItem("Avg", string.Format("{0:F}", (double)dr["AvgPM100"] / 1000.0));
                    _json.AddItem("Max", string.Format("{0:F}", (double)dr["MaxPM100"] / 1000.0));
                    _json.AddItem("Min", string.Format("{0:F}", (double)dr["MinPM100"] / 1000.0));
                    _json.AddItem("ValidDataNum", dr["ValidDataNum"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        /// <summary>
        /// 历史污染物均值变化情况
        /// </summary>
        /// <param name="context"></param>
        private void GetStatDustHistroyData(HttpContext context)
        {
            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            if (context.Request.Params["starttime"] == null)
            {

            }

            if (context.Request.Params["endtime"] == null)
            {

            }

            if (context.Request.Params["dusttype"] == null)
            {

            }

            if (context.Request.Params["cityId"] == null)
            {

            }

            if (context.Request.Params["stats"] == null)
            {

            }
            
            string startTime = context.Request.Params["starttime"];
            string endTime = context.Request.Params["endtime"];
            string dusttype = context.Request.Params["dusttype"];
            string cityId = context.Request.Params["cityId"];
            string stats = context.Request.Params["stats"];
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and StatId in ({2})", startTime, endTime, stats);

            if (dusttype == "0")
            {
                _dataTable = _bll.GetAvgCMPStatList(cityId, sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("StatId", dr["StatId"].ToString());
                    _json.AddItem("Val", string.Format("{0:F}",(double)dr["AvgTP"] / 1000.0));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                    _json.AddItem("Val", dr["AvgDB"].ToString());
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                    _json.AddItem("Val", string.Format("{0:F}", (double)dr["AvgPM25"] / 1000.0));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                    _json.AddItem("Val", string.Format("{0:F}", (double)dr["AvgPM100"] / 1000.0));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        /// <summary>
        /// 最近一周变化 
        /// </summary>
        /// <param name="context"></param>
        private void GetStatDustLastWeekData(HttpContext context)
        {
            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            if (context.Request.Params["starttime"] == null)
            {

            }

            if (context.Request.Params["endtime"] == null)
            {

            }

            if (context.Request.Params["dusttype"] == null)
            {

            }

            if (context.Request.Params["cityId"] == null)
            {

            }

            if (context.Request.Params["sid"] == null)
            {

            }

            string startTime = DateTime.Now.AddDays(-7).ToShortDateString();
            string endTime = DateTime.Now.ToShortDateString();
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
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                    _json.AddItem("Val", string.Format("{0:F}", (double)dr["AvgPM25"] / 1000.0));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                    _json.AddItem("Val", string.Format("{0:F}", (double)dr["AvgPM100"] / 1000.0));
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
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
                _json.AddItem("PM25", string.Format("{0:F}",((double)dr["PM25"] / 1000.0)));
                _json.AddItem("PM100", string.Format("{0:F}", ((double)dr["PM100"] / 1000.0)));
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

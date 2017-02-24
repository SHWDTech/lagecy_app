using System;
using System.Data;
using System.Text;
using System.Web;
using ESMonitor.BLL;

namespace Web.action
{
    public class Alarm : IHttpHandler
    {
        private readonly Alarms _bll = new Alarms();
        
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
                    GetRealTimeAlarm(context);
                    break;
                case 2:
                    GetStatAlarmRank(context);
                    break;
                case 3:
                    GetAlarmsList(context);
                    break;
            }
        }
        #endregion

        private void GetRealTimeAlarm(HttpContext context)
        {

            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            string startTime = DateTime.Now.ToShortDateString();
            string endTime = startTime + " " + DateTime.Now.ToLongTimeString();
            string cityId = context.Request.Params["cityId"];
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and Country=\'{2}\'", startTime, endTime, cityId);

            _dataTable = _bll.GetDustOverDataCount(sb.ToString()).Tables[0];
            foreach (DataRow dr in _dataTable.Rows)
            {
                _json.AddItem("Name", dr["StatName"].ToString());
                _json.AddItem("TPNum", dr["TPNum"].ToString());
                _json.AddItem("DBNum", dr["DBNum"].ToString());
                _json.AddItem("Total", dr["Total"].ToString());
                _json.ItemOk();
                numOfRecords++;
            }


            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        private void GetStatAlarmRank(HttpContext context)
        {
            int numOfRecords = 0;
            StringBuilder sb = new StringBuilder();

            if (context.Request.Params["starttime"] == null)
            {

            }

            if (context.Request.Params["endtime"] == null)
            {

            }

            if (context.Request.Params["cityId"] == null)
            {

            }

            string startTime = context.Request.Params["starttime"];
            string endTime = context.Request.Params["endtime"];
            string cityId = context.Request.Params["cityId"];
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and Country=\'{2}\'", startTime, endTime, cityId);

            _dataTable = _bll.GetDustOverDataCount(sb.ToString()).Tables[0];
            foreach (DataRow dr in _dataTable.Rows)
            {
                _json.AddItem("Name", dr["StatName"].ToString());
                _json.AddItem("TPNum", dr["TPNum"].ToString());
                _json.AddItem("DBNum", dr["DBNum"].ToString());
                _json.AddItem("Total", dr["Total"].ToString());
                _json.ItemOk();
                numOfRecords++;
            }


            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        private void GetAlarmsList(HttpContext context)
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
                _dataTable = _bll.GetDustOverDataPerDay(sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Val", dr["Total"].ToString());
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "1")
            {
                _dataTable = _bll.GetDustOverDataPerDay(sb.ToString()).Tables[0];
                foreach (DataRow dr in _dataTable.Rows)
                {
                    _json.AddItem("Val", dr["Total"].ToString());
                    _json.AddItem("Time", dr["UpdateTime"].ToString());
                    _json.ItemOk();
                    numOfRecords++;
                }
            }


            _json.success = true;
            _json.totalCount = numOfRecords;
        }
        
        

        #region 不分页
        private void GetList(string strWhere)
        {
            _dataTable = _bll.GetList(strWhere).Tables[0];
        }
        #endregion

        #region 分页数据

        private int GetPageCount(string strWhere)
        {
            int ret = _bll.GetRecordCount(strWhere);

            return ret;
        }

        private void GetPageList(int pageSize, int curPageIndex, string strWhere)
        {
            _dataTable = _bll.GetList(pageSize, curPageIndex, strWhere).Tables[0];
        }

        #endregion
    }
}

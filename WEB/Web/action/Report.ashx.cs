using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Text;

namespace Web.action
{
    public class Report : IHttpHandler
    {
        private readonly ESMonitor.BLL.HistoryQuery bll = new ESMonitor.BLL.HistoryQuery();
        
        private DataTable dataTable = new DataTable();
        private JSONHelper json = new JSONHelper();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Request.Params["action"] == null)
            {
                json.error = "非法请求";
            }
            else
            {
                ParseUrlRequset(context);
            }

            context.Response.Write(json.ToString());
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
                    GetMonthReport(context);
                    break;
                case 2:
                    GetQuaterReport(context);
                    break;
                case 3:
                    GetYearReport(context);
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void GetMonthReport(HttpContext context)
        {
            if (context.Request.Params["cmdType"] == null)
            {
                json.error = "非法请求";
                return;
            }

            if (context.Request.Params["cmdByte"] == null)
            {
                json.error = "非法请求";
                return;
            }

            if (context.Request.Params["cmdParam"] == null)
            {
                json.error = "非法请求";
                return;
            }

            if (context.Request.Params["dev"] == null)
            {
                json.error = "非法请求";
                return;
            }
            
            
            return;
        }

        private void GetQuaterReport(HttpContext context)
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

            string startTime = context.Request.Params["starttime"].ToString();
            string endTime = context.Request.Params["endtime"].ToString();
            string cityId = context.Request.Params["cityId"].ToString();
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and Country=\'{2}\'", startTime, endTime, cityId);

            //dataTable = bll.GetDustOverDataCount(sb.ToString()).Tables[0];
            foreach (DataRow dr in dataTable.Rows)
            {
                json.AddItem("Name", dr["StatName"].ToString());
                json.AddItem("TPNum", dr["TPNum"].ToString());
                json.AddItem("DBNum", dr["DBNum"].ToString());
                json.AddItem("Total", dr["Total"].ToString());
                json.ItemOk();
                numOfRecords++;
            }


            json.success = true;
            json.totalCount = numOfRecords;
        }

        private void GetYearReport(HttpContext context)
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

            string startTime = context.Request.Params["starttime"].ToString();
            string endTime = context.Request.Params["endtime"].ToString();
            string dusttype = context.Request.Params["dusttype"].ToString();
            string cityId = context.Request.Params["cityId"].ToString();
            sb.AppendFormat("UpdateTime >=\'{0}' and UpdateTime <=\'{1}' and Country=\'{2}\'", startTime, endTime, cityId);

            if (dusttype == "0")
            {
                //dataTable = bll.GetDustOverDataPerDay(sb.ToString()).Tables[0];
                foreach (DataRow dr in dataTable.Rows)
                {
                    json.AddItem("Val", dr["Total"].ToString());
                    json.AddItem("Time", dr["UpdateTime"].ToString());
                    json.ItemOk();
                    numOfRecords++;
                }
            }
            else if (dusttype == "1")
            {
                //dataTable = bll.GetDustOverDataPerDay(sb.ToString()).Tables[0];
                foreach (DataRow dr in dataTable.Rows)
                {
                    json.AddItem("Val", dr["Total"].ToString());
                    json.AddItem("Time", dr["UpdateTime"].ToString());
                    json.ItemOk();
                    numOfRecords++;
                }
            }


            json.success = true;
            json.totalCount = numOfRecords;
        }
        
       
    }
}

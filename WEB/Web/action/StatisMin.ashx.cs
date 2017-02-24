using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

namespace Web.action
{
    public class StatisMin : IHttpHandler
    {
        private readonly ESMonitor.BLL.ESMin bll = new ESMonitor.BLL.ESMin();
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
                    GetCurMinData(context);
                    break;
                case 2:
                    GetCurDevMinData(context);
                    break;
                default:
                    break;
            }
        }
        #endregion

        
        
        private void GetCurMinData(HttpContext context)
        {
            int numOfRecords = 0;
            //string strWhere = string.Empty;

            if (context.Request.Params["sid"] == null)
            {
                json.error = "非法请求";
                return;
            }

            int statId = int.Parse(context.Request.Params["sid"]);
            dataTable = bll.GetStatCurData(statId).Tables[0];

            foreach (DataRow dr in dataTable.Rows)
            {
                json.AddItem("PM25", string.Format("{0:F}", ((double)dr["PM25"] / 1000.0)));
                json.AddItem("PM100", string.Format("{0:F}", ((double)dr["PM100"] / 1000.0)));
                json.AddItem("TP", string.Format("{0:F}",((double)dr["TP"] / 1000.0)));
                json.AddItem("DB", string.Format("{0:F}",dr["DB"]));
                json.AddItem("WS", string.Format("{0:F}",dr["WindSpeed"]));
                json.AddItem("WD", dr["WindDirection"].ToString());
                json.AddItem("TEMP", string.Format("{0:F}",dr["Temperature"]));
                json.AddItem("HUM", string.Format("{0:F}",dr["Humidity"]));
                json.AddItem("DevId", dr["DevId"].ToString());
                json.AddItem("UpdateTime", dr["UpdateTime"].ToString());
                json.ItemOk();
                numOfRecords++;
            }

            json.success = true;
            json.totalCount = numOfRecords;
        }

        private void GetCurDevMinData(HttpContext context)
        {
            int numOfRecords = 0;
            //string strWhere = string.Empty;

            if (context.Request.Params["devId"] == null)
            {
                json.error = "非法请求";
                return;
            }

            int devId = int.Parse(context.Request.Params["devId"]);
            dataTable = bll.GetCurDevData(devId).Tables[0];

            foreach (DataRow dr in dataTable.Rows)
            {
                json.AddItem("PM25", string.Format("{0:F}", ((double)dr["PM25"] / 1000.0)));
                json.AddItem("PM100", string.Format("{0:F}", ((double)dr["PM100"] / 1000.0)));
                json.AddItem("CMP", string.Format("{0:F}", ((double)dr["TP"] / 1000.0)));
                json.AddItem("CMPState", "1");
                json.AddItem("Noise", string.Format("{0:F}", dr["DB"]));
                json.AddItem("NoiseState", "1");
                json.AddItem("WindSpeed", string.Format("{0:F}", dr["WindSpeed"]));
                json.AddItem("WindDirState", "1");
                json.AddItem("WindDir", dr["WindDirection"].ToString());
                json.AddItem("WindSpeedState", "1");
                json.AddItem("Temp", string.Format("{0:F}", dr["Temperature"]));
                json.AddItem("Humidity", string.Format("{0:F}", dr["Humidity"]));
                json.AddItem("ESState", "1");
                json.AddItem("DevId", dr["DevId"].ToString());
                json.AddItem("Time", dr["UpdateTime"].ToString());
                json.ItemOk();
                numOfRecords++;
            }

            json.success = true;
            json.totalCount = numOfRecords;
        }

        #region 不分页
        private void GetList(string strWhere)
        {
            dataTable = bll.GetList(strWhere).Tables[0];
        }
        #endregion

        #region 分页数据

        private int GetPageCount(string strWhere)
        {
            int ret = bll.GetRecordCount(strWhere);

            return ret;
        }

        private void GetPageList(int pageSize, int curPageIndex, string strWhere)
        {
            dataTable = bll.GetList(pageSize, curPageIndex, strWhere).Tables[0];
        }

        #endregion
    }
}

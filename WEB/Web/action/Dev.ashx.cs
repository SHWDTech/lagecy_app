using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

namespace Web.action
{
    public class Dev : IHttpHandler
    {
        private readonly ESMonitor.BLL.Devs bll = new ESMonitor.BLL.Devs();
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
                    GetAllDev(context);
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void GetAllDev(HttpContext context)
        {
            int numOfRecords = 0;
            string strWhere = string.Empty;
            
            GetList(strWhere);
            
            foreach (DataRow dr in dataTable.Rows)
            {
                json.AddItem("Name", dr["StatName"].ToString());
                json.AddItem("Addr", dr["Address"].ToString());
                json.AddItem("Depart", dr["Department"].ToString());
                json.AddItem("Stage", dr["Stage"].ToString());
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

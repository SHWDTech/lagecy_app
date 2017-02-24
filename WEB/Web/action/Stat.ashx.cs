using System;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Web;
using ESMonitor.BLL;
using log4net;
using Web.Common;

namespace Web.action
{
    public class Stat : IHttpHandler
    {

        private readonly ESMonitor.BLL.Stats _bll = new ESMonitor.BLL.Stats();
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
                    GetAllStats(context);
                    break;
                case 2:
                    GetStatEsData(context);
                    break;
                case 3:
                    GetModel(context);
                    break;
                case 4:
                    GetStatsNameByCountry(context);
                    break;
            }
        }
        #endregion

        private void GetAllStats(HttpContext context)
        {
            int numOfRecords = 0;
            string strWhere = string.Empty;

            if (context.Request.Params["cityId"] != null)
            {
                strWhere = "Country=" + context.Request.Params["cityId"];
            }

            _dataTable = _bll.GetList(strWhere).Tables[0];

            foreach (DataRow dr in _dataTable.Rows)
            {
                _json.AddItem("Id", dr["Id"].ToString());
                _json.AddItem("Man", dr["ChargeMan"].ToString());
                _json.AddItem("Mobile", dr["Telepone"].ToString());
                _json.AddItem("Name", dr["StatName"].ToString());
                _json.AddItem("Addr", dr["Address"].ToString());
                _json.AddItem("Depart", dr["Department"].ToString());
                _json.AddItem("Stage", Stage.GetStage(dr["Stage"].ToString()));
                _json.AddItem("Long", dr["Longitude"].ToString());
                _json.AddItem("Lant", dr["Latitude"].ToString());
                _json.ItemOk();
                numOfRecords++;
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        private void GetStatEsData(HttpContext context)
        {
            int numOfRecords = 0;
            string strWhere = string.Empty;
            string statId = string.Empty;

            if (context.Request.Params["id"] != null)
            {
                statId = context.Request.Params["id"];
                strWhere = "StatId=" + statId;
            }
            ESDay esBll = new ESDay();
            _dataTable = esBll.GetList(1, strWhere, "UpdateTime DESC").Tables[0];

            foreach (DataRow dr in _dataTable.Rows)
            {
                DateTime dt = (DateTime)dr["UpdateTime"];
                _json.AddItem("Id", statId);
                _json.AddItem("CMP", string.Format("{0:F}", (double)dr["TP"] / 1000.0));
                _json.AddItem("Noise", string.Format("{0:F}", dr["DB"]));
                _json.AddItem("Time", string.Format("{0:G}", dt));
                _json.ItemOk();
                numOfRecords++;
                break;
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        private void GetModel(HttpContext context)
        {
            int numOfRecords = 0;
            int statId = 0;

            if (context.Request.Params["sid"] != null)
            {
                statId = int.Parse(context.Request.Params["sid"]);
            }

            ESMonitor.Model.Stats model = _bll.GetModel(statId);

            if (model != null)
            {
                _json.AddItem("Id", model.Id.ToString());
                _json.AddItem("Man", model.ChargeMan);
                _json.AddItem("Mobile", model.Telepone);
                _json.AddItem("Name", model.StatName);
                _json.AddItem("Addr", model.Address);
                _json.AddItem("Depart", model.Department);
                _json.AddItem("Square", model.Square.ToString(CultureInfo.InvariantCulture));
                _json.AddItem("Country", Country.GetName(model.Country));
                _json.AddItem("Stage", Stage.GetStage(model.Stage.ToString()));
                _json.AddItem("Long", model.Longitude.ToString(CultureInfo.InvariantCulture));
                _json.AddItem("Lant", model.Latitude.ToString(CultureInfo.InvariantCulture));
                _json.AddItem("StartTime", model.ProStartTime.ToString("yyyy-MM-dd"));
                _json.AddItem("Street", model.Street);

                _json.ItemOk();
                numOfRecords++;
            }

            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        private void GetStatsNameByCountry(HttpContext context)
        {
            int country = 0;
            int numOfRecords = 0;
            if (context.Request.Params["country"] != null)
            {
                country = int.Parse(context.Request.Params["country"]);
            }
            string strWhere = "country=" + country;
            DataSet ds = _bll.GetList(strWhere);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _json.AddItem("StatName", dr["StatName"].ToString());
                _json.AddItem("Id", dr["Id"].ToString());
                _json.ItemOk();
                numOfRecords++;
            }
            _json.success = true;
            _json.totalCount = numOfRecords;
        }

        #region 不分页
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

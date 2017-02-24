using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using ESMonitor.BLL;

namespace Web
{
    public partial class RealTimeMonitoring : System.Web.UI.Page
    {
        public float OffSetCpm, OffSetPlusCpm, OffSetNoise, OffSetPlusNoise;
        private int _devsNum;

        protected void Page_Load(object sender, EventArgs e)
        {
            OffSetCpm = float.Parse(ConfigurationManager.AppSettings["OffSetCpm"]);
            OffSetPlusCpm = float.Parse(ConfigurationManager.AppSettings["OffSetPlusCpm"]);
            OffSetNoise = float.Parse(ConfigurationManager.AppSettings["OffSetNoise"]);
            OffSetPlusNoise = float.Parse(ConfigurationManager.AppSettings["OffSetPlusNoise"]);
            string SiteId = Request.QueryString["sid"];
            if (SiteId == "") return;
            ESMonitor.BLL.Devs NDevs = new ESMonitor.BLL.Devs();
            ESMonitor.BLL.Stats NStats = new ESMonitor.BLL.Stats();
            string StatName = NStats.GetModel(int.Parse(SiteId)).StatName;
            DataSet DevList = NDevs.GetList(string.Format("[statid] = {0}", SiteId));
            _devsNum = 0;
            foreach (DataRow dr in DevList.Tables[0].Rows)
            {
                _devsNum++;
                ListItem item = new ListItem();
                item.Value = dr["ID"].ToString();
                item.Text = StatName + string.Format("第{0}号设备", _devsNum);
                selDevs.Items.Add(item);
            }
            selDevs.SelectedIndex = 1;
        }
    }
}
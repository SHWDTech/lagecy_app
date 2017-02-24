using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Web.UI;
using System.Web;
using System.Text;

namespace Web
{
    public partial class StatPic : Page
    {
        ESMonitor.BLL.Devs bll = new ESMonitor.BLL.Devs();
        public string statName, DevName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetDevs();
            }
        }

        protected void GetDevs()
        {
            string statId = Request.Params["sid"];
            string strWhere = "StatId =" + statId;
            DataSet ds = bll.GetList(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListItem item = new ListItem { Text = dr["DevCode"].ToString(), Value = dr["Id"].ToString() };
                    controlPreset.Items.Add(item);
                }
                devId.Value = controlPreset.SelectedValue;
                devCode.Value = Server.UrlEncode(controlPreset.SelectedItem.Text);
            }
            ESMonitor.BLL.Stats bllstat = new ESMonitor.BLL.Stats();
            statName = bllstat.GetModel(int.Parse(statId)).StatName;
            DevName = controlPreset.SelectedItem.Text;
        }
    }
}

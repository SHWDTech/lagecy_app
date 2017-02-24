using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.DAL;

namespace Web.admin
{
    public partial class DeviceConfigAll : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ESMonitor.BLL.Devs bll = new ESMonitor.BLL.Devs();
            DataSet ds = bll.GetAllList();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ListItem item = new ListItem { Value = dr["ID"].ToString(), Text = dr["DevCode"].ToString() };
                selDevs.Items.Add(item);
            }
            selDevs.SelectedIndex = 1;
        }
    }
}
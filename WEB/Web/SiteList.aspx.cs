using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web
{
    public partial class SiteList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //BindStats();
            }
        }

        //private void BindStats()
        //{
        //    DataSet ds = new DataSet();
        //    ESMonitor.BLL.Stats bll = new ESMonitor.BLL.Stats();

        //    ds = bll.GetList("");

        //    this.Repeater.DataSource = ds.Tables[0];
        //    this.Repeater.DataBind();
        //}

        //protected void Repeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        DataRowView drv = (DataRowView)e.Item.DataItem;
        //        Literal ltl = (Literal)e.Item.FindControl("ltlStage");
        //        int stage = int.Parse(drv["Stage"].ToString());

        //        switch (stage)
        //        {
        //            case 0:
        //                ltl.Text = "基础";
        //                break;
        //            case 1:
        //                ltl.Text = "结构";
        //                break;
        //            case 2:
        //                ltl.Text = "完工";
        //                break;
        //        }
        //    }
        //}
    }
}

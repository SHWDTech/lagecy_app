using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace ESMonitor.Web.ESDay
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		ESMonitor.BLL.ESDay bll=new ESMonitor.BLL.ESDay();
		ESMonitor.Model.ESDay model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblStatCode.Text=model.StatCode;
		this.lblTP.Text=model.TP.ToString();
		this.lblDB.Text=model.DB.ToString();
		this.lblDatatime.Text=model.Datatime.ToString();
		this.lblDataStatus.Text=model.DataStatus;
		this.lblValidDataNum.Text=model.ValidDataNum.ToString();

	}


    }
}

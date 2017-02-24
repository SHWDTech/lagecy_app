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
namespace ESMonitor.Web.Stats
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
		ESMonitor.BLL.Stats bll=new ESMonitor.BLL.Stats();
		ESMonitor.Model.Stats model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblStatCode.Text=model.StatCode;
		this.lblStatName.Text=model.StatName;
		this.lblChargeMan.Text=model.ChargeMan;
		this.lblTelepone.Text=model.Telepone;
		this.lblLongitude.Text=model.Longitude.ToString();
		this.lblDepartment.Text=model.Department;
		this.lblAdress.Text=model.Adress;
		this.lblCountry.Text=model.Country;
		this.lblStreet.Text=model.Street;
		this.lblSquare.Text=model.Square.ToString();
		this.lblProStartTime.Text=model.ProStartTime.ToString();
		this.lblStage.Text=model.Stage.ToString();

	}


    }
}

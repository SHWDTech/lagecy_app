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
namespace ESMonitor.Web.Devs
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
		ESMonitor.BLL.Devs bll=new ESMonitor.BLL.Devs();
		ESMonitor.Model.Devs model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDevCode.Text=model.DevCode;
		this.lblStatCode.Text=model.StatCode;
		this.lblStartTime.Text=model.StartTime.ToString();
		this.lblPreEndTime.Text=model.PreEndTime.ToString();
		this.lblEndTime.Text=model.EndTime.ToString();
		this.lblDevStatus.Text=model.DevStatus.ToString();
		this.lblVideoURL.Text=model.VideoURL;

	}


    }
}

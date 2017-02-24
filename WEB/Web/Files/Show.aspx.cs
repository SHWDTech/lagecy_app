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
namespace ESMonitor.Web.Files
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
		ESMonitor.BLL.Files bll=new ESMonitor.BLL.Files();
		ESMonitor.Model.Files model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblStatCode.Text=model.StatCode;
		this.lblCapTime.Text=model.CapTime.ToString();
		this.lblType.Text=model.Type.ToString();
		this.lblFileName.Text=model.FileName;
		this.lblPath.Text=model.Path;

	}


    }
}

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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace ESMonitor.Web.Stats
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		ESMonitor.BLL.Stats bll=new ESMonitor.BLL.Stats();
		ESMonitor.Model.Stats model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtStatCode.Text=model.StatCode;
		this.txtStatName.Text=model.StatName;
		this.txtChargeMan.Text=model.ChargeMan;
		this.txtTelepone.Text=model.Telepone;
		this.txtLongitude.Text=model.Longitude.ToString();
		this.txtDepartment.Text=model.Department;
		this.txtAdress.Text=model.Adress;
		this.txtCountry.Text=model.Country;
		this.txtStreet.Text=model.Street;
		this.txtSquare.Text=model.Square.ToString();
		this.txtProStartTime.Text=model.ProStartTime.ToString();
		this.txtStage.Text=model.Stage.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStatCode.Text.Trim().Length==0)
			{
				strErr+="StatCode不能为空！\\n";	
			}
			if(this.txtStatName.Text.Trim().Length==0)
			{
				strErr+="StatName不能为空！\\n";	
			}
			if(this.txtChargeMan.Text.Trim().Length==0)
			{
				strErr+="ChargeMan不能为空！\\n";	
			}
			if(this.txtTelepone.Text.Trim().Length==0)
			{
				strErr+="Telepone不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLongitude.Text))
			{
				strErr+="Longitude格式错误！\\n";	
			}
			if(this.txtDepartment.Text.Trim().Length==0)
			{
				strErr+="Department不能为空！\\n";	
			}
			if(this.txtAdress.Text.Trim().Length==0)
			{
				strErr+="Adress不能为空！\\n";	
			}
			if(this.txtCountry.Text.Trim().Length==0)
			{
				strErr+="Country不能为空！\\n";	
			}
			if(this.txtStreet.Text.Trim().Length==0)
			{
				strErr+="Street不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSquare.Text))
			{
				strErr+="Square格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtProStartTime.Text))
			{
				strErr+="ProStartTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStage.Text))
			{
				strErr+="Stage格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string StatCode=this.txtStatCode.Text;
			string StatName=this.txtStatName.Text;
			string ChargeMan=this.txtChargeMan.Text;
			string Telepone=this.txtTelepone.Text;
			decimal Longitude=decimal.Parse(this.txtLongitude.Text);
			string Department=this.txtDepartment.Text;
			string Adress=this.txtAdress.Text;
			string Country=this.txtCountry.Text;
			string Street=this.txtStreet.Text;
			decimal Square=decimal.Parse(this.txtSquare.Text);
			DateTime ProStartTime=DateTime.Parse(this.txtProStartTime.Text);
			int Stage=int.Parse(this.txtStage.Text);


			ESMonitor.Model.Stats model=new ESMonitor.Model.Stats();
			model.Id=Id;
			model.StatCode=StatCode;
			model.StatName=StatName;
			model.ChargeMan=ChargeMan;
			model.Telepone=Telepone;
			model.Longitude=Longitude;
			model.Department=Department;
			model.Adress=Adress;
			model.Country=Country;
			model.Street=Street;
			model.Square=Square;
			model.ProStartTime=ProStartTime;
			model.Stage=Stage;

			ESMonitor.BLL.Stats bll=new ESMonitor.BLL.Stats();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

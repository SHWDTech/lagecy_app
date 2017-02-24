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
namespace ESMonitor.Web.Devs
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
		ESMonitor.BLL.Devs bll=new ESMonitor.BLL.Devs();
		ESMonitor.Model.Devs model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtDevCode.Text=model.DevCode;
		this.txtStatCode.Text=model.StatCode;
		this.txtStartTime.Text=model.StartTime.ToString();
		this.txtPreEndTime.Text=model.PreEndTime.ToString();
		this.txtEndTime.Text=model.EndTime.ToString();
		this.txtDevStatus.Text=model.DevStatus.ToString();
		this.txtVideoURL.Text=model.VideoURL;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDevCode.Text.Trim().Length==0)
			{
				strErr+="DevCode不能为空！\\n";	
			}
			if(this.txtStatCode.Text.Trim().Length==0)
			{
				strErr+="StatCode不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtStartTime.Text))
			{
				strErr+="StartTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPreEndTime.Text))
			{
				strErr+="PreEndTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEndTime.Text))
			{
				strErr+="EndTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDevStatus.Text))
			{
				strErr+="DevStatus格式错误！\\n";	
			}
			if(this.txtVideoURL.Text.Trim().Length==0)
			{
				strErr+="VideoURL不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string DevCode=this.txtDevCode.Text;
			string StatCode=this.txtStatCode.Text;
			DateTime StartTime=DateTime.Parse(this.txtStartTime.Text);
			DateTime PreEndTime=DateTime.Parse(this.txtPreEndTime.Text);
			DateTime EndTime=DateTime.Parse(this.txtEndTime.Text);
			int DevStatus=int.Parse(this.txtDevStatus.Text);
			string VideoURL=this.txtVideoURL.Text;


			ESMonitor.Model.Devs model=new ESMonitor.Model.Devs();
			model.Id=Id;
			model.DevCode=DevCode;
			model.StatCode=StatCode;
			model.StartTime=StartTime;
			model.PreEndTime=PreEndTime;
			model.EndTime=EndTime;
			model.DevStatus=DevStatus;
			model.VideoURL=VideoURL;

			ESMonitor.BLL.Devs bll=new ESMonitor.BLL.Devs();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

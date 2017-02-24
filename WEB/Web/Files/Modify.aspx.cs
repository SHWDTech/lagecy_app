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
namespace ESMonitor.Web.Files
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
		ESMonitor.BLL.Files bll=new ESMonitor.BLL.Files();
		ESMonitor.Model.Files model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtStatCode.Text=model.StatCode;
		this.txtCapTime.Text=model.CapTime.ToString();
		this.txtType.Text=model.Type.ToString();
		this.txtFileName.Text=model.FileName;
		this.txtPath.Text=model.Path;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStatCode.Text.Trim().Length==0)
			{
				strErr+="StatCode不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCapTime.Text))
			{
				strErr+="CapTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtType.Text))
			{
				strErr+="Type格式错误！\\n";	
			}
			if(this.txtFileName.Text.Trim().Length==0)
			{
				strErr+="FileName不能为空！\\n";	
			}
			if(this.txtPath.Text.Trim().Length==0)
			{
				strErr+="Path不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			string StatCode=this.txtStatCode.Text;
			DateTime CapTime=DateTime.Parse(this.txtCapTime.Text);
			int Type=int.Parse(this.txtType.Text);
			string FileName=this.txtFileName.Text;
			string Path=this.txtPath.Text;


			ESMonitor.Model.Files model=new ESMonitor.Model.Files();
			model.Id=Id;
			model.StatCode=StatCode;
			model.CapTime=CapTime;
			model.Type=Type;
			model.FileName=FileName;
			model.Path=Path;

			ESMonitor.BLL.Files bll=new ESMonitor.BLL.Files();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

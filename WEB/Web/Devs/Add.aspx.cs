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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string DevCode=this.txtDevCode.Text;
			string StatCode=this.txtStatCode.Text;
			DateTime StartTime=DateTime.Parse(this.txtStartTime.Text);
			DateTime PreEndTime=DateTime.Parse(this.txtPreEndTime.Text);
			DateTime EndTime=DateTime.Parse(this.txtEndTime.Text);
			int DevStatus=int.Parse(this.txtDevStatus.Text);
			string VideoURL=this.txtVideoURL.Text;

			ESMonitor.Model.Devs model=new ESMonitor.Model.Devs();
			model.DevCode=DevCode;
			model.StatCode=StatCode;
			model.StartTime=StartTime;
			model.PreEndTime=PreEndTime;
			model.EndTime=EndTime;
			model.DevStatus=DevStatus;
			model.VideoURL=VideoURL;

			ESMonitor.BLL.Devs bll=new ESMonitor.BLL.Devs();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

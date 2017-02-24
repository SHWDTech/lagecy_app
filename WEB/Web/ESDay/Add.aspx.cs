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
namespace ESMonitor.Web.ESDay
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStatCode.Text.Trim().Length==0)
			{
				strErr+="StatCode不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTP.Text))
			{
				strErr+="TP格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDB.Text))
			{
				strErr+="DB格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDatatime.Text))
			{
				strErr+="Datatime格式错误！\\n";	
			}
			if(this.txtDataStatus.Text.Trim().Length==0)
			{
				strErr+="DataStatus不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtValidDataNum.Text))
			{
				strErr+="ValidDataNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string StatCode=this.txtStatCode.Text;
			decimal TP=decimal.Parse(this.txtTP.Text);
			decimal DB=decimal.Parse(this.txtDB.Text);
			DateTime Datatime=DateTime.Parse(this.txtDatatime.Text);
			string DataStatus=this.txtDataStatus.Text;
			int ValidDataNum=int.Parse(this.txtValidDataNum.Text);

			ESMonitor.Model.ESDay model=new ESMonitor.Model.ESDay();
			model.StatCode=StatCode;
			model.TP=TP;
			model.DB=DB;
			model.Datatime=Datatime;
			model.DataStatus=DataStatus;
			model.ValidDataNum=ValidDataNum;

			ESMonitor.BLL.ESDay bll=new ESMonitor.BLL.ESDay();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

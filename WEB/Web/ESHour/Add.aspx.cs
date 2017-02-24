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
namespace ESMonitor.Web.ESHour
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
			if(!PageValidate.IsDecimal(txtWindSpeed.Text))
			{
				strErr+="WindSpeed格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRain.Text))
			{
				strErr+="Rain格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWindDirection.Text))
			{
				strErr+="WindDirection格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTemperature.Text))
			{
				strErr+="Temperature格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtHumidity.Text))
			{
				strErr+="Humidity格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAirpressure.Text))
			{
				strErr+="Airpressure格式错误！\\n";	
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
			decimal WindSpeed=decimal.Parse(this.txtWindSpeed.Text);
			decimal Rain=decimal.Parse(this.txtRain.Text);
			decimal WindDirection=decimal.Parse(this.txtWindDirection.Text);
			decimal Temperature=decimal.Parse(this.txtTemperature.Text);
			decimal Humidity=decimal.Parse(this.txtHumidity.Text);
			decimal Airpressure=decimal.Parse(this.txtAirpressure.Text);
			string DataStatus=this.txtDataStatus.Text;
			int ValidDataNum=int.Parse(this.txtValidDataNum.Text);

			ESMonitor.Model.ESHour model=new ESMonitor.Model.ESHour();
			model.StatCode=StatCode;
			model.TP=TP;
			model.DB=DB;
			model.Datatime=Datatime;
			model.WindSpeed=WindSpeed;
			model.Rain=Rain;
			model.WindDirection=WindDirection;
			model.Temperature=Temperature;
			model.Humidity=Humidity;
			model.Airpressure=Airpressure;
			model.DataStatus=DataStatus;
			model.ValidDataNum=ValidDataNum;

			ESMonitor.BLL.ESHour bll=new ESMonitor.BLL.ESHour();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}

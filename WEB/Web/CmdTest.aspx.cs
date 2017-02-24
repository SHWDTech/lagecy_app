using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.Common;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Web
{
    public partial class CmdTest : System.Web.UI.Page
    {
        private UInt32 nodeId = 0xFFFFFFFF;
        
        private ESMonitor.BLL.Tasks TBll = new ESMonitor.BLL.Tasks();
        ESMonitor.BLL.TaskNotice TNBll = new ESMonitor.BLL.TaskNotice();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindLocalCtrls();
            }
        }

        private void BindLocalCtrls()
        {
            ESMonitor.BLL.Devs LBll = new ESMonitor.BLL.Devs();

            DataSet ds = new DataSet();
            ds = LBll.GetList("");
            this.ddlLocalCtrls.DataSource = ds;
            this.ddlLocalCtrls.DataTextField = "DevCode";
            this.ddlLocalCtrls.DataValueField = "DevId";
            //this.ddlLocalCtrls.DataBind();
        }
        
        protected void OnUpdateAES(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeCMPReadCmd();
            cmd.GetTaskModel(ref model);
            long taskId = 0;
            taskId=TBll.Add(model); 
            if (taskId > 0)
            {                
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
                while (true)
                {
                    byte[] data=new byte[1000];
                    ESMonitor.Model.TaskNotice noticModel = TNBll.GetModel(taskId);
                    if (model != null)
                    {
                        var data1 = noticModel.Data;
                        lblSearchResult.Text = Convert.ToString(data1[2]);
                        break;
                    }
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }
        public UInt16 get_u16_from_data(object data)
        { 
            UInt16 value;
            byte[] data1 = new byte[1000];
            Array.Copy(Serialize(data), data1,1000);
            value = (UInt16)((data1[0] << 8) + data1[1]);
            return value;
        }
        public byte[] Serialize(object data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, data);
                return ms.GetBuffer();
            }
        } 
        protected void btnObjToByte_Click(object sender, EventArgs e)
        {
            object[] objBytes = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
        }
        protected void SecUploadNoisy_Click(object sender, EventArgs e)//测试噪音的
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
            cmd.NodeId = nodeId;
            cmd.EncodeSetAWCmd();
            cmd.GetTaskModel(ref model);
            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnWinDirection_Click(object sender, EventArgs e)//测试风向
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
            cmd.NodeId = nodeId;
            cmd.EncodeReadWindDirCmd(0x01);
            cmd.GetTaskModel(ref model);
            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }
        protected void btnWinSpeed_Click(object sender, EventArgs e)//测试风速
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
            cmd.NodeId = nodeId;
            cmd.EncodeReadWindSpeedCmd(0x01);
            cmd.GetTaskModel(ref model);
            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }
        protected void btnTemHum_Click(object sender, EventArgs e)//测温湿度
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
            cmd.NodeId = nodeId;
            cmd.EncodeReadESDataCmd();
            cmd.GetTaskModel(ref model);
            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }
        protected void btnAllIndex_Click(object sender, EventArgs e)//测试全部
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();//生产一个基础协议类
            cmd.NodeId = nodeId;
            cmd.EncodeReaAllIndexCmd();
            cmd.GetTaskModel(ref model);
            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        //4.1.3 心跳包命令
        protected void btnUpdateHeart_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeCMPCycleSetCmd(2000);
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
            
        }
        protected void OnGetLEDCtrlParam(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeCMStopCmd();
            cmd.GetTaskModel(ref model);
            
            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnAdjustTime_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStopCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnWorkMode_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestResultCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnClearTimePlan_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeSPANTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDownloadPhoneNumber_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeSPANTestStopCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDeletePhoneNumber_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeSPANTestResultCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSelectMSCount_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeSetOUT1Cmd(0x00);
            cmd.GetTaskModel(ref model);


            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnQueryMSContent_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeSetOUT2Cmd(0x00);
            cmd.GetTaskModel(ref model);


            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDeleteMSContent_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeUpInstNoiseOpenCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSelectLocalCtrlAttr_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeUpInstNoiseCloseCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnInitialLED_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeUpInstNoiseCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDeleteLED_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeUpOneSecNoiseOpenCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetLight_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeUpOneSecNoiseCloseCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetFadeTime_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            //DevCtrlCmd cmd = new DevCtrlCmd();
            //cmd.NodeId = nodeId;
            //cmd.EncodeUpOneSecNoiseOpenCmd();
            //cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetLEDLight_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetLogicGroup_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDeleteLogicGroup_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetLEDScene_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDeleteLEDScene_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetLEDPlan_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnDelLEDPlan_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnLEDMaxLight_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }

        }

        protected void btnLEDMinLight_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnFaultLight_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnResetLED_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSetLightParam_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSelectLEDAttr_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSelectLEDPlan_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnLEDGroup_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnSelectLEDScene_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }

        protected void btnUpLEDAlert_Click(object sender, EventArgs e)
        {
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.NodeId = nodeId;
            cmd.EncodeBGTestStartCmd();
            cmd.GetTaskModel(ref model);

            if (TBll.Add(model) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"ok\");</script>");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert(\"error\");</script>");
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class PlanService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ret = -1;
            ret = AddPlans();

            Response.Write(ret.ToString());
            Response.End();

        }

        private int AddPlans()
        {
            int ret = 0;
            LEDMonitor.BLL.LEDCtrlPlans bll = new LEDMonitor.BLL.LEDCtrlPlans();

            string objsStr = Request.Form["tbObjs"].ToString();

            if (objsStr != "")
            {
                string[] objs = objsStr.Split(',');

                //逻辑组下包含了同样的单灯信息，逻辑组配置不同的场景，这个时候怎么办
                foreach (string objTag in objs)
                {
                    if (objTag != "")
                    {
                        string objType = objTag.Substring(0, 1);
                        int objId = Convert.ToInt32(objTag.Substring(1, objTag.Length - 1));

                        //判定操作对象是逻辑组还是单灯
                        if (objType == "C")
                        {
                            Byte hour = Convert.ToByte(Request.Form["txtH" + objTag]);
                            Byte min = Convert.ToByte(Request.Form["txtM" + objTag]);
                            Byte light = Convert.ToByte(Request.Form["txtVal" + objTag]);
                        }
                        else if (objType == "G")
                        {
                            int sceneId = Convert.ToInt32(Request.Form["sel" + objTag]);



                        }
                        else
                        {

                        }
                        //如果是逻辑组要就要检索逻辑组下包含的所有单灯信息
                    }
                }
            }
            else
            {
                ret = 1;
            }

            return ret;
        }
    }
}

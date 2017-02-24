using System;
using System.Data;
using System.Web;
using System.IO;

namespace Web.action
{
    public class Photos : IHttpHandler
    {
        private ESMonApp.Vedio model = new ESMonApp.Vedio();
        private JSONHelper json = new JSONHelper();
        ESMonitor.BLL.Camera bll = new ESMonitor.BLL.Camera();
        ESMonitor.Model.Camera modelca = new ESMonitor.Model.Camera();
        ESMonitor.BLL.Photos bllPhoto = new ESMonitor.BLL.Photos();
        ESMonitor.Model.Photos modelPhoto = new ESMonitor.Model.Photos();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Request.Params["action"] == null)
            {
                json.error = "非法请求";
            }
            else
            {
                ParseUrlRequset(context);
            }

            context.Response.Write(json.ToString());
        }

        #region 解析数据
        private void ParseUrlRequset(HttpContext context)
        {
            int action = Convert.ToInt32(context.Request.Params["action"]);

            switch (action)
            {
                case 1:
                    SetPosition(context);
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void SetPosition(HttpContext context)
        {
            if (context.Request.Params["devCode"] == null)
            {
                json.error = "非法请求";
                return;
            }

            if (context.Request.Params["devId"] == null)
            {
                json.error = "非法请求";
                return;
            }

            if (context.Request.Params["order"] == null)
            {
                json.error = "非法请求";
                return;
            }


            string devCode = context.Request.Params["devCode"].ToString();
            string devId = context.Request.Params["devId"].ToString();
            string order = context.Request.Params["order"].ToString();

            int cmd = ParseOrder(order);
            if (cmd >= 0)
            {
                if (OpenVedio(devId))
                {
                    switch (cmd)
                    {
                        case 1:
                            if (MoveDev(order))
                            {
                                if (!MakePhoto(devCode, devId))
                                {
                                    json.error = "拍照失败";
                                }
                            }
                            else
                            {
                                json.error = "无法调整方位";
                            }
                            break;
                        case 0:
                            if (!MakePhoto(devCode, devId))
                            {
                                json.error = "拍照失败";
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    json.error = "无法连接设备";
                }

                CloseVedio();
            }
            else
            {
                json.error = "无效命令";
            }

            return;
        }

        private bool OpenVedio(string devId)
        {
            
            modelca = bll.GetModel(int.Parse(devId));
            if (modelca == null) return false;
            string DNSAddr = modelca.DnsAddr;
            string DVRIPAddress = ""; //设备IP地址或者域名 Device IP
            Int16 DVRPortNumber = 0;//设备服务端口号 Device Port
            string DVRUserName = modelca.UserName;//设备登录用户名 User name to login
            string DVRPassword = modelca.PassWord;//设备登录密码 Password to login

            if (!model.GetIPAddr(DNSAddr, ref DVRIPAddress, ref DVRPortNumber))
            {
                return false;
            }

            if (!model.Open(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword))
            {
                return false;
            }

            return true;
        }

        private bool CloseVedio()
        {
            model.Close();

            return true;
        }

        private bool MakePhoto(string devCode, string devId)
        {
            DateTime addTime = DateTime.Now;
            string fileName = addTime.ToString("yyyyMMddhhmmss") + ".jpg";//图片保存路径和文件名 the path and file name to save'
            string folder = System.Web.HttpContext.Current.Server.MapPath("/Photos/" + devCode);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string relatePath = "/Photos/" + devCode + "/" + fileName;
            string filePath = System.Web.HttpContext.Current.Server.MapPath(relatePath);

            if (!model.SaveJEPG(filePath))
            {
                return false;
            }

            modelPhoto.DevId = int.Parse(devId);
            modelPhoto.AddTime = addTime;
            modelPhoto.FileName = relatePath;
            bllPhoto.Add(modelPhoto);

            json.AddItem("Url", relatePath);
            json.AddItem("Time", DateTime.Now.ToString());
            json.ItemOk();
            json.success = true;
            json.totalCount = 1;

            return true;
        }

        private int ParseOrder(string order)
        {
            if ((order == "UP")
                || (order == "UP_LEFT")
                || (order == "UP_RIGHT")
                || (order == "DOWN")
                || (order == "DOWN_LEFT")
                || (order == "DOWN_RIGHT")
                || (order == "LEFT")
                || (order == "RIGHT"))
            {
                return 1;
            }
            else if (order == "NO")
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        private bool MoveDev(string dir)
        {
            if (!model.SetPosition(dir))
            {
                return false;
            }

            return true;
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using ESMonitor.BLL;

namespace Web.action
{
    public class Cmd : IHttpHandler
    {
        private readonly Tasks _bll = new Tasks();
        private readonly TaskNotice _tnBll = new TaskNotice();
        private DataTable _dataTable = new DataTable();
        private readonly JSONHelper _json = new JSONHelper();
        private readonly Devs _devlist = new Devs();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Request.Params["action"] == null)
            {
                _json.error = "非法请求";
            }
            else
            {
                ParseUrlRequset(context);
            }

            context.Response.Write(_json.ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        #region 解析数据
        private void ParseUrlRequset(HttpContext context)
        {
            int action = Convert.ToInt32(context.Request.Params["action"]);

            switch (action)
            {
                case 1:
                    AddTask(context);
                    break;
                case 2:
                    GetTaskNotice(context);
                    break;
            }
        }
        #endregion

        private void AddTask(HttpContext context)
        {
            if (context.Request.Params["cmdType"] == null)
            {
                _json.error = "非法请求";
                return;
            }

            if (context.Request.Params["cmdByte"] == null)
            {
                _json.error = "非法请求";
                return;
            }

            if (context.Request.Params["cmdParam"] == null)
            {
                _json.error = "非法请求";
                return;
            }

            if (context.Request.Params["dev"] == null)
            {
                _json.error = "非法请求";
                return;
            }

            Byte cmdType = Convert.ToByte(context.Request.Params["cmdType"]);
            Byte cmdByte = Convert.ToByte(context.Request.Params["cmdByte"]);
            string cmdParams = context.Request.Params["cmdParam"];
            int devId = Convert.ToInt32(context.Request.Params["dev"]);
            if (cmdType == 0xFB)
            {
                GpsInfoTask(devId);
            }

            if (cmdType == 0xFC)
            {
                RequestCmd(devId, cmdByte, cmdParams);
            }
        }

        private void GpsInfoTask(int devId)
        {
            DevCtrlCmd cmd = new DevCtrlCmd();
            cmd.EncodeGpsInfoCmd();
            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            cmd.GetTaskModel(devId, ref model);
            long taksId = _bll.Add(model);
            if (taksId > 0)
            {
                _json.totalCount = 1;
                _json.success = true;
                _json.AddItem("task", taksId.ToString());
                _json.ItemOk();
            }
            else
            {
                _json.success = false;
                _json.error = "新增任务失败";
            }
        }

        private void GetTaskNotice(HttpContext context)
        {
            if (context.Request.Params["task"] == null)
            {
                _json.error = "非法请求";
                return;
            }

            long taskId = Convert.ToInt64(context.Request.Params["task"]);
            ESMonitor.Model.TaskNotice model = _tnBll.GetModel(taskId);

            if (model != null)
            {
                ResponseCmd(model);
                _json.totalCount = 1;
                _json.success = true;
            }
            else
            {
                _json.success = false;
                _json.error = "查询中...";
            }
        }

        private void RequestCmd(int devId, Byte cmdByte, string cmdParams)
        {
            DevCtrlCmd cmd = new DevCtrlCmd();

            switch (cmdByte)
            {
                case 0x1F: //读取CMP
                    cmd.EncodeCMPReadCmd();
                    break;
                case 0x2F:
                    cmd.EncodeCMPCycleSetCmd(2000);
                    break;
                case 0x3F:
                    cmd.EncodeCMStopCmd();

                    break;
                case 0x4F:
                    cmd.EncodeBGTestStartCmd();
                    break;

                case 0x5F:
                    cmd.EncodeBGTestStopCmd();
                    break;
                case 0x6F:
                    cmd.EncodeBGTestResultCmd();
                    break;
                case 0x7F:
                    cmd.EncodeSPANTestStartCmd();
                    break;
                case 0x8F:
                    cmd.EncodeSPANTestStopCmd();
                    break;
                case 0x9F:
                    cmd.EncodeSPANTestResultCmd();
                    break;
                case 0xAF:
                    {
                        byte state = Convert.ToByte(cmdParams);
                        cmd.EncodeSetOUT1Cmd(state);
                    }
                    break;
                case 0xBF:
                    {
                        byte state = Convert.ToByte(cmdParams);
                        cmd.EncodeSetOUT2Cmd(state);
                    }
                    break;
                case 0x1D:
                    cmd.EncodeUpInstNoiseOpenCmd();
                    break;
                case 0x2D:
                    cmd.EncodeUpInstNoiseCloseCmd();
                    break;
                case 0x3D:
                    cmd.EncodeUpInstNoiseCmd();
                    break;
                case 0x4D:
                    cmd.EncodeUpOneSecNoiseOpenCmd();
                    break;
                case 0x5D:
                    cmd.EncodeUpOneSecNoiseCloseCmd();
                    break;
                case 0x6D:
                    cmd.EncodeUpOneSecNoiseCmd();
                    break;
                case 0x7D:
                    cmd.EncodeSetZWCmd();
                    break;
                case 0x8D:
                    cmd.EncodeSetCWCmd();
                    break;
                case 0x9D:
                    cmd.EncodeSetAWCmd();
                    break;
                case 0xAD:
                    cmd.EncodeSetFGCmd();
                    break;
                case 0xBD:
                    cmd.EncodeSetSGCmd();
                    break;
                case 0xCD:
                    cmd.EncodeSetIGCmd();
                    break;
                case 0x1B:
                    {
                        byte addr = Convert.ToByte(cmdParams);
                        cmd.EncodeWindDirWriteDevAddrCmd(addr);
                    }
                    break;
                case 0x2B:
                    {
                        byte addr = Convert.ToByte(cmdParams);
                        cmd.EncodeReadWindDirCmd(addr);
                    }
                    break;
                case 0x1A:
                    {
                        byte addr = Convert.ToByte(cmdParams);
                        cmd.EncodeWindSpeedWriteDevAddrCmd(addr);
                    }
                    break;
                case 0x2A:
                    {
                        byte addr = Convert.ToByte(cmdParams);
                        cmd.EncodeReadWindSpeedCmd(addr);
                    }
                    break;
                case 0x19:
                    cmd.EncodeReadESDataCmd();
                    break;
                case 0x08:
                    cmd.EncodeReadAllDataCmd();
                    break;
                case 0x17:
                    UInt16 cycleTime = Convert.ToUInt16(cmdParams);
                    cmd.EncodeSwitchAutoReport(cycleTime);
                    break;
            }

            if (cmd.CmdByte == 0xAF)
            {
                DataSet ds = _bll.GetLast("175", devId);
                DateTime? dt = ds.Tables[0].Rows[0]["SendTime"] as DateTime?;
                if (dt != null && (DateTime.Now - dt) < new TimeSpan(0, 3, 0))
                {
                    _json.success = false;
                    _json.error = "机械臂复位间隔为3分钟，请稍等！";
                    return;
                }
            }
            else if (cmd.CmdByte == 0xBF)
            {
                DataSet ds = _bll.GetLast("191", devId);
                DateTime? dt = ds.Tables[0].Rows[0]["SendTime"] as DateTime?;
                if (dt != null && (DateTime.Now - dt) < new TimeSpan(0, 3, 0))
                {
                    _json.success = false;
                    _json.error = "机械臂复位间隔为3分钟，请稍等！";
                    return;
                }
            }


            ESMonitor.Model.Tasks model = new ESMonitor.Model.Tasks();
            cmd.GetTaskModel(devId, ref model);
            long taksId = _bll.Add(model);
            if (taksId > 0)
            {
                _json.totalCount = 1;
                _json.success = true;
                _json.AddItem("task", taksId.ToString());
                _json.ItemOk();
            }
            else
            {
                _json.success = false;
                _json.error = "新增任务失败";
            }
        }

        private void ResponseCmd(ESMonitor.Model.TaskNotice model)
        {
            DevCtrlResponseCmd cmd = new DevCtrlResponseCmd();

            bool flag = cmd.DecodeFrame(model.Data, model.Length);
            if (flag)
            {
                switch (cmd.CmdByte)
                {
                    case 0x1F: //读取CMP
                        {
                            double cmp = 0;
                            cmd.DecodeCMPReadCmd(ref cmp);
                            _json.AddItem("CMPState", "1");
                            _json.AddItem("CMP", cmp.ToString(CultureInfo.CurrentCulture));
                        }

                        break;
                    case 0x2F:
                        {
                            if (cmd.CmdType == 0xFB)
                            {
                                if (cmd.Data[0] == 0xFF)
                                {
                                    _json.AddItem("coordinate", "null");
                                    break;
                                }
                                byte[] data = new byte[24];
                                for (int i = 0; i < 24; i++)
                                {
                                    if (cmd.Data[i] == 0x00)
                                    {
                                        data[i] = 0x30;
                                    }
                                    else
                                    {
                                        data[i] = cmd.Data[i];
                                    }
                                }
                                string coordinate = Encoding.ASCII.GetString(data, 0, 24).Insert(12, ",");
                                string url = string.Format("http://api.map.baidu.com/geoconv/v1/?coords={0}&from=1&to=5&ak=0DpSiAEhexZzZR7c7pkYFq7E", coordinate);
                                var request = (HttpWebRequest)WebRequest.Create(url);
                                var response = request.GetResponse();
                                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                                var obj = (Dictionary<string, object>)((object[])((Dictionary<string, object>)jsonSerializer.DeserializeObject(responseString))["result"])[0];
                                double longitude = double.Parse(obj["x"].ToString());
                                double latitude = double.Parse(obj["y"].ToString());
                                coordinate = longitude.ToString("F6") + ";" + latitude.ToString("F6");

                                _json.AddItem("coordinate", coordinate);
                                break;
                            }
                            UInt16 cycleTime = 0;
                            cmd.DecodeCMPCycleSetCmd(ref cycleTime);
                            _json.AddItem("Cycle", cycleTime.ToString());
                        }
                        break;
                    case 0x3F:
                        {
                            byte state = 0;
                            cmd.DecodeCMStopCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x4F:
                        {
                            byte state = 0;
                            cmd.DecodeBGTestStartCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;

                    case 0x5F:
                        {
                            byte state = 0;
                            cmd.DecodeBGTestStopCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x6F:
                        {
                            byte state = 0;
                            cmd.DecodeBGTestResultCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x7F:
                        {
                            byte state = 0;
                            cmd.DecodeSPANTestStartCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x8F:
                        {
                            byte state = 0;
                            cmd.DecodeSPANTestStopCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x9F:
                        {
                            byte state = 0;
                            cmd.DecodeSPANTestResultCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0xAF:
                        {
                            byte state = 0;
                            cmd.DecodeSetOUT1Cmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0xBF:
                        {
                            byte state = 0;
                            cmd.DecodeSetOUT2Cmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x1D:
                        {
                            double noise = 0;
                            cmd.DecodeUpInstNoiseOpenCmd(ref noise);
                            _json.AddItem("Noise", noise.ToString(CultureInfo.CurrentCulture));
                        }
                        break;
                    case 0x2D:
                        {
                            cmd.DecodeUpInstNoiseCloseCmd();
                        }
                        break;
                    case 0x3D:
                        {
                            double noise = 0;
                            cmd.DecodeUpInstNoiseCmd(ref noise);
                            _json.AddItem("Noise", noise.ToString(CultureInfo.CurrentCulture));
                        }
                        break;
                    case 0x4D:
                        {
                            double noise = 0;
                            cmd.DecodeUpOneSecNoiseOpenCmd(ref noise);
                            _json.AddItem("Noise", noise.ToString(CultureInfo.CurrentCulture));
                        }
                        break;
                    case 0x5D:
                        {
                            cmd.DecodeUpOneSecNoiseCloseCmd();
                        }
                        break;
                    case 0x6D:
                        {
                            double noise = 0;
                            cmd.DecodeUpOneSecNoiseCmd(ref noise);
                            _json.AddItem("NoiseState", "1");
                            _json.AddItem("Noise", noise.ToString(CultureInfo.CurrentCulture));
                        }
                        break;
                    case 0x7D:
                        {
                            bool state;
                            state = cmd.DecodeSetZWCmd();
                            _json.AddItem("State", (Convert.ToByte(state)).ToString());
                        }
                        break;
                    case 0x8D:
                        {
                            bool state = false;
                            cmd.DecodeSetCWCmd();
                            _json.AddItem("State", (Convert.ToByte(state)).ToString());
                        }
                        break;
                    case 0x9D:
                        {
                            bool state = false;
                            cmd.DecodeSetAWCmd();
                            _json.AddItem("State", (Convert.ToByte(state)).ToString());
                        }
                        break;
                    case 0xAD:
                        {
                            bool state = false;
                            cmd.DecodeSetFGCmd();
                            _json.AddItem("State", (Convert.ToByte(state)).ToString());
                        }
                        break;
                    case 0xBD:
                        {
                            bool state = false;
                            cmd.DecodeSetSGCmd();
                            _json.AddItem("State", (Convert.ToByte(state)).ToString());
                        }
                        break;
                    case 0xCD:
                        {
                            bool state = false;
                            cmd.DecodeSetIGCmd();
                            _json.AddItem("State", (Convert.ToByte(state)).ToString());
                        }
                        break;
                    case 0x1B:
                        {
                            byte state = 0;
                            flag = cmd.DecodeWindDirWriteDevAddrCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x2B:
                        {
                            byte addr = 0;
                            UInt16 windDir = 0;
                            cmd.DecodeReadWindDirCmd(ref addr, ref windDir);
                            _json.AddItem("WindDirState", "1");
                            _json.AddItem("WindDir", windDir.ToString());
                        }
                        break;
                    case 0x1A:
                        {
                            byte state = 0;
                            cmd.DecodeWindSpeedWriteDevAddrCmd(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                    case 0x2A:
                        {
                            byte addr = 0;
                            double windSpeed = 0;
                            cmd.DecodeReadWindSpeedCmd(ref addr, ref windSpeed);
                            _json.AddItem("WindSpeedState", "1");
                            _json.AddItem("WindSpeed", windSpeed.ToString());
                        }
                        break;
                    case 0x19:
                        {
                            double temperature = 0, humidity = 0;
                            flag = cmd.DecodeReadESDataCmd(ref temperature, ref humidity);
                            _json.AddItem("ESState", "1");
                            _json.AddItem("Temp", temperature.ToString());
                            _json.AddItem("Humidity", "1");
                            _json.AddItem("Humidity", humidity.ToString());
                        }
                        break;
                    case 0x08:
                        {
                            ESData esModel = new ESData();

                            cmd.DecodeReadAllDataCmd(ref esModel);

                            _json.AddItem("PMState", esModel.PmState.ToString());
                            _json.AddItem("Pm25", esModel.Pm25.ToString());
                            _json.AddItem("Pm100", esModel.Pm100.ToString());

                            _json.AddItem("CMPState", esModel.CmpState.ToString());
                            _json.AddItem("CMP", esModel.Cmp.ToString());

                            _json.AddItem("NoiseState", esModel.NoiseState.ToString());
                            _json.AddItem("Noise", esModel.Noise.ToString());

                            _json.AddItem("WindDirState", esModel.WindDirState.ToString());
                            _json.AddItem("WindDir", esModel.WindDir.ToString());

                            _json.AddItem("WindSpeedState", esModel.WindSpeedState.ToString());
                            _json.AddItem("WindSpeed", esModel.WindSpeed.ToString());

                            _json.AddItem("ESState", esModel.ESState.ToString());
                            _json.AddItem("Temp", esModel.Temperature.ToString());
                            _json.AddItem("Humidity", esModel.Humidity.ToString());
                            _json.AddItem("Time", model.UpdateTime.ToString());
                        }
                        break;
                    case 0x17:
                        {
                            byte state = 0;
                            cmd.DecodeSwitchAutoReport(ref state);
                            _json.AddItem("State", state.ToString());
                        }
                        break;
                }

                _json.ItemOk();
            }
            else
            {
                _json.success = false;
                _json.error = "解析命令错误";
            }
        }

        #region 不分页
        private void GetList(string strWhere)
        {
            _dataTable = _bll.GetList(strWhere).Tables[0];
        }
        #endregion

        #region 分页数据

        private int GetPageCount(string strWhere)
        {
            int ret = _bll.GetRecordCount(strWhere);

            return ret;
        }

        private void GetPageList(int pageSize, int curPageIndex, string strWhere)
        {
            _dataTable = _bll.GetList(pageSize, curPageIndex, strWhere).Tables[0];
        }

        #endregion
    }
}

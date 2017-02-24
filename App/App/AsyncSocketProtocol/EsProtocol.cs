using System;
using System.Diagnostics;
using ESMonApp.AsyncSocketCore;
using ESMonApp.AsyncSocketProtocolCore;

namespace ESMonApp.AsyncSocketProtocol
{
    public class EsProtocol : AsyncSocketInvokeElement
    {
        private readonly ESMonitor.BLL.Tasks _bll = new ESMonitor.BLL.Tasks();
        private readonly ESMonitor.BLL.TaskNotice _tnBll = new ESMonitor.BLL.TaskNotice();
        private readonly ESMonitor.BLL.EsMin _esMinBll = new ESMonitor.BLL.EsMin();

        private readonly DevCtrlResponseCmd _responseCmd = new DevCtrlResponseCmd();
        
        public EsProtocol(AsyncSocketServer asyncSocketServer, AsyncSocketUserToken asyncSocketUserToken)
            : base(asyncSocketServer, asyncSocketUserToken)
        {

        }

        public override bool ProcessCommand(byte[] buffer, int offset, int packetLen)//packetLen是总的数据长度
        {
            Debug.WriteLine("开始解析协议。");
            var res = _responseCmd.DecodeFrame(buffer, packetLen);

            if (!res)
            {
                return false;
            }

            var devId = DevsManage.GetDevId(_responseCmd.NodeId);
            Debug.WriteLine($"发送协议的设备号：{devId}");
            if (devId <= 0)
            {
                return false;
            }
            
            //Check command
            switch ((ProtocolCmdType)_responseCmd.CmdType)
            {
                case ProtocolCmdType.SysComm:
                    Debug.WriteLine("心跳包");
                    if (_responseCmd.CmdByte == (Byte)ProtocolCmdByte.HeartBeat)
                    {
                        

                        if (!DevsManage.IsRegistered(devId))
                        {
                            DevsManage.Register(devId);//注册
                            DevsManage.SetDevStatus(devId, (int)CommStatus.Free);
                            EsProtocolMgr.Add(devId, this);
                        }
                        else
                        {
                            if (!EsProtocolMgr.IsSocketConect(devId, this))
                            {
                                EsProtocolMgr.Add(devId, this);//此处顺序有问题
                            }                        
                        }

                        DevsManage.SetTimeOutCount(devId, 3);

                        //更新心跳时间
                        DevsManage.UpdateHeartBeatTime(devId);
                        
                        DoHeartBeat();
                    }
                    break;
                case ProtocolCmdType.ModuleCfg:
                    break;
                case ProtocolCmdType.ModuleCtrl:
                    if (_responseCmd.CmdByte == (byte)ProtocolCmdByte.GetGpsInfo)
                    {
                        Debug.WriteLine("收到GPS协议。。");
                        DevsManage.UpdateRecvTime(devId);
                        AddTaskResponse(devId, buffer, packetLen);
                    }
                    break;
                case ProtocolCmdType.DevCtrl:
                    break;
                case ProtocolCmdType.DevResponse:
                    if (_responseCmd.CmdByte == (Byte)ProtocolCmdByte.AutoUploadAllEsParams)
                    {
                        var esParams = new EsData();

                        if (_responseCmd.DecodeAutoUploadEsParamsCmd(ref esParams))
                        {
                            var dataId = AddEsMin(devId, esParams);
                            var model = new ESMonitor.Model.TaskNotice();
                            try
                            {
                                model.DevId = devId;
                                model.Data = buffer;
                                model.Length = packetLen;
                                model.TaskId = dataId;
                                model.UpdateTime = DateTime.Now;
                                _tnBll.Add(model);
                            }
                            catch (Exception ex)
                            {
                                Program.Logger.ErrorFormat("保存TaskNotice错误: {0},ESMIN_ID{1}，TaskNoticeID{2}", ex.Message, dataId, model.TaskId);
                                Program.Logger.Error(ex.StackTrace);
                            }
                        }
                    }
                    else
                    {
                        DevsManage.UpdateRecvTime(devId);
                        AddTaskResponse(devId, buffer, packetLen);
                    }
                    break;
            }

            return true;
        }

        /// <summary>
        /// 心跳包
        /// </summary>
        /// <returns></returns>
        public bool DoHeartBeat()
        {
            var buffer = new byte[128];
            var bufferLen = 0;
            var cmd = new HeartCmd();

            cmd.EncodeCmd();
            cmd.EncodeFrame(ref buffer, ref bufferLen);

            return DoSendResult(buffer, 0, bufferLen);
        }

        /// <summary>
        /// 保存下位机上传的分钟均值
        /// </summary>
        /// <param name="devId"></param>
        /// <param name="esParams"></param>
        private long AddEsMin(int devId, EsData esParams)
        {
            var model = new ESMonitor.Model.EsMin
            {
                Airpressure = 0,
                DevId = devId,
                UpdateTime = DateTime.Now,
                Pm25 = esParams.Pm25,
                Pm100 = esParams.Pm100,
                Db = esParams.Noise,
                Humidity = esParams.Humidity,
                Temperature = esParams.Temperature,
                Tp = esParams.Cmp,
                WindDirection = esParams.WindDir,
                WindSpeed = esParams.WindSpeed
            };

            var statInfo = DevsManage.GetStatInfo(devId);
            if (statInfo != null)
            {
                model.StatId = statInfo.StatId;
                model.Country = statInfo.Country;
                model.StatCodeUp = statInfo.StatCodeUp;
            }
            else
            {
                model.StatId = 0;
                model.Country = "";
            }
            
            model.DataStatus = model.WindSpeed > 5 ? "S" : "N";

            return _esMinBll.Add(model);
        }

        /// <summary>
        /// 响应任务
        /// </summary>
        /// <param name="devId"></param>
        /// <param name="buffer"></param>
        /// <param name="packetLen"></param>
        private void AddTaskResponse(int devId, byte[] buffer, int packetLen)
        {
            Debug.WriteLine("更新任务信息。");
            var model = new ESMonitor.Model.TaskNotice();
            var taskId = DevsManage.GetCurTaskId(devId);
            if (taskId == 0)
                return;
            
            model.TaskId = taskId;
            model.DevId = devId;
            model.Length = packetLen;
            if (packetLen > 0)
            {
                model.Data = buffer;
                //Array.Copy(ResponseCmd.Data, model.Data, ResponseCmd.DataLen);
            }

            model.UpdateTime = DateTime.Now;
            try
            {
                _tnBll.Add(model);
                _bll.UpdateStatus(model.TaskId, 1); //发送完成
            }
            catch (Exception e)
            {
                Program.Logger.ErrorFormat($"ProcessCommand error, message: {e.Message}");
                Program.Logger.Error(e.StackTrace);
                //DevsManage.SetDevStatus(devId, (int)CommStatus.Free);
            }

            DevsManage.SetCurTaskId(devId, 0);
            Debug.WriteLine($"SetStatusFree:{(int)CommStatus.Free}");
            DevsManage.SetDevStatus(devId, (int)CommStatus.Free);
        }
    }
}
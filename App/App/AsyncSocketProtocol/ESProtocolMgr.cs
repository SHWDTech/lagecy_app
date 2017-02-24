using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
using ESMonApp.AsyncSocketProtocolCore;

namespace ESMonApp.AsyncSocketProtocol
{
    public class EsProtocolMgr
    {
        private static Dictionary<int, EsProtocol> _mList;
        private static Thread _mThread;
        private static int _mThreadCycleTime;
        private static int _mCheckDevCommStateTime;
        private static int _mWaittimeout;

        public EsProtocolMgr()
        {
            //form = mainForm;
            //form = new DevMgrWin();
            _mList = new Dictionary<int, EsProtocol>();
            _mThreadCycleTime = 1000;
            _mCheckDevCommStateTime = Program.AsyncSocketSvr.SocketTimeOutMs;
            _mWaittimeout = Program.AsyncSocketSvr.WaitResponseTimeOutMs;
            _mThread = new Thread(TaskThreadStart);
        }

        public static void Init()
        {
            _mThread.Start();
        }

        //获取任务的线程
        public void TaskThreadStart()
        {
            var devCommStateTimer = 0;
            var dt = new DataTable();
            var sendTask = new Dictionary<int, int>();
            var bll = new ESMonitor.BLL.Tasks();

            while (_mThread.IsAlive)
            {
                var numOfDevs = _mList.Count;
                if (devCommStateTimer < _mCheckDevCommStateTime)
                {
                    devCommStateTimer += _mThreadCycleTime;
                }
                else
                {
                    DevsManage.ManageDevCommState(_mCheckDevCommStateTime);
                    devCommStateTimer = 0;
                }

                if (numOfDevs > 0)
                {
                    dt.Clear();
                    sendTask.Clear();
                    //dt = bll.GetList(1, "Status=0", "ID desc").Tables[0];
                    dt = bll.GetList("Status=0").Tables[0];

                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!_mThread.IsAlive)
                            break;

                        try
                        {
                            var devId = Convert.ToInt32(dt.Rows[i]["DevId"]);
                            //DevsManage.GetLocalCtrlAddr(localCtrlId, ref addr);
                            if (sendTask.ContainsKey(devId))
                            {
                                continue;
                            }
                            else
                            {
                                sendTask.Add(devId, 1);
                            }

                            if (devId > 0)
                            {
                                switch ((CommStatus)DevsManage.GetDevStatus(devId))
                                {
                                    case CommStatus.Busy:

                                        //发送时间超过最大等待时间，删除该发送任务；等下一个周期发送新的任务
                                        if (DevsManage.IsCommTimeout(devId, _mWaittimeout))
                                        {
                                            var taskId = DevsManage.GetCurTaskId(devId);
                                            bll.UpdateStatus(taskId, 2); //发送超时
                                            //DevsManage.SetRecvMsgState(devId, false);
                                            DevsManage.SetCurTaskId(devId, 0);
                                            DevsManage.SetDevStatus(devId, (int)CommStatus.Free);

                                            //重新发送N次
                                            //N次后依然不成功，就提示用户并保留不成功的日志
                                        }

                                        break;

                                    //仅通信准备就绪，空闲时发送数据
                                    case CommStatus.Free:
                                        if (DevsManage.IsRegistered(devId))
                                        {
                                            var taskId = Convert.ToInt64(dt.Rows[i]["TaskId"]);
                                            var length = Convert.ToInt32(dt.Rows[i]["Length"]);
                                            var buffer = (byte[])(dt.Rows[i]["Data"]);
                                            var protocol = Element(devId);//根据id取协议
                                            if (protocol.AsyncSocketUserToken.ConnectSocket != null)
                                            {
                                                lock (protocol)
                                                {
                                                    if (protocol.DoSendResult(buffer, 0, length))//true表示发送成功
                                                    {
                                                        Debug.WriteLine("发送数据成功。");
                                                        DevsManage.SetCurTaskId(devId, taskId);
                                                        Debug.WriteLine($"SetStatusBusy:{(int)CommStatus.Busy}");
                                                        DevsManage.SetDevStatus(devId, (int)CommStatus.Busy);
                                                        DevsManage.UpdateSendTime(devId);
                                                    }
                                                }
                                            }
                                        }
                                        break;

                                    //通信状态断开，不发送
                                    case CommStatus.DisConnect:
                                        break;
                                }

                            }

                        }
                        catch (Exception e)
                        {
                            Program.Logger.ErrorFormat("Task thread send command error, message: {0}", e.Message);
                            Program.Logger.Error(e.StackTrace);

                            Program.OutputLog.LogFormat("Task thread send command error, message: {0}", e.Message);
                        }
                    }
                }

                if (!_mThread.IsAlive)
                    break;

                Thread.Sleep(_mThreadCycleTime); //每秒钟
            }

            dt.Clear();
        }

        public static void Close()
        {
            _mThread.Abort();
            _mThread.Join();
        }

        public static int Count()
        {
            return _mList.Count;
        }

        public static EsProtocol Element(int devId)
        {
            if (_mList.ContainsKey(devId))
            {
                return _mList[devId];
            }
            else
            {
                return null;
            }
        }

        public static bool IsExist(int devId)
        {
            if (_mList.ContainsKey(devId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsSocketConect(int devId, EsProtocol value)
        {
            var flag = false;

            if (IsExist(devId))
            {
                var protocl = Element(devId);

                if (protocl.AsyncSocketUserToken.ConnectSocket.RemoteEndPoint.ToString() == value.AsyncSocketUserToken.ConnectSocket.RemoteEndPoint.ToString())
                {
                    flag = true;
                }
            }

            return flag;
        }

        public static void Add(int devId, EsProtocol value)
        {
            if (IsExist(devId))
            {
                _mList.Remove(devId);
            }

            lock (_mList)
            {
                _mList.Add(devId, value);
            }
        }

        public static void Remove(int devId)
        {
            lock (_mList)
            {
                _mList.Remove(devId);
            }

        }

        public static void Clear()
        {
            _mList.Clear();
        }
    }
}

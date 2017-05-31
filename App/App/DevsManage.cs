using System;
using System.Collections.Generic;
using System.Data;
using ESMonApp.AsyncSocketProtocolCore;
using ESMonApp.Common;

namespace ESMonApp
{
    public class DevsManage
    {
        private static Dictionary<int, DevStatus> _devStatusDic; //设备状态（Key：设备Id，Value是状态  关于检测对象的一个综合体）
        private static Dictionary<uint, int> _devAddrDic; //设备Id 与设备地址关系
        private static Dictionary<int, StatInfo> _devRelatedStatDic; //设备关联的监测站信息

        private DevsManage()
        {

        }

        public static void Init()
        {
            _devStatusDic = new Dictionary<int, DevStatus>();//初始化这两个结构
            _devAddrDic = new Dictionary<uint, int>();//编号和Id的关系
            _devRelatedStatDic = new Dictionary<int, StatInfo>();

            var bll = new ESMonitor.BLL.Devs();//生成一个业务层的设备类

            var dt = bll.GetDevAddrList().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                var model = new DevStatus
                {
                    Id = Convert.ToInt32(dr["DevId"]),
                    IsRegistered = false,
                    RecvTime = new DateTime(),
                    Status = (int) CommStatus.DisConnect,
                    HeartBeatTime = new DateTime(),
                    SendTime = new DateTime()
                };
                _devStatusDic.Add(model.Id, model);

                var addr = (byte[])(dr["NodeId"]);
                var nodeId = Utility.BytesToUint32(addr, 0, false);
                _devAddrDic.Add(nodeId, model.Id);
            }


            dt = bll.GetDevRelatedStat("").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                var statInfo = new StatInfo();
                var devId = Convert.ToInt32(dr["DevId"]);
                statInfo.StatId = Convert.ToInt32(dr["StatId"]);
                statInfo.Country = dr["Country"].ToString();
                statInfo.StatCodeUp = int.Parse(dr["StatCodeUp"].ToString());

                _devRelatedStatDic.Add(devId, statInfo);
            }
        }

        public static bool Exist(int id)
        {
            return _devStatusDic.ContainsKey(id);//是否存在这样的一种设备
        }

        public static void ResetDev(int id)//重置这样的一种设备
        {
            if (_devStatusDic.ContainsKey(id))
            {
                _devStatusDic[id].IsRegistered = false;
                _devStatusDic[id].Status = (int)CommStatus.DisConnect;
                _devStatusDic[id].SendTime = DateTime.Now;
                _devStatusDic[id].TaskId = 0;
            }
        }

        public static bool IsRegistered(int devId)//判断这个设备是否已经注册
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                rst = _devStatusDic[devId].IsRegistered;
            }

            return rst;
        }

        public static bool Register(int devId)//对这个设备进行注册
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                RedisService.GetRedisDatabase().StringSet($"Device-LastConnectTime:{AppConfig.CompanyName}-{devId}", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss fff}");
                _devStatusDic[devId].IsRegistered = true;

                rst = true;
            }

            return rst;
        }

        public static void UpdateDevStats(int devId)
        {
            var stat = new ESMonitor.BLL.Devs().GetDevStat(devId);
            if (stat != null)
            {
                var statInfo = new StatInfo
                {
                    StatId = stat.Id,
                    Country = stat.Country,
                    StatCodeUp = 1
                };

                _devRelatedStatDic[devId] = statInfo;
            }
        }

        //设置状态
        public static void SetDevStatus(int devId, int status)//设置这样一种设备的连接状态
        {
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].Status = status;
            }
        }

        //获取状态
        public static int GetDevStatus(int devId)//获得这样一种设备的连接状态
        {
            var rst = -1;
            if (_devStatusDic.ContainsKey(devId))
            {
                rst = _devStatusDic[devId].Status;
            }

            return rst;
        }

        //设置超时次数
        public static void SetTimeOutCount(int devId, int times)//设置它的超时次数
        {
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].TimeOutCount = times;
            }
        }

        //获取超时次数
        public static int GetTimeOutCount(int devId)//获得超时次数
        {
            var rst = -1;
            if (_devStatusDic.ContainsKey(devId))
            {
                rst = _devStatusDic[devId].TimeOutCount;
            }

            return rst;
        }

        public static bool GetSendTime(int devId, ref DateTime dt) //获得它的发送时间
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                dt = _devStatusDic[devId].SendTime;
                rst = true;
            }

            return rst;
        }

        public static bool UpdateSendTime(int devId)//设置它的发送时间
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].SendTime = DateTime.Now;
                RedisService.GetRedisDatabase().StringSet($"Device-LastSendTime:{AppConfig.CompanyName}-{devId}", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss fff}");
                rst = true;
            }

            return rst;
        }

        public static bool GetRecvTime(int devId, ref DateTime dt)//获取它的发送时间
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                dt = _devStatusDic[devId].RecvTime;
                rst = true;
            }

            return rst;
        }

        public static bool UpdateHeartBeatTime(int devId)//设置心跳时间
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].HeartBeatTime = DateTime.Now;
                RedisService.GetRedisDatabase().StringSet($"Device-LastHeartBeatTime:{AppConfig.CompanyName}-{devId}", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss fff}");
                rst = true;
            }

            return rst;
        }

        public static bool GetHeartBeatTime(int devId, ref DateTime dt)//获取心跳时间
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                dt = _devStatusDic[devId].HeartBeatTime;
                rst = true;
            }

            return rst;
        }

        public static bool UpdateRecvTime(int devId)//更新接受的时间
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].RecvTime = DateTime.Now;
                RedisService.GetRedisDatabase().StringSet($"Device-LastReciveTime:{AppConfig.CompanyName}-{devId}", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss fff}");
                rst = true;
            }

            return rst;
        }

        public static bool UpdateAutoUploadTime(int devId)
        {
            var rst = false;
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].AutoUploadTime = DateTime.Now;
                RedisService.GetRedisDatabase().StringSet($"Device-LastAutoUploadTime:{AppConfig.CompanyName}-{devId}", $"{DateTime.Now:yyyy-MM-dd HH:mm:ss fff}");
                rst = true;
            }

            return rst;
        }

        public static int GetDevId(uint nodeId)//根据地址获得设备的编号
        {
            var rst = 0;
            if (_devAddrDic.ContainsKey(nodeId))
            {
                rst = _devAddrDic[nodeId];
            }
            else
            {
                var dev = new ESMonitor.BLL.Devs().GetDevByNodeId(nodeId);
                if (dev != null)
                {
                    var model = new DevStatus
                    {
                        Id = dev.Id,
                        IsRegistered = false,
                        RecvTime = DateTime.Now,
                        Status = (int) CommStatus.DisConnect,
                        HeartBeatTime = DateTime.Now,
                        SendTime = DateTime.Now
                    };

                    _devStatusDic.Add(model.Id, model);
                    _devAddrDic.Add(nodeId, dev.Id);
                    rst = dev.Id;
                }
            }

            return rst;
        }

        public static long GetCurTaskId(int devId)//获取当前任务的id
        {
            long rst = 0;
            if (_devStatusDic.ContainsKey(devId))
            {
                rst = _devStatusDic[devId].TaskId;
            }

            return rst;
        }

        public static void SetCurTaskId(int devId, long taskId)//设置当前任务id
        {
            if (_devStatusDic.ContainsKey(devId))
            {
                _devStatusDic[devId].TaskId = taskId;
            }
        }

        public static void ManageDevCommState(int timeout)//管理设备的运行状态
        {
            foreach (var item in _devStatusDic.Values)
            {
                if (!item.IsRegistered) continue;
                if ((DateTime.Now - item.HeartBeatTime).TotalMilliseconds >= timeout)
                {
                    ResetDev(item.Id);
                }
            }
        }

        public static bool IsCommTimeout(int devId, int timeout)//判断命令是否超时
        {
            var rst = (DateTime.Now - _devStatusDic[devId].SendTime).TotalMilliseconds >= timeout;

            return rst;
        }

        /// <summary>
        /// 获取监测站信息
        /// </summary>
        /// <param name="devId"></param>
        /// <returns></returns>
        public static StatInfo GetStatInfo(int devId)
        {
            StatInfo model = null;

            if (_devRelatedStatDic.ContainsKey(devId))
            {
                model = _devRelatedStatDic[devId];
            }
            else
            {
                var stat = new ESMonitor.BLL.Devs().GetDevStat(devId);
                if (stat != null)
                {
                    var statInfo = new StatInfo
                    {
                        StatId = stat.Id,
                        Country = stat.Country,
                        StatCodeUp = 1
                    };

                    _devRelatedStatDic.Add(devId, statInfo);
                }
            }

            return model;
        }
    }
}

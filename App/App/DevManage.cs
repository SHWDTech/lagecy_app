using System;
using System.Collections.Generic;
using System.Data;
using ESMonApp.Common;

namespace ESMonApp
{
    public class DevsManage
    {
        private static DevsManage instance = null;
        private static Dictionary<int, DevStatus> devStatusDic = null; //设备状态（Key：设备Id，Value是状态  关于检测对象的一个综合体）
        private static Dictionary<UInt32, int> devAddrDic = null; //设备Id 与设备地址关系
        private static Dictionary<int, StatInfo> devRelatedStatDic = null; //设备关联的监测站信息

        private DevsManage()
        {

        }

        public static void Init()
        {
            devStatusDic = new Dictionary<int, DevStatus>();//初始化这两个结构
            devAddrDic = new Dictionary<UInt32, int>();//编号和Id的关系
            devRelatedStatDic = new Dictionary<int, StatInfo>();

            ESMonitor.BLL.Devs bll = new ESMonitor.BLL.Devs();//生成一个业务层的设备类
            DevStatus model = null;
            StatInfo statInfo = null;

            DataTable dt = bll.GetDevAddrList().Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                model = new DevStatus();//描述设备综合状态的一个model
                model.Id = Convert.ToInt32(dr["DevId"]);//
                model.IsRegistered = false;//是否注册
                model.RecvTime = new DateTime();//时间
                model.Status = (int)ESMonApp.CommStatus.DisConnect;//设置连接状态为非连接
                model.HeartBeatTime = new DateTime();//心跳时间
                model.SendTime = new DateTime();//发送时间
                devStatusDic.Add(model.Id, model);

                byte[] addr = (byte[])(dr["NodeId"]);
                UInt32 nodeId = Utility.BytesToUINT32(addr, 0, false);
                devAddrDic.Add(nodeId, model.Id);
            }


            dt = bll.GetDevRelatedStat("").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                statInfo = new StatInfo();
                int devId = Convert.ToInt32(dr["DevId"]);
                statInfo.StatId = Convert.ToInt32(dr["StatId"]);
                statInfo.Country = dr["Country"].ToString();
                statInfo.StatCodeUp = int.Parse(dr["StatCodeUp"].ToString());

                devRelatedStatDic.Add(devId, statInfo);
            }
        }

        public static bool Exist(int id)
        {
            return devStatusDic.ContainsKey(id);//是否存在这样的一种设备
        }

        public static void ResetDev(int id)//重置这样的一种设备
        {
            if (devStatusDic.ContainsKey(id))
            {
                devStatusDic[id].IsRegistered = false;
                devStatusDic[id].Status = (int)ESMonApp.CommStatus.DisConnect;
                devStatusDic[id].SendTime = DateTime.Now;
                devStatusDic[id].TaskId = 0;
            }
        }

        public static bool IsRegistered(int devId)//判断这个设备是否已经注册
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                rst = devStatusDic[devId].IsRegistered;
            }

            return rst;
        }

        public static bool Register(int devId)//对这个设备进行注册
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].IsRegistered = true;

                rst = true;
            }

            return rst;
        }

        //设置状态
        public static void SetDevStatus(int devId, int status)//设置这样一种设备的连接状态
        {
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].Status = status;
            }
        }

        //获取状态
        public static int GetDevStatus(int devId)//获得这样一种设备的连接状态
        {
            int rst = -1;
            if (devStatusDic.ContainsKey(devId))
            {
                rst = devStatusDic[devId].Status;
            }

            return rst;
        }

        //设置超时次数
        public static void SetTimeOutCount(int devId, int times)//设置它的超时次数
        {
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].TimeOutCount = times;
            }
        }

        //获取超时次数
        public static int GetTimeOutCount(int devId)//获得超时次数
        {
            int rst = -1;
            if (devStatusDic.ContainsKey(devId))
            {
                rst = devStatusDic[devId].TimeOutCount;
            }

            return rst;
        }

        public static bool GetSendTime(int devId, ref DateTime dt) //获得它的发送时间
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                dt = devStatusDic[devId].SendTime;
                rst = true;
            }

            return rst;
        }

        public static bool UpdateSendTime(int devId)//设置它的发送时间
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].SendTime = DateTime.Now;
                rst = true;
            }

            return rst;
        }

        public static bool GetRecvTime(int devId, ref DateTime dt)//获取它的发送时间
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                dt = devStatusDic[devId].RecvTime;
                rst = true;
            }

            return rst;
        }

        public static bool UpdateHeartBeatTime(int devId)//设置心跳时间
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].HeartBeatTime = DateTime.Now;
                rst = true;
            }

            return rst;
        }

        public static bool GetHeartBeatTime(int devId, ref DateTime dt)//获取心跳时间
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                dt = devStatusDic[devId].HeartBeatTime;
                rst = true;
            }

            return rst;
        }

        public static bool UpdateRecvTime(int devId)//更新接受的时间
        {
            bool rst = false;
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].RecvTime = DateTime.Now;
                rst = true;
            }

            return rst;
        }

        public static int GetDevId(UInt32 nodeId)//根据地址获得设备的编号
        {
            int rst = 0;
            if (devAddrDic.ContainsKey(nodeId))
            {
                rst = devAddrDic[nodeId];
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

                    devStatusDic.Add(model.Id, model);
                    devAddrDic.Add(nodeId, dev.Id);
                    rst = dev.Id;
                }
            }

            return rst;
        }

        public static long GetCurTaskId(int devId)//获取当前任务的id
        {
            long rst = 0;
            if (devStatusDic.ContainsKey(devId))
            {
                rst = devStatusDic[devId].TaskId;
            }

            return rst;
        }

        public static void SetCurTaskId(int devId, long taskId)//设置当前任务id
        {
            if (devStatusDic.ContainsKey(devId))
            {
                devStatusDic[devId].TaskId = taskId;
            }

            return;
        }

        public static void ManageDevCommState(int timeout)//管理设备的运行状态
        {
            foreach (var item in devStatusDic.Values)
            {
                if (item.IsRegistered)
                {
                    if ((DateTime.Now - item.HeartBeatTime).TotalMilliseconds >= timeout)
                    {
                        ResetDev(item.Id);
                    }
                }
            }

            return;
        }

        public static bool IsCommTimeout(int devId, int timeout)//判断命令是否超时
        {
            bool rst = false;

            if ((DateTime.Now - devStatusDic[devId].SendTime).TotalMilliseconds >= timeout)
            {
                rst = true;
            }

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

            if (devRelatedStatDic.ContainsKey(devId))
            {
                model = devRelatedStatDic[devId];
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

                    devRelatedStatDic.Add(devId, statInfo);
                }
            }

            return model;
        }
    }
}

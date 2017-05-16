using System;

namespace ESMonApp
{
    [Serializable]
    public class DevStatus
    {
        private int _id;
        private uint _addr;
        private int _status; //状态机 发送还是接收状态
        private bool _isRegistered; //是否注册
        private int _timeoutCount; //超时次数
        private DateTime _sendTime; //发包时间
        private DateTime _recvTime; // 接收响应帧时间
        private DateTime _heartbeatTime; // 接收响应帧时间
        private DateTime _autoUploadTime; //自动上传数据时间
        private long _taskId;

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public uint Addr
        {
            set { _addr = value; }
            get { return _addr; }
        }

        public int Status
        {
            set { _status = value; }
            get { return _status; }
        }

        public bool IsRegistered
        {
            set { _isRegistered = value; }
            get { return _isRegistered; }
        }

        public int TimeOutCount
        {
            set { _timeoutCount = value; }
            get { return _timeoutCount; }
        }

        public DateTime SendTime
        {
            set { _sendTime = value; }
            get { return _sendTime; }
        }

        public DateTime RecvTime
        {
            set { _recvTime = value; }
            get { return _recvTime; }
        }

        public DateTime AutoUploadTime
        {
            set { _autoUploadTime = value; }
            get { return _autoUploadTime; }
        }

        public DateTime HeartBeatTime
        {
            set { _heartbeatTime = value; }
            get { return _heartbeatTime; }
        }

        public long TaskId
        {
            set {_taskId = value;}
            get {return _taskId;}
        }
    }
}

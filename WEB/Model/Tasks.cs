using System;
namespace ESMonitor.Model
{
    /// <summary>
    /// Tasks:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Tasks
    {
        public Tasks()
        { }
        #region Model
        private long _taskid;
        private int _status = 0;
        private DateTime? _sendtime = DateTime.Now;
        private int _commandtype;
        private int _commandbyte;
        private int _devid;
        private byte[] _data = new byte[512];
        private int _length;
        /// <summary>
        /// 
        /// </summary>
        public long TaskId
        {
            set { _taskid = value; }
            get { return _taskid; }
        }
        /// <summary>
        /// 任务的Id
        /// </summary>
        public int Status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? SendTime
        {
            set { _sendtime = value; }
            get { return _sendtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CmdType
        {
            set { _commandtype = value; }
            get { return _commandtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CmdByte
        {
            set { _commandbyte = value; }
            get { return _commandbyte; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DevId
        {
            set { _devid = value; }
            get { return _devid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] Data
        {
            set { _data = value; }
            get { return _data; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Length
        {
            set { _length = value; }
            get { return _length; }
        }
        #endregion Model

    }
}


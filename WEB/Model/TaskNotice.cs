using System;
namespace ESMonitor.Model
{
    /// <summary>
    /// T_TaskNotice:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TaskNotice
    {
        public TaskNotice()
        { }
        #region Model
        private long _taskid;
        private int _devid;
        private byte[] _data;
        private int _length;
        private DateTime? _updatetime;
        /// <summary>
        /// 
        /// </summary>
        public long TaskId
        {
            set { _taskid = value; }
            get { return _taskid; }
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
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        #endregion Model

    }
}


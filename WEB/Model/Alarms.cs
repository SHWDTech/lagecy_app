using System;
namespace ESMonitor.Model
{
    /// <summary>
    /// Alarms:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Alarms
    {
        public Alarms()
        { }
        #region Model
        private int _id;
        private int? _statid;
        private int? _devid;
        private int? _dusttype;
        private decimal? _faultval;
        private DateTime? _updatetime;
        private string _country;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StatId
        {
            set { _statid = value; }
            get { return _statid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DevId
        {
            set { _devid = value; }
            get { return _devid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? DustType
        {
            set { _dusttype = value; }
            get { return _dusttype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? FaultVal
        {
            set { _faultval = value; }
            get { return _faultval; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Country
        {
            set { _country = value; }
            get { return _country; }
        }
        #endregion Model

    }
}


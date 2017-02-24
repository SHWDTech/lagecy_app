
using System;
namespace ESMonitor.Model
{
    /// <summary>
    /// ESDay:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ESDay
    {
        public ESDay()
        { }
        #region Model
        private long _id;
        private int _statid;
        private double _pm25;
        private double _pm100;
        private double _tp;
        private double _db;
        private DateTime _updatetime;
        private string _datastatus;
        private string _country;
        private int _devid;
        private int _validdatanum;
        /// <summary>
        /// 
        /// </summary>
        public long Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int StatId
        {
            set { _statid = value; }
            get { return _statid; }
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
        public double TP
        {
            set { _tp = value; }
            get { return _tp; }
        }

        public double Pm25
        {
            set { _pm25 = value; }
            get { return _pm25; }
        }

        public double Pm100
        {
            set { _pm100 = value; }
            get { return _pm100; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double DB
        {
            set { _db = value; }
            get { return _db; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataStatus
        {
            set { _datastatus = value; }
            get { return _datastatus; }
        }

        public string Country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ValidDataNum
        {
            set { _validdatanum = value; }
            get { return _validdatanum; }
        }
        #endregion Model

    }
}


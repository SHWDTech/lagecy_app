
using System;
namespace ESMonitor.Model
{
    /// <summary>
    /// ESMin:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ESMin
    {
        public ESMin()
        { }
        #region Model
        private long _id;
        private int _statid;
        private int _statcodeup;
        private double _pm25;
        private double _pm100;
        private double _tp;
        private double _db;
        private DateTime _updatetime;
        private double _windspeed;
        private double _rain;
        private double _winddirection;
        private double _temperature;
        private double _humidity;
        private double _airpressure;
        private string _datastatus;
        private string _country;
        private int _devid;
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

        public int StatCodeUp
        {
            set { _statcodeup = value; }
            get { return _statcodeup; }
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

        /// <summary>
        /// 
        /// </summary>
        public double Pm25
        {
            set { _pm25 = value; }
            get { return _pm25; }
        }

        /// <summary>
        /// 
        /// </summary>
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
        public double WindSpeed
        {
            set { _windspeed = value; }
            get { return _windspeed; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double Rain
        {
            set { _rain = value; }
            get { return _rain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double WindDirection
        {
            set { _winddirection = value; }
            get { return _winddirection; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double Temperature
        {
            set { _temperature = value; }
            get { return _temperature; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double Humidity
        {
            set { _humidity = value; }
            get { return _humidity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double Airpressure
        {
            set { _airpressure = value; }
            get { return _airpressure; }
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
        #endregion Model

    }
}


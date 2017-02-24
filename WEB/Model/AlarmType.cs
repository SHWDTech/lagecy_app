using System;

namespace ESMonitor.Model
{
    /// <summary>
    /// Stats:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class AlarmType
    {
        #region Model
        private int _id;
        private string _name;
        private double _dustRange;
        private double _dbRange;

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public double DustRange
        {
            set { _dustRange = value; }
            get { return _dustRange; }
        }

        public double DbRange
        {
            set { _dbRange = value; }
            get { return _dbRange; }
        }
        #endregion Model
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ESMonitor.Model
{
    /// <summary>
    /// Alarms:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Photos
    {
        private int _id;
        private int _devId;
        private DateTime _addTime;
        private string _fileName;

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public int DevId
        {
            set { _devId = value; }
            get { return _devId; }
        }

        public DateTime AddTime
        {
            set { _addTime = value; }
            get { return _addTime; }
        }

        public string FileName
        {
            set { _fileName = value; }
            get { return _fileName; }
        }
    }
}

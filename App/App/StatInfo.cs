using System;

namespace ESMonApp
{
    [Serializable]
    public class StatInfo
    {
        private int _statid;
        private string _country;
        private int _statcodeup;

        /// <summary>
        /// 监测站
        /// </summary>
        public int StatId 
        {
            set { _statid = value; }
            get { return _statid; }
        }

        //市区
        public string Country
        {
            set { _country = value; }
            get { return _country; }
        }

        /// <summary>
        /// 市局分配的ID号
        /// </summary>
        public int StatCodeUp
        {
            set { _statcodeup = value; }
            get { return _statcodeup; }
        }
        
    }
}

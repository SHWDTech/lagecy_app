using System;

namespace ESMonitor.Model
{
    /// <summary>
    /// Stats:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class Camera
    {
        private int id;
        private int devId;
        private string dnsAddr;
        private string userName;
        private string passWord;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public int DevId
        {
            set { devId = value; }
            get { return devId; }
        }

        public string DnsAddr
        {
            set { dnsAddr = value; }
            get { return dnsAddr; }
        }

        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }

        public string PassWord
        {
            set { passWord = value; }
            get { return passWord; }
        }
    }
}

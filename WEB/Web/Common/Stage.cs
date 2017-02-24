using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;
using System.Reflection;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Web.Common
{
    public class StageItem
    {
        private string _name;
        private string _id;

        public StageItem(string Id, string Name)
        {
            _id = Id;
            _name = Name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }

    public class Stage
    {
        private static ArrayList arr = null;

        public Stage()
        {

        }

        public static void Init()
        {
            arr = new ArrayList();
            arr.Add(new StageItem("0", "基础"));
            arr.Add(new StageItem("1", "结构"));
            arr.Add(new StageItem("2", "完工"));
        }

        public static string GetStage(string stage)
        {
            string ret = string.Empty;
            StageItem item = null;

            for (int i = 0; i < arr.Count; i++)
            {
                item = (StageItem)arr[i];
                if (item.Id == stage)
                {
                    ret = item.Name;
                    break;
                }
            }


            return ret;
        }
    }
}

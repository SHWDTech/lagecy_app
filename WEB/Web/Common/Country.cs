using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;

namespace Web.Common
{
    public class CountryItem
    {
        private string _name;
        private string _id;
        
        public CountryItem(string Id, string Name)
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
    public class Country
    {
        private static ArrayList arr = null;

        public Country()
        {
            
        }
        public static void Init()
        {
            arr = new ArrayList();
            arr.Add(new CountryItem("1", "黄浦区"));
            arr.Add(new CountryItem("2", "徐汇区"));
            arr.Add(new CountryItem("3", "长宁区"));
            arr.Add(new CountryItem("4", "静安区"));
            arr.Add(new CountryItem("5", "普陀区"));
            arr.Add(new CountryItem("6", "闸北区"));
            arr.Add(new CountryItem("7", "虹口区"));
            arr.Add(new CountryItem("8", "杨浦区"));
            arr.Add(new CountryItem("9", "宝山区"));
            arr.Add(new CountryItem("10", "闵行区"));
            arr.Add(new CountryItem("11", "嘉定区"));
            arr.Add(new CountryItem("12", "浦东新区"));
            arr.Add(new CountryItem("13", "松江区"));
            arr.Add(new CountryItem("14", "金山区"));
            arr.Add(new CountryItem("15", "青浦区"));
            arr.Add(new CountryItem("16", "奉贤区"));
            arr.Add(new CountryItem("17", "崇明县"));
            arr.Add(new CountryItem("18", "其他"));
        }

        public static ArrayList GetData()
        {
            return arr;
        }
        
        public static string GetName(string Id)
        {
            string ret = string.Empty;
            CountryItem item  = null;
            
            for (int i = 0; i < arr.Count; i++)
            {
                item = (CountryItem)arr[i];
                if (item.Id == Id)
                {
                    ret = item.Name;
                }
            }
            
            return ret;
        }
    }
}

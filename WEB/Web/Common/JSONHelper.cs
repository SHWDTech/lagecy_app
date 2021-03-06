﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Collections;
using System.Text;

namespace Web
{
    public class JSONHelper
    {
        //对应JSON的singleInfo成员
        public string singleInfo = string.Empty;

        protected string _error = string.Empty;
        protected bool _success = true;
        protected long _totalCount = 0;
        protected System.Collections.ArrayList arrData = new ArrayList();
        protected System.Collections.ArrayList arrDataItem = new ArrayList();

        public JSONHelper()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        //对应于JSON的success成员
        public bool success
        {
            get
            {
                return _success;
            }
            set
            {
                //如设置为true则清空error
                if (success) _error = string.Empty;
                _success = value;
            }
        }

        //对应于JSON的error成员
        public string error
        {
            get
            {
                return _error;
            }
            set
            {
                //如设置error，则自动设置success为false
                if (value != "") _success = false;
                _error = value;
            }
        }

        public long totalCount
        {
            get { return _totalCount; }
            set { _totalCount = value; }
        }


        //重置，每次新生成一个json对象时必须执行该方法
        public void Reset()
        {
            _success = true;
            _error = string.Empty;
            singleInfo = string.Empty;
            arrData.Clear();
            arrDataItem.Clear();
        }



        public void AddItem(string name, string value)
        {
            arrData.Add("\"" + name + "\":" + "\"" + value + "\"");
        }



        public void ItemOk()
        {
            arrData.Add("<BR>");
            //返回总记录条数
            totalCount++;
        }

        //序列化JSON对象，得到返回的JSON代码
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"totalCount\":\"" + _totalCount.ToString() + "\",");
            sb.Append("\"success\":" + _success.ToString().ToLower() + ",");
            sb.Append("\"error\":\"" + _error.Replace("\"", "//\"") + "\",");
            sb.Append("\"data\":[");

            int index = 0;
            sb.Append("{");
            if (arrData.Count <= 0)
            {
                sb.Append("}");
            }
            else
            {
                foreach (string val in arrData)
                {
                    index++;

                    if (val != "<BR>")
                    {
                        sb.Append(val + ",");
                    }
                    else
                    {
                        sb = sb.Replace(",", "", sb.Length - 1, 1);
                        sb.Append("},");
                        if (index < arrData.Count)
                        {
                            sb.Append("{");
                        }
                    }

                }
                
                sb = sb.Replace(",", "", sb.Length - 1, 1);
            }
            sb.Append("]");
            sb.Append("}");
            return sb.ToString();
        }

        public string ToSingleString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            sb.Append("success:" + _success.ToString().ToLower() + ",");

            sb.Append("data:");

            int index = 0;
            sb.Append("{");
            if (arrData.Count <= 0)
            {
                sb.Append("}");
            }
            else
            {
                foreach (string val in arrData)
                {
                    index++;

                    if (val != "<BR>")
                    {
                        sb.Append(val + ",");
                    }
                    else
                    {
                        sb = sb.Replace(",", "", sb.Length - 1, 1);
                        sb.Append("},");
                        if (index < arrData.Count)
                        {
                            sb.Append("{");
                        }
                    }

                }
                sb = sb.Replace(",", "", sb.Length - 1, 1);
                sb.Append("");
            }

            sb.Append("}");
            return sb.ToString();
        }
    }
}

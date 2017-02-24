using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Text;

namespace Web
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    public class LogicGroupService : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            StringBuilder output = new StringBuilder();
            string action = context.Request.Params["action"];
            if (action == "loadSubItems")
            {
                int nodeId = int.Parse(context.Request.Params["id"]);
                output.Append("[");
                GetLEDCtrls(nodeId, ref output);
                GetLogicGroups(nodeId, ref output);

                if (output.Length > 1)
                {
                    output = output.Remove(output.Length - 1, 1);
                }
                
                output.Append("]");
            }
            else
            {
                output.Append("err");
            }

            context.Response.ClearContent();
            context.Response.ContentType = "text/plain";
            context.Response.Cache.SetCacheability(HttpCacheability.NoCache); //无缓存
            context.Response.Write(output.ToString());

            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private void GetLEDCtrls(int nodeId, ref StringBuilder sb)
        {
            LEDMonitor.BLL.NodeLocalCtrls bll = new LEDMonitor.BLL.NodeLocalCtrls();
            DataTable ds = bll.GetLEDCtrls(nodeId).Tables[0];
            
            foreach (DataRow dr in ds.Rows)
            {
                sb.Append("{");
                sb.AppendFormat("id:\"C{0}\", pId:\"N{1}\", name:\"{2}\"", dr["Id"], nodeId, dr["Name"]);
                sb.Append("},");
            }
        }

        private void GetLogicGroups(int nodeId, ref StringBuilder sb)
        {
            LEDMonitor.BLL.Nodes bll = new LEDMonitor.BLL.Nodes();
            DataTable ds = bll.GetLEDCtrls(nodeId).Tables[0];

            foreach (DataRow dr in ds.Rows)
            {
                sb.Append("{");
                sb.AppendFormat("id:\"G{0}\", pId:\"N{1}\", name:\"{2}\"", dr["Id"], nodeId, dr["Name"]);
                sb.Append("},");
            }
        }
    }


}

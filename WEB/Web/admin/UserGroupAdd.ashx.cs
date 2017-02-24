using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Text;

namespace Web
{
    public class UserGroupAdd1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
            string action = context.Request.Params["action"].ToString(); 
            if (action == "getGroup")
            {
                GetGroups(context.Response);
            }
            else if (action == "getGroupAuth")
            {
                int groupId = Convert.ToInt32(context.Request.Params["groupId"]);
                GetUserGroupAuths(context.Response, groupId);
            }
            
        }

        /// <summary>
        /// 获取用户组
        /// </summary>
        /// <param name="Response"></param>
        private void GetGroups(HttpResponse Response)
        {
            ESMonitor.BLL.UserGroup bll = new ESMonitor.BLL.UserGroup();
            DataTable dt = bll.GetAllList().Tables[0];
            StringBuilder sb = new StringBuilder();
            int i = 0;
            
            sb.Append("{items:[");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("{");
                sb.AppendFormat("Id:{0},Name:\"{1}\"", dr["Id"], dr["Name"]);
                sb.Append("},");
                i++;
            }

            if (i > 0)
            {
                sb = sb.Remove(sb.Length - 1, 1);
            }

            sb.AppendFormat("],count:{0}", i);
            sb.Append("}");
            
            Response.Write(sb.ToString());
            
            return;
        }
        
        /// <summary>
        /// 获取用户组权限
        /// </summary>
        private void GetUserGroupAuths(HttpResponse Response, int userGroupId)
        {
            ESMonitor.BLL.GroupModules bll = new ESMonitor.BLL.GroupModules();
            
            DataTable dt = bll.GetModules(userGroupId).Tables[0];

            StringBuilder sb = new StringBuilder();
            int i = 0;

            sb.Append("{items:[");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("{");
                sb.AppendFormat("Id:{0}", dr["ModuleId"]);
                sb.Append("},");
                i++;
            }

            if (i > 0)
            {
                sb = sb.Remove(sb.Length - 1, 1);
            }

            sb.AppendFormat("],count:{0}", i);
            sb.Append("}");

            Response.Write(sb.ToString());
            return;
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace Web
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UserAuthService : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            int res = -1;
            if (context.Request.Form["action"] != null)
            {
                string action = context.Request.Form["action"];
                if (action == "AddAuths")
                {
                   res =  AddAuths(context);
                }
            }

            switch (res)
            {
                case 1:
                    context.Response.Write("failur 1");
                    break;
                case 0:
                    context.Response.Write("ok");
                    break;
                default:
                    context.Response.Write("params err");
                    break;
            }

            return;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private int AddAuths(HttpContext context)
        {
            string areas = string.Empty;
            string logicGroups = string.Empty;
            string ledCtrls = string.Empty;
            string cmds = string.Empty;
            string users = string.Empty;

            if ((context.Request.Form["area"] == null)
                || (context.Request.Form["logicGroup"] == null)
                || (context.Request.Form["ledCtrl"] == null)
                || (context.Request.Form["cmd"] == null)
                || (context.Request.Form["user"] == null))
            {
                return -1;
            }

            areas = context.Request.Form["area"];
            logicGroups = context.Request.Form["logicGroup"];
            ledCtrls = context.Request.Form["ledCtrl"];
            cmds = context.Request.Form["cmd"];
            users = context.Request.Form["user"];

            string[] user = users.Split(',');

            string[] area = areas.Split(',');
            string[] logicGroup = logicGroups.Split(',');
            string[] ledCtrl = ledCtrls.Split(',');
            string[] cmd = cmds.Split(',');

            List<int> userList = new List<int>();
            List<string> authList = new List<string>();
            foreach (string u in user)
            {
                userList.Add(int.Parse(u));
            }

            foreach (string a in area)
            {
                authList.Add(a + ",2");
            }

            foreach (string g in logicGroup)
            {
                authList.Add(g + ",3");
            }

            foreach (string l in ledCtrl)
            {
                authList.Add(l + ",4");
            }

            foreach (string c in cmd)
            {
                authList.Add(c + ",5");
            }
            
            ESMonitor.BLL.Users bll = new ESMonitor.BLL.Users();

            if (bll.AddAuths(userList, authList))
            {
                return 0;
            }

            return 1;
        }

        private void AddAreas(List<int> users, string areas)
        {
            string[] area = areas.Split(',');
        }

        private void AddLogicGroups(List<int> users, string logicGroups)
        {
            string[] logicGroup = logicGroups.Split(',');
        }

        private void AddLEDCtrls(List<int> users, string ledCtrls)
        {
            string[] ledCtrl = ledCtrls.Split(',');
        }

        private void AddCmds(List<int> users, string cmds)
        {
            string[] cmd = cmds.Split(',');
        }
    }
}

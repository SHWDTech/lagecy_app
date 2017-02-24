using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using log4net;
using Web.Common;

namespace Web
{
    public class Global : System.Web.HttpApplication
    {
        public ESMonApp.VedioMgr VMgr = null;

        protected void Application_Start(object sender, EventArgs e)
        {
            //NodesHelper.Instance().Init();
            //LocalCtrlsHelper.Instance().Init();
            
            Country.Init();
            Stage.Init();

            //VMgr = new ESMonApp.VedioMgr();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (VMgr != null)
            {
                VMgr.Dispose();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

namespace Web.action
{
    public class ExportChart : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

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

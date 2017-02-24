using System;
using System.Web.UI;

namespace Web
{
    public partial class Alarm : Page
    {
        public string IframeId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitIFrame();
            }
        }
        
        private void InitIFrame()
        {
            IframeId = Request.Params["id"] ?? "1";
        }
    }
}

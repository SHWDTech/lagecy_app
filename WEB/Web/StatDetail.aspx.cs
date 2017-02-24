using System;
using System.Configuration;
using System.Web.UI;

namespace Web
{
    public partial class StatDetail : Page
    {
        private string _sidStr;
        private int _sid;
        public float OffSetCpm, OffSetPlusCpm, OffSetNoise, OffSetPlusNoise;
        protected void Page_Load(object sender, EventArgs e)
        {
            _sidStr = Request.QueryString["sid"];
            if (int.TryParse(_sidStr, out _sid))
            {
                OffSetCpm = float.Parse(ConfigurationManager.AppSettings["OffSetCpm"]);
                OffSetPlusCpm = float.Parse(ConfigurationManager.AppSettings["OffSetPlusCpm"]);
                OffSetNoise = float.Parse(ConfigurationManager.AppSettings["OffSetNoise"]);
                OffSetPlusNoise = float.Parse(ConfigurationManager.AppSettings["OffSetPlusNoise"]);
            }
        }


        
    }
}

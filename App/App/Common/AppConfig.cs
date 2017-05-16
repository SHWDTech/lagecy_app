using System.Configuration;

namespace ESMonApp.Common
{
    public class AppConfig
    {
        public static string CompanyName { get; } = ConfigurationManager.AppSettings["company"];
    }
}

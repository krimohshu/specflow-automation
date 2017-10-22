using System.Configuration;

namespace GlasswallAutomation.Common
{
    public class Configuration
    {
        public string UrlValue = ConfigurationManager.AppSettings["url"];
        public static string ChromeDriverPath = ConfigurationManager.AppSettings["ChromeDriver"]; 
    }
}

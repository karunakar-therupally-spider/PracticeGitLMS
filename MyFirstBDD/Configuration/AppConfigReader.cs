using LMSUI.Settings;
using MyFirstBDD.Configuration;
using System;
using System.Configuration;

namespace LMSUI.Configuration
{
    public class AppConfigReader : IConfig

    {

        public BrowserType? GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetWebsite()
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);

        }
    }
}

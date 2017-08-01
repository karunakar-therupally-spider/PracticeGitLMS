using LMSUI.Configuration;
using MyFirstBDD.Configuration;

namespace LMSUI.Settings
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        string GetWebsite();
    }
}
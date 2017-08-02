using LMSUI.Settings;
using System;
using System.Collections.Generic;


namespace LMSUI.ComponentHelper
{
    class NavigationHelper
    {
        internal static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }
    }
}

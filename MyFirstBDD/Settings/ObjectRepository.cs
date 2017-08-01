using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using LMSUI.Interfaces;
//using LMSUI.PageObject;

namespace LMSUI.Settings
{
    class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        //public static HomePage hPage;
        //public static LoginPage lPage;
     
    }
}




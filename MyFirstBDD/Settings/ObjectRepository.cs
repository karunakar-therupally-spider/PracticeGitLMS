﻿using System;
using System.Collections.Generic;

using OpenQA.Selenium;
//using LMSUI.Interfaces;
//using LMSUI.PageObject;

namespace LMSUI.Settings
{
    abstract class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }
        // test
        //public static HomePage hPage;
        //public static LoginPage lPage;
     
    }
}




using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using LMSUI.Settings;
using LMSUI.Configuration;
using MyFirstBDD.Configuration;
using System.Runtime.Serialization;

namespace LMSUI.BaseClasses
{

    [TestClass]
    public class BaseClass
    {

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddExtension(@"C:\Users\rahul.rathore\Desktop\Cucumber\extension_3_0_12.crx");
            //Logger.Info(" Using Chrome Options ");
            return option;
        }

        private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        [AssemblyInitialize]
        //[BeforeFeature()]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                //case BrowserType.Firefox:
                //    ObjectRepository.Driver = GetFirefoxDriver();
                //    Logger.Info(" Using Firefox Driver  ");

                //    break;

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    //Logger.Info(" Using Chrome Driver  ");
                    break;

                //case BrowserType.IExplorer:
                //    ObjectRepository.Driver = GetIEDriver();
                //    Logger.Info(" Using Internet Explorer Driver  ");
                //    break;

                //case BrowserType.PhantomJs:
                //    ObjectRepository.Driver = GetPhantomJsDriver();
                //    Logger.Info(" Using PhantomJs Driver  ");
                //    break;

                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
            //ObjectRepository.Driver.Manage()
            //    .Timeouts()
            //    .SetPageLoadTimeout(TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut()));
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            ////BrowserHelper.BrowserMaximize();
        }


        [AssemblyCleanup]
        //[AfterScenario()]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
            //Logger.Info(" Stopping the Driver  ");
        }
    }

    [Serializable]
    internal class NoSutiableDriverFound : Exception
    {
        public NoSutiableDriverFound()
        {
        }

        public NoSutiableDriverFound(string message) : base(message)
        {
        }

        public NoSutiableDriverFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSutiableDriverFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

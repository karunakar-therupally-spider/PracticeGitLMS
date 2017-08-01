using LMSUI.Settings;
using LMSUI.ComponentHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace LMSUI.StepDefinition
{
    [Binding]
    public sealed class LoginFeature
    {
        //private LoginPage lPage;
        //private HomePage hPage;
        
      

        [Given(@"User is navigated to LMS page")]
        public void GivenUserIsNavigatedToLMSPage()
        {
            Console.WriteLine("website url: "+ObjectRepository.Config.GetWebsite());
          //  NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

     

        [When(@"I click on Login link")]
        public void WhenIClickOnLoginLink()
        {
            
            Console.WriteLine("User clicked on login link and entered login credentials..");
        }

     
        [Then(@"loggedin user page is displayed")]
        public void ThenLoggedinUserPageIsDisplayed()
        {
            Console.WriteLine("User is on LMS home page");
        }

    

    }
}

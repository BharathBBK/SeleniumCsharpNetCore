using NUnit.Framework;
using SeleniumCsharpNetCore.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCsharpNetCore.Steps
{
    [Binding]
   public class Loginsteps
    {


        private DriverHelper _driverHelper;
        HomePage Hpage ;
        Loginpage Lpage;
        public Loginsteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;

            Hpage = new HomePage(_driverHelper.Driver);
            Lpage = new Loginpage(_driverHelper.Driver);
        }


        [Given(@"user navigate to application")]
        public void GivenUserNavigateToApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"i click the login link")]
        public void GivenIClickTheLoginLink()
        {
            Hpage.clicklogin();
        }

        [Given(@"user entered username and password")]
        public void GivenUserEnteredUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            Lpage.Enterusername((string)data.Username,(string)data.Password);
            

        }

        [Given(@"user click on login")]
        public void GivenUserClickOnLogin()
        {
            Lpage.Submitbtn();
        }

        [Then(@"user should be able to login into the application")]
        public void ThenUserShouldBeAbleToLoginIntoTheApplication()
        {
            Assert.That(Hpage.LogOff, Is.True, "Log Off button is displayed");
        }


    }
}

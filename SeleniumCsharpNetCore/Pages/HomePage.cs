using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore.Pages
{
    class HomePage
    {
        private IWebDriver _Driver;
        public HomePage(IWebDriver driver)
        {
            _Driver = driver;
        }

        IWebElement lnkLogin => _Driver.FindElement(By.LinkText("Login"));

        IWebElement lnklogoff => _Driver.FindElement(By.LinkText("Log off"));

        public void clicklogin()
        { 
            lnkLogin.Click();
        }

        public bool LogOff => lnklogoff.Displayed;

        public IWebDriver Driver { get; }
    }
}

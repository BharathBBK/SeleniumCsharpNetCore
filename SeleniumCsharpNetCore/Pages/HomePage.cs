using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));

        IWebElement lnklogoff => Driver.FindElement(By.LinkText("Log off"));

        public void clicklogin()
        {

            lnkLogin.Click();
        }

        public bool LogOff => lnklogoff.Displayed;

    }
}

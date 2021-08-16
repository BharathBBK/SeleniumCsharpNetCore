using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore.Pages
{
    class Loginpage : DriverHelper
    {

        IWebElement UserName => Driver.FindElement(By.Id("UserName"));
        IWebElement Password => Driver.FindElement(By.Id("Password"));

        IWebElement loginbutton => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void Enterusername(string username, string password) {

            UserName.SendKeys(username);
            Password.SendKeys(password);
        }

        

        public void Submitbtn() {

            loginbutton.Click();
        }

    }
}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore.Pages
{
    class Loginpage
    {
        private IWebDriver _Driver;
        public Loginpage(IWebDriver driver)
        {
            _Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement UserName => _Driver.FindElement(By.Id("UserName"));
        IWebElement Password => _Driver.FindElement(By.Id("Password"));

        IWebElement loginbutton => _Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void Enterusername(string username, string password) {

            UserName.SendKeys(username);
            Password.SendKeys(password);
        }

        

        public void Submitbtn() {

            loginbutton.Click();
        }

    }
}

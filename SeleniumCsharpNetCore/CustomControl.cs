using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumCsharpNetCore
{
    public class CustomControl : DriverHelper
    {

        public static void comboboxctrl(String ctrlname, String valuename)
        {
            IWebElement Combocontrol = Driver.FindElement(By.XPath($"//input[@id='{ctrlname}-awed']"));

            Combocontrol.Clear();
            Combocontrol.SendKeys(valuename);
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath($"//div[@id='{ctrlname}-dropmenu']//li[text()='{valuename}']")).Click();

            Console.WriteLine("ComboCtrl Executed Successfully");

        }

        public static void Entertext(IWebElement webelement, string value) => webelement.SendKeys(value);

        public static void Clickmethod(IWebElement webelement) => webelement.Click();

        public static void selectByvalue(IWebElement webElement, string value) {

            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
            
        }

        public static void selectByText(IWebElement webElement, string text)
        {

            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);

        }

        public static void selectByIndex(IWebElement webElement, int index)
        {

            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByIndex(index);

        }


    }
}

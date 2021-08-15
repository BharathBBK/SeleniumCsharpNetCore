using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumCsharpNetCore
{
   public  class CustomControl : DriverHelper
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

    }
}

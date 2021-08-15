using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumCsharpNetCore
{
    public class Tests : DriverHelper
    {

    
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");

            Driver = new ChromeDriver();
            
        }

        [Test]
        public void Test1()
        {
            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            var veggie = "Tomato";
            Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_Meal']")).SendKeys(veggie);
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_Meal-dropmenu']//ul/li")).Click();

            Driver.FindElement(By.XPath("//div[@class='o-chk ']/following-sibling::div[text()='Celery']")).Click();

            //string comboctrlname = "ContentPlaceHolder1_AllMealsCombo";

            //CustomControl ctrl = new CustomControl();
            CustomControl.comboboxctrl("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Console.WriteLine("Execution");

            Driver.Quit();
            Assert.Pass();
        }
    }
}
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCsharpNetCore.Pages;
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
        
            CustomControl.Entertext(Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_Meal']")), "Tomato");
            Thread.Sleep(2000);
            CustomControl.Clickmethod(Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_Meal-dropmenu']//ul/li")));
            CustomControl.Clickmethod(Driver.FindElement(By.XPath("//div[@class='o-chk ']/following-sibling::div[text()='Celery']")));
            CustomControl.comboboxctrl("ContentPlaceHolder1_AllMealsCombo", "Almond");

            //Driver.FindElement(By.XPath("//div[@class='o-chk ']/following-sibling::div[text()='Celery']")).Click();

            //string comboctrlname = "ContentPlaceHolder1_AllMealsCombo";

            //CustomControl ctrl = new CustomControl();

            CustomControl.selectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Lettuce");


            Console.WriteLine("Execution");

            //Driver.Quit();
            Assert.Pass();
        }

        [Test]
        public void logintest() {

            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage Hpage = new HomePage();
            Loginpage Lpage = new Loginpage();

            Hpage.clicklogin();
            Lpage.Enterusername("admin", "password");
            Lpage.Submitbtn();
            Assert.That(Hpage.LogOff, Is.True, "Log Off button is displayed");
        
        }
    }
}
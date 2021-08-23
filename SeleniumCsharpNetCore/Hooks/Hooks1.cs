using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumCsharpNetCore.Hooks
{
    [Binding]
    public sealed class Hooks1 
    {

        private DriverHelper _driverhelper;
        public Hooks1(DriverHelper driverhelper) => _driverhelper = driverhelper;

        [BeforeScenario]
        public void BeforeScenario()
        {

            _driverhelper.Driver = new ChromeDriver();
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            _driverhelper.Driver.Quit();
        }
    } 
}

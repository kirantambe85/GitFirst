using MoorepayDemo.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MoorepayDemo
{
    public class Start : Driver
    {
        Objects ob = null;
        //IWebDriver driver = null;
        //WebDriverWait iWait = null;

        [BeforeScenario]
        public void setUp()
        {
            StepDefinationInitialise();

            // Initializing all the Page Objects
            ob = new Objects(browser.driver, browser.iWait);
            ob.ObjectInitialisation();

            // Navigating to URL
            //string appURL = ConfigurationManager.AppSettings["ApplicationURL"];
            //string username = ConfigurationManager.AppSettings["ApplicationUsername"];
            //string password = ConfigurationManager.AppSettings["ApplicationPassword"];

            //driver.Navigate().GoToUrl(appURL);

            //Objects.PoLogin.SiteLogin(username, password);
        }

        [AfterScenario]
        public void TearDown()
        {
            //Thread.Sleep(4000);
            if (browser.driver != null)
                browser.driver.Quit();
        }
    }
}
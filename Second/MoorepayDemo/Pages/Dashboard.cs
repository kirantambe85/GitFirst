using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoorepayDemo.Pages
{
    public class Dashboard
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public Dashboard(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        By linkDashboardPanel = By.CssSelector("div#pnlButtons>a");
        By btnSearch = By.Id("SEARCH");
        By txtCompanyName = By.Id("Search_FieldSelect0_txtValue1");
        By mnuMenu = By.Id("shortMenu");
        By tabCompanies = By.CssSelector("div#menuDiv > a#SEARCH");

        public void DashboardVerify()
        {
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleIs("ad DEPOT"));
            driver.SwitchTo().Frame(0);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(linkDashboardPanel));
            Console.WriteLine("Dashboard Panel Buttons Found");
        }

        public void navigateToCompany()
        {
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("RightPane");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(btnSearch));
            driver.FindElement(btnSearch).Click();            
        }

        public void ClickCompanyFromMenu()
        {
            driver.SwitchTo().DefaultContent();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(mnuMenu));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(mnuMenu));
            driver.FindElement(mnuMenu).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(tabCompanies));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(tabCompanies));

            driver.FindElement(tabCompanies).Click();
        }

        public void verifySearchPageElements()
        {
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            driver.SwitchTo().Frame("RightPane");
            driver.SwitchTo().Frame("ifrSelection");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(txtCompanyName));
            bool txtCN = driver.FindElement(txtCompanyName).Displayed;
            Assert.AreEqual(txtCN, true);
        }
    }
}


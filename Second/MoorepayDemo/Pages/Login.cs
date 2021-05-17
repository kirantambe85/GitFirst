using MoorepayDemo.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoorepayDemo.Pages
{
    public class Login
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public Login(IWebDriver driver, WebDriverWait wait)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver is null");
            }

            this.driver = driver;
            this.wait = wait;
        }

        By txtUserName = By.Id("username");
        By txtPassword = By.Id("password");
        By btnLogin = By.Id("login");
        By lblPayrollDashboard = By.XPath("//div[@id = 'main-screen']//h1[contains(text(),'Payroll')]");
        By lblPasswordRequired = By.XPath("//li[contains(text(),'Password is required')]");
        By lblUsernameRequired = By.XPath("//li[contains(text(),'Username is required')]");

        ReadData objReadData = new ReadData();

        public void GotoUrl()
        {
            //StepDefinationInitialise();

            //string strURL = objReadData.GetData("url", "Data.xml");

            string strURL = ConfigurationManager.AppSettings["ApplicationURL"];
            driver.Navigate().GoToUrl(strURL);
        }

        public void EnterDetails()
        {
            //string strUsername = objReadData.GetData("username", "Data.xml");
            //string strPassword = objReadData.GetData("password", "Data.xml");

            string strUsername = ConfigurationManager.AppSettings["ApplicationUsername"];
            string strPassword = ConfigurationManager.AppSettings["ApplicationPassword"];

            driver.FindElement(txtUserName).SendKeys(strUsername);
            driver.FindElement(txtPassword).SendKeys(strPassword);
        }

        public void LoginClick()
        {
            driver.FindElement(btnLogin).Click();
        }

        public void VerifyPortalPage()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(lblPayrollDashboard));
            Assert.AreEqual("Payroll", driver.FindElement(lblPayrollDashboard).Text);
        }

        public void EnterUsername(string strUsername)
        {
            driver.FindElement(txtUserName).SendKeys(strUsername);
        }

        public void EnterPassword(string strPassword)
        {
            driver.FindElement(txtPassword).SendKeys(strPassword);
        }

        public void VerifyMessage(string strMessage)
        {
            if (strMessage == "Password is required.")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(lblPasswordRequired));
                Assert.AreEqual(strMessage, driver.FindElement(lblPasswordRequired).Text);
            }
            if (strMessage == "Username is required.")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(lblUsernameRequired));
                Assert.AreEqual(strMessage, driver.FindElement(lblUsernameRequired).Text);
            }
            if(strMessage == "Username is required. Password is required    .")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(lblPasswordRequired));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(lblUsernameRequired));
                Assert.AreEqual("Username is required.", driver.FindElement(lblUsernameRequired).Text);
                Assert.AreEqual("Password is required.", driver.FindElement(lblPasswordRequired).Text);
            }
        }

        public void SiteLogin(string username, string password)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(txtUserName));
            driver.FindElement(txtUserName).SendKeys(username);
            driver.FindElement(txtPassword).SendKeys(password);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btnLogin));
            driver.FindElement(btnLogin).SendKeys(Keys.Enter);
        }
    }
}

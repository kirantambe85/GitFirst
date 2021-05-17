using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoorepayDemo.Utils
{
    public class BrowserInit
    {
        public IWebDriver driver;        
        public WebDriverWait iWait = null;

        Browsers browser = new Browsers();

        public BrowserInit()
        {
            try
            {
                if (Convert.ToBoolean(browser.SelectBrowser("chrome", "Browser.xml")) == true)
                {
                    driver = new ChromeDriver();
                    iWait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Browser has not been initialised: " + e.Message + e.StackTrace);
            }
        }
    }
}

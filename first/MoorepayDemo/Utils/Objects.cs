using MoorepayDemo.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoorepayDemo.Utils
{
    public class Objects
    {
        IWebDriver driver = null;
        WebDriverWait wait = null;

        public Objects(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public static Login PoLogin { get; set; }
        public static Dashboard PoDashboard { get; set; }
        //public static Company PoCompany { get; set; }

        public void ObjectInitialisation()
        {
            PoLogin = new Login(driver, wait);
            PoDashboard = new Dashboard(driver, wait);
            //PoCompany = new Company(driver, wait);
        }
    }
}

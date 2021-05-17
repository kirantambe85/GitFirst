using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoorepayDemo.Utils
{
    class Utilities
    {
        private void waitUnitlSelectOptionsPopulated(SelectElement dropdown, DefaultWait<IWebDriver> IDefaultWait, int itemcount, IWebElement ele)
        {
            IDefaultWait.Timeout = TimeSpan.FromMinutes(1);
            IDefaultWait.PollingInterval = TimeSpan.FromSeconds(2);
            IDefaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IDefaultWait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            dropdown = new SelectElement(ele);
            IDefaultWait.Until(driver => dropdown.Options.Count > 0);
        }
    }
}

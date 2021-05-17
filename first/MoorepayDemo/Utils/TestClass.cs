using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoorepayDemo.Utils
{
    [TestFixture]
    [AllureNUnit]
    [AllureDisplayIgnored]
    class TestClass
    {
        /*[Test(Description = "XXX")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")] */
        [Test]
        public void TestSample()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}

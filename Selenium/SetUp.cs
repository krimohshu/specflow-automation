using GlasswallAutomation.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Text;
using TechTalk.SpecFlow;

namespace GlasswallAutomation.Selenium
{
    [Binding]
    public class SetUp
    {
        protected static IWebDriver driver;
        protected static StringBuilder verificationErrors;
        protected string baseURL;

        [BeforeTestRun]
        public static void SetupTest()
        {
            driver=BrowserFactory.GetBrowser(Browser.Chrome.ToString());
            verificationErrors = new StringBuilder();
        }

        [AfterTestRun]
        public static void TeardownTest()
        {
            try
            {
                BrowserFactory.CloseAllDrivers();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());            
        }

        public enum Browser
        {
            Chrome,
            Firefox,
            IE
        }
    }
}

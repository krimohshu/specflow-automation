using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace GlasswallAutomation.Common
{
    public class BaseSteps 
    {
        //private IWebDriver driver;

        //public BaseSteps(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        Configuration config = new Configuration();

        public void NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(config.UrlValue);
        }        
    }
}

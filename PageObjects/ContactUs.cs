using GlasswallAutomation.Common;
using GoogleAutomation.UIActions;
using OpenQA.Selenium;

namespace GoogleAutomation.PageObjects
{
    public class ContactUs 
    {
        private IWebDriver driver;

        public ContactUs(IWebDriver driver)
        {
            this.driver = driver;
        }

        public ContactUsPageActions GoTo()
        {
            return new ContactUsPageActions(driver);
        }
    }
}

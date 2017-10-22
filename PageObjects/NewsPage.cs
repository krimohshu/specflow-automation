using GlasswallAutomation.Common;
using GlasswallAutomation.UIActions;
using OpenQA.Selenium;

namespace GlasswallAutomation.PageObjects
{
    public class NewsPage :BaseSteps
    {
        private IWebDriver driver;

        public NewsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public NewsPageAction GoTo()
        {
            return new NewsPageAction(driver);
        }
    }
}

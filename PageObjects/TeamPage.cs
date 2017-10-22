using GlasswallAutomation.Common;
using GlasswallAutomation.UIActions;
using OpenQA.Selenium;

namespace GlasswallAutomation.PageObjects
{
    public class TeamPage : BaseSteps
    {
        private IWebDriver driver;

        public TeamPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public TeamPageActions GoTo()
        {
            return new TeamPageActions(driver);
        }
    }
}

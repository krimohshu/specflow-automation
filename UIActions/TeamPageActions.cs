using GlasswallAutomation.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace GlasswallAutomation.UIActions
{
    public class TeamPageActions : BaseSteps
    {
        private IWebDriver driver;

        public TeamPageActions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void MoveToCompanyTab(string homeTab)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(homeTab.ToUpper())));
            
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
            
        public void NavigateToTheTeamPage(string teamPageText)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("menu-item-5718")).Click();
        }

        public string VerifyManagementTeamTab()
        {
            return driver.FindElement(By.LinkText("Management Team")).Text;
        }

        public string ManagementTeamPageTitle()
        {
            return driver.Title; 
        }

        public string VerifyUrlOfFirstImage()
        {
             return driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div/div/div/div/div[1]/div/div/div/div/div/div/div[2]/div/div[1]/div[2]/div[1]/div/div[1]/div/div/div[1]/figure/div/img")).GetAttribute("src");
        }
    }
}

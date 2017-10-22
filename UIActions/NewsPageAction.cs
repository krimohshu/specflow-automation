using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace GlasswallAutomation.UIActions
{
    public class NewsPageAction
    {
        private IWebDriver driver;

        public NewsPageAction(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void MoveToNewsTab(string newsTab)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(newsTab.ToUpper())));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public string VerifyPageTitle()
        {
            return driver.FindElement(By.Id("page-title")).Text;
        }

        public string VerifyArticleValue()
        {
            return driver.FindElement(By.CssSelector("div.rt-col-lg-4:nth-child(5) > div:nth-child(1) > div:nth-child(2) > h3:nth-child(1) > a:nth-child(1)")).Text;
        }

        public void NavigateToTheNewsPage(string teamPageText)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("menu-item-5164")).Click();
        }
    }
}

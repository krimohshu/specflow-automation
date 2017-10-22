using GlasswallAutomation.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;

namespace GoogleAutomation.UIActions
{
    public class ContactUsPageActions : BaseSteps
    {
        private IWebDriver driver;

        public ContactUsPageActions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void MoveToWhyGlasswallTab(string homeTab)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(homeTab.ToUpper())));

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void NavigateToTheHowItWorkPage(string teamPageText)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.Id("menu-item-5109")).Click();
        }

        public string VerifyTryGlasswallForFreeText()
        {
            return driver.FindElement(By.CssSelector(".vc_custom_1505988897741 > div:nth-child(1) > h4:nth-child(1) > span:nth-child(1)")).Text;
        }

        public void NavigateToRequestToFreeTrialPage()
        {
            driver.FindElement(By.CssSelector("a.m-button:nth-child(3)")).Click();
        }

        public void EnterYourName(string yourName)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.FindElement(By.Name("your-name")).SendKeys(yourName);
        }

        public void EnterYourCompany(string yourCompany)
        {
            driver.FindElement(By.CssSelector(".your-company > input:nth-child(1)")).SendKeys(yourCompany);
        }

        public void EnterYourEmail(string yourEmail)
        {
            driver.FindElement(By.CssSelector(".wpcf7-email")).SendKeys(yourEmail);
        }

        public void EnterPhoneNumber(string phoneNumber)
        {
            driver.FindElement(By.CssSelector(".wpcf7-intl-tel")).SendKeys(phoneNumber);
        }

        public void SendRequest()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/main/div/div/div/div/div[2]/div/div/div/div/div/div/div/div/div/div/form/div[4]/div/p/input")).Click();
        }

        public string VerificationMessage()
        {
            Thread.Sleep(1000);
            return driver.FindElement(By.CssSelector(".wpcf7-response-output")).Text;            
        }

        
    }
}

using GlasswallAutomation.Selenium;
using GlasswallAutomation.Common;
using GoogleAutomation.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GoogleAutomation.AcceptanceTests
{
    [Binding]
    public class ContactUsSteps : SetUp
    {
        ContactUs contactUs = new ContactUs(driver);

        [Given(@"I navigate to '(.*)' page via '(.*)' tab")]
        [When(@"I navigate to '(.*)' page via '(.*)' tab")]
        public void GivenINavigateToPageViaTab(string PageText, string tabText)
        {
            contactUs.GoTo().MoveToWhyGlasswallTab(tabText);
            contactUs.GoTo().NavigateToTheHowItWorkPage(PageText);
        }
        
        [Given(@"I navigate to '(.*)' page")]
        public void GivenINavigateToPage(string p0)
        {
            contactUs.GoTo().NavigateToRequestToFreeTrialPage();
        }
      
        [When(@"I send requst to Glasswall for free trial with given details")]
        public void WhenISendRequstToGlasswallForFreeTrialWithGivenDetails(Table table)
        {
            var userDetails = table.CreateInstance<UserDetails>();

            contactUs.GoTo().EnterYourName(userDetails.YourName);
            contactUs.GoTo().EnterYourCompany(userDetails.YourCompany);
            contactUs.GoTo().EnterYourEmail(userDetails.YourEmail);
            contactUs.GoTo().EnterPhoneNumber(userDetails.PhoneNumber);
            contactUs.GoTo().SendRequest();           
        }
        
        [Then(@"I should see '(.*)' on the page")]
        public void ThenIShouldSee(string text)
        {
            Assert.AreEqual(contactUs.GoTo().VerifyTryGlasswallForFreeText(), text.ToUpper());
        }
        
        [Then(@"'(.*)' message should display")]
        public void ThenMessageShouldDisplay(string p0)
        {
            Assert.AreEqual(contactUs.GoTo().VerificationMessage(), p0);
        }
    }
}

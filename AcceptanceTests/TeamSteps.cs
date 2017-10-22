using GlasswallAutomation.PageObjects;
using GlasswallAutomation.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace GlasswallAutomation.AcceptanceTests
{
    [Binding]
    public class TeamSteps : SetUp
    {
        TeamPage teamPage = new TeamPage(driver);

        [Given(@"I am on glasswall home page")]
        public void GivenIAmOnGlasswallHomePage()
        {
            teamPage.NavigateTo(driver);
        }
        
        [When(@"I navigate to '(.*)' team page via '(.*)' tab")]
        public void WhenINavigateToTeamPageViaTab(string teamPageText, string homeTab)
        {
            teamPage.GoTo().MoveToCompanyTab(homeTab);
            teamPage.GoTo().NavigateToTheTeamPage(teamPageText);
        }
        
        [Then(@"'(.*)' tab on the '(.*)' page should display correctly")]
        public void ThenTabOnThePageShouldDisplayCorrectly(string managementTeam,string teamPageText)
        {
            Assert.AreEqual(teamPage.GoTo().VerifyManagementTeamTab(), managementTeam);
            Assert.IsTrue(teamPage.GoTo().ManagementTeamPageTitle().Contains(teamPageText));
        }
        
        [Then(@"The url of the first image should present")]
        public void ThenTheUrlOfTheFirstImageShouldPresent()
        {
            Assert.IsNotNull(teamPage.GoTo().VerifyUrlOfFirstImage());
        }
    }
}

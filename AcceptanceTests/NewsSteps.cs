using GlasswallAutomation.PageObjects;
using GlasswallAutomation.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace GoogleAutomation.AcceptanceTests
{
    [Binding]
    public class NewsSteps : SetUp
    {
        NewsPage newsPage = new NewsPage(driver);

        [When(@"I navigate to '(.*)' news page via '(.*)' tab")]
        public void WhenINavigateToNewsPageViaTab(string teamPageText, string homePageTab)
        {
            newsPage.GoTo().MoveToNewsTab(homePageTab);
            newsPage.GoTo().NavigateToTheNewsPage(teamPageText);
        }

        [Then(@"Page title '(.*)' should display correctly")]
        public void ThenPageTitleShouldDisplayCorrectly(string pageTitle)
        {
            Assert.AreEqual(newsPage.GoTo().VerifyPageTitle().ToUpper(), pageTitle.ToUpper());
        }
        
        [Then(@"the Article '(.*)' should display correctly")]
        public void ThenTheArticleShouldDisplayCorrectly(string article)
        {
            Assert.AreEqual(newsPage.GoTo().VerifyArticleValue().ToUpper(), article.ToUpper());
        }
    }
}

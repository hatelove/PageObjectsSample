using FluentAutomation;
using System;
using TechTalk.SpecFlow;
using PageObjectsWithLogin.Tests.PageObjects;

namespace PageObjectsWithLogin.Tests.Spec.Steps
{
    [Scope(Feature = "GoogleSearch")]
    [Binding]
    public class GoogleSearchSteps : FluentTest
    {
        // we need two page objects, the first one is "Google Search" page, the other one is "Google Search Results" Page
        private GoogleSearchPage _googleSearchPage;
        private GoogleSearchResultsPage _googleSearchResultPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            this._googleSearchPage = new GoogleSearchPage(this);
        }

        public GoogleSearchSteps()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
            this.Config.ScreenshotOnFailedAction(true);
        }

        [Given(@"I go to Google Search homepage")]
        public void GivenIGoToGoogleSearchHomepage()
        {
            this._googleSearchPage.Go();
        }

        [When(@"I serach ""(.*)""")]
        public void WhenISerach(string keywords)
        {
            this._googleSearchPage.Search(keywords);
        }

        [Then(@"the link ""(.*)"" should be displayed on the first search result page")]
        public void ThenTheLinkShouldBeDisplayedOnTheFirstSearchResultPage(string link)
        {
            this._googleSearchResultPage = new GoogleSearchResultsPage(this);
            this._googleSearchResultPage.FindResultsLink(link);
        }
    }
}

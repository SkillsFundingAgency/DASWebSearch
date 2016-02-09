﻿
using Sfa.Eds.Das.Web.AcceptanceTests.Pages;
using TechTalk.SpecFlow;


namespace Sfa.Eds.Das.Web.AcceptanceTests.StepDefinitions
{



    [Binding]
    
    public class StandardsSearchSteps
    {



        SearchPage srchPage;
        

        [Given(@"I am on Search landing page")]
        public void GivenIAmOnSearchLandingPage()
        {


            srchPage = new SearchPage();

            srchPage.launchLandingPage();





            // ScenarioContext.Current.Pending();
        }

        [When(@"I am on Search landing page")]
        public void WhenIAmOnSearchLandingPage()
        {
            srchPage = new SearchPage();

            srchPage.launchLandingPage();
        }


        [Given(@"I enter keyword '(.*)' in search box")]
        public void GivenIEnterKeywordInSearchBox(string p0)
        {


            srchPage.SearchKeyword(p0);

        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            srchPage.clickSearchBox();
        }


        [Then(@"I should be able to see home page with title as ""(.*)""")]
        public void ThenIShouldBeAbleToSeeHomePageWithTitleAs(string p0)
        {
            srchPage.verifyPage("Home Page - Employer Apprenticeship Search");
        }



        [Then(@"I should see matching '(.*)' standards on result page")]
        public void ThenIShouldSeeMatchingStandardsOnResultPage(string p0)
        {
            srchPage.verifyPage("Search Results - Employer Apprenticeship Search");
            srchPage.verifyresultsPages();
            srchPage.verifyStandardFoundinResultPage(p0);

        }

        [Then(@"I should see standards count on result page")]
        public void ThenIShouldSeeStandardsCountOnResultPage()
        {
            srchPage.verifyPage("Search Results - Employer Apprenticeship Search");
            srchPage.verifyresultsPages();
            srchPage.VerifyresultCount();


        }


        [Then(@"I should see message ""(.*)""")]
        public void ThenIShouldSeeMessage(string p0)
        {
            srchPage.VerifyresultCount_invalidSearch();
        }




    }
}







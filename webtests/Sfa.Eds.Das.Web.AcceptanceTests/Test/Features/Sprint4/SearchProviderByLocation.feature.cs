﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Eds.Das.Web.AcceptanceTests.Test.Features.Sprint4
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SearchProvider by location")]
    public partial class SearchProviderByLocationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SearchProviderByLocation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SearchProvider by location", "In order to find training providers\r\nAs an employer\r\nI want to search providers b" +
                    "y entering geo lcoation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Entered Lat long to search provider is within provider given radius")]
        [NUnit.Framework.TestCaseAttribute("52.4113623,-1.5256923", "25", null)]
        public virtual void EnteredLatLongToSearchProviderIsWithinProviderGivenRadius(string latLong, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Entered Lat long to search provider is within provider given radius", exampleTags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given(string.Format("I am on Standard \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.And(string.Format("I enter \'{0}\' in provider search box", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.When("I click on search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
testRunner.Then("I should list of providers on provider search result page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider INTEC BUSINESS COLLEGES searchable when entered latlong with in Provider" +
            " radius")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("52.4113623,-1.5256923", "25", null)]
        public virtual void ProviderINTECBUSINESSCOLLEGESSearchableWhenEnteredLatlongWithInProviderRadius(string latLong, string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider INTEC BUSINESS COLLEGES searchable when entered latlong with in Provider" +
                    " radius", @__tags);
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
testRunner.Given(string.Format("I am on Standard \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
testRunner.And(string.Format("I enter \'{0}\' in provider search box", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("I should see provider \"INTEC BUSINESS COLLEGES\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search ASPIRE ACHIEVE ADVANCE LIMITED Provider by latlong falling on Provider rad" +
            "ius")]
        [NUnit.Framework.TestCaseAttribute("53.4679071,-0.3699098", "25", null)]
        public virtual void SearchASPIREACHIEVEADVANCELIMITEDProviderByLatlongFallingOnProviderRadius(string latLong, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search ASPIRE ACHIEVE ADVANCE LIMITED Provider by latlong falling on Provider rad" +
                    "ius", exampleTags);
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
testRunner.Given(string.Format("I am on Standard \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
testRunner.And(string.Format("I enter \'{0}\' in provider search box", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
testRunner.Then("I should see provider \"ASPIRE ACHIEVE ADVANCE LIMITED\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Provider by latlong falling inside Provider radius")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("53.5152058,-0.5601394", "25", null)]
        public virtual void SearchProviderByLatlongFallingInsideProviderRadius(string latLong, string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Provider by latlong falling inside Provider radius", @__tags);
#line 38
this.ScenarioSetup(scenarioInfo);
#line 39
testRunner.Given(string.Format("I am on Standard \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.And(string.Format("I enter \'{0}\' in provider search box", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
testRunner.Then("I should see provider \"ASPIRE ACHIEVE ADVANCE LIMITED\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
testRunner.And("I should see provider \"Millbrook management services limited\" in provider results" +
                    " page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Provider by latlong outside  Provider radius 60 miles")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("53.5117482,-0.3669604", "25", null)]
        public virtual void SearchProviderByLatlongOutsideProviderRadius60Miles(string latLong, string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Provider by latlong outside  Provider radius 60 miles", @__tags);
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
testRunner.Given(string.Format("I am on Standard \'{0}\' detail page", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
testRunner.And(string.Format("I enter \'{0}\' in provider search box", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
testRunner.Then("I should not see provider \"ASPIRE ACHIEVE ADVANCE LIMITED\" in provider results pa" +
                    "ge.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
testRunner.And("I should see provider \"Millbrook management services limited\" in provider results" +
                    " page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Provider by latlong falling inside two provider radius.")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("53.5152058,-0.5601394", "25", null)]
        public virtual void SearchProviderByLatlongFallingInsideTwoProviderRadius_(string latLong, string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Provider by latlong falling inside two provider radius.", @__tags);
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
testRunner.Given(string.Format("I have entered \'{0}\' which is inside radius of two providers.", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
testRunner.Then("I should see provider \"ASPIRE ACHIEVE ADVANCE LIMITED\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
testRunner.And("I should see provider \"Millbrook management services limited\" in provider results" +
                    " page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
testRunner.And("I should see provider \"Millbrook management services limited\" listed in top as ne" +
                    "arest training provider.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search results More than on provider returned in search result page.")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("52.7365701,-1.0496998", null)]
        public virtual void SearchResultsMoreThanOnProviderReturnedInSearchResultPage_(string latLong, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search results More than on provider returned in search result page.", @__tags);
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
testRunner.Given(string.Format("I have entered \'{0}\' which is intersecting between two providers radius", latLong), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
testRunner.When("I search Search for provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
testRunner.Then("I should see total of \"5\" providers found.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 78
testRunner.And("I should see provider \"INTEC BUSINESS COLLEGES\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
testRunner.And("I should see provider \"COVENTRY & WARWICKSHIRE CHAMBER TRAINING (CWT)\" in provide" +
                    "r results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
testRunner.And("I should see provider \"Aspire archive advance limited\" in provider result page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
testRunner.And("I should see provider \"Millbrook management services limited\" in provider results" +
                    " page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
testRunner.And("I should see provider \"Training services 2000 ltd\" in provider results page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

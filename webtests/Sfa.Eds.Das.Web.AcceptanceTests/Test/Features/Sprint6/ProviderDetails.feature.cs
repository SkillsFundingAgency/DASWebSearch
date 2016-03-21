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
namespace Sfa.Eds.Das.Web.AcceptanceTests.Test.Features.Sprint6
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ProviderDetails")]
    public partial class ProviderDetailsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ProviderDetails.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ProviderDetails", "In order to chose a provider from available providers\nAs an employer \nI want to b" +
                    "e see full provider detail on provider page", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Provider with more than one loocation,show only one location as choosen by employ" +
            "er")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void ProviderWithMoreThanOneLoocationShowOnlyOneLocationAsChoosenByEmployer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider with more than one loocation,show only one location as choosen by employ" +
                    "er", new string[] {
                        "ignore"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I have a provider with more than on location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.When("I chose a provider from result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
testRunner.Then("I should see only one location on provider detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provider with 100% employer based training should not show venue  details on prov" +
            "ider detail page")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void ProviderWith100EmployerBasedTrainingShouldNotShowVenueDetailsOnProviderDetailPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provider with 100% employer based training should not show venue  details on prov" +
                    "ider detail page", new string[] {
                        "ignore"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
testRunner.Given("I have provider with full training at employer location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
testRunner.When("I choose this provider from result page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.Then("I should see provider detail page with no veunue details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify provider detail page")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void VerifyProviderDetailPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify provider detail page", new string[] {
                        "ignore"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
testRunner.Given("I am on provider result page for a choosen standard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
testRunner.When("I select any of the provider from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("I should see  provider detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
testRunner.And("I should see \"Provider name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
testRunner.And("I should see \"Employer satisfaction\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
testRunner.And("I should see \"learner satisfaction\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
testRunner.And("I should see \"standard name\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
testRunner.And("I should see \"delivery mode\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
testRunner.And("I should see training \"venue\" name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
testRunner.And("I should see training location name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
testRunner.And("I should see training contact number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
testRunner.And("I should see training contact email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify training options")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void VerifyTrainingOptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify training options", new string[] {
                        "ignore"});
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
testRunner.Given("I have provider \'<providername>\' with all of traning modes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
testRunner.When("I open provider detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.Then("under training modes I should see \"block release\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
testRunner.And("I should see \"day release\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
testRunner.And("I  should see \"at your location\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
testRunner.And("I should see location name.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify end to end provider detail page")]
        [NUnit.Framework.CategoryAttribute("ginore")]
        public virtual void VerifyEndToEndProviderDetailPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify end to end provider detail page", new string[] {
                        "ginore"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
testRunner.Given("I have a provider with updated info in course directory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
testRunner.When("I open provider detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.Then("I should see updated provider info in provider detail page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to navigate back to provider result page from detail page.")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void ShouldBeAbleToNavigateBackToProviderResultPageFromDetailPage_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to navigate back to provider result page from detail page.", new string[] {
                        "ignore"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
testRunner.Given("I am on provider detail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
testRunner.When("I click on back link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
testRunner.Then("I shoudl be able to return back to provider list page.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("When provider detail page is bookmarked, it should show only provider detail page" +
            " when provider is still active.( FCS file to have provider inactive and test boo" +
            "kmarked link)")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void WhenProviderDetailPageIsBookmarkedItShouldShowOnlyProviderDetailPageWhenProviderIsStillActive_FCSFileToHaveProviderInactiveAndTestBookmarkedLink()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When provider detail page is bookmarked, it should show only provider detail page" +
                    " when provider is still active.( FCS file to have provider inactive and test boo" +
                    "kmarked link)", new string[] {
                        "ignore"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Das.Sas.WebTest.AcceptanceTests.E2E
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Framework User Journey")]
    public partial class FrameworkUserJourneyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FrameworkUserJourney.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Framework User Journey", "\tAs an employer\r\n\tI want to be able to search for training options\r\n\tand find a p" +
                    "rovider for a given framework", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Should find a framework and provider")]
        [NUnit.Framework.CategoryAttribute("E2E")]
        [NUnit.Framework.CategoryAttribute("CI")]
        [NUnit.Framework.CategoryAttribute("SystemTest")]
        [NUnit.Framework.CategoryAttribute("Demo")]
        [NUnit.Framework.CategoryAttribute("PreProd")]
        [NUnit.Framework.CategoryAttribute("Prod")]
        public virtual void ShouldFindAFrameworkAndProvider()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should find a framework and provider", new string[] {
                        "E2E",
                        "CI",
                        "SystemTest",
                        "Demo",
                        "PreProd",
                        "Prod"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I navigated to the Start page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Token",
                        "Key"});
            table1.AddRow(new string[] {
                        "JOBROLE",
                        "data.framework.JOBROLE"});
            table1.AddRow(new string[] {
                        "Postcode",
                        "data.framework.Postcode"});
#line 9
 testRunner.Given("I have data in the config", ((string)(null)), table1, "Given ");
#line 14
 testRunner.And("I navigated to the Start page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I choose Start Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I am on the Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Search Box",
                        "{JOBROLE}"});
#line 18
 testRunner.When("I enter data", ((string)(null)), table2, "When ");
#line 21
 testRunner.And("I choose Search Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("I am on the Search Results page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.When("I choose First Framework Result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("I am on the Framework Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.When("I choose Search Page Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("I am on the Provider Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Postcode Search Box",
                        "{Postcode}"});
#line 30
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 33
 testRunner.When("I choose Search Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I am on the Framework Provider Results page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("I see Provider Results list contains at least 1 items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.When("I choose First Provider Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("I am on the Provider Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table4.AddRow(new string[] {
                        "Provider Name",
                        "Exists",
                        "true"});
#line 39
 testRunner.And("I see", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

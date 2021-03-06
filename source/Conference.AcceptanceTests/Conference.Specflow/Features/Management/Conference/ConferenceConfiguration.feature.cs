﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Management.Conference
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsFeature : Xunit.IUseFixture<ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ConferenceConfiguration.feature"
#line hidden
        
        public ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Conference configuration scenarios for creating and editing Conference settings", "In order to create or update a Conference configuration\r\nAs a Business Customer\r\n" +
                    "I want to be able to create or update a Conference and set its properties", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void FeatureBackground()
        {
#line 20
#line 21
testRunner.Given("the Business Customer selected the Create Conference option");
#line hidden
        }
        
        public virtual void SetFixture(ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Conference configuration scenarios for creating and editing Conference settings")]
        [Xunit.TraitAttribute("Description", "A new Conference is created with the required information")]
        public virtual void ANewConferenceIsCreatedWithTheRequiredInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A new Conference is created with the required information", new string[] {
                        "Ignore"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email"});
            table1.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com"});
#line 25
testRunner.Given("this information entered into the Owner Information section", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table2.AddRow(new string[] {
                        "CQRS2012",
                        "CQRS summit 2012 conference",
                        "cqrs2012",
                        "05/02/2012",
                        "05/12/2012"});
#line 28
testRunner.And("this inforamtion entered into the Conference Information section", ((string)(null)), table2);
#line 31
testRunner.When("the Business Customer proceed to create the Conference");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table3.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012",
                        "CQRS summit 2012 conference",
                        "cqrs2012",
                        "05/02/2012",
                        "05/12/2012"});
#line 32
testRunner.Then("following details will be shown for the created Conference", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Conference configuration scenarios for creating and editing Conference settings")]
        [Xunit.TraitAttribute("Description", "An existing unpublished Conference is selected and published")]
        public virtual void AnExistingUnpublishedConferenceIsSelectedAndPublished()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An existing unpublished Conference is selected and published", new string[] {
                        "Ignore"});
#line 38
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table4.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012P",
                        "CQRS summit 2012 conference (Published)",
                        "cqrs2012p",
                        "05/02/2012",
                        "05/12/2012"});
#line 39
testRunner.Given("an existing conference with this information", ((string)(null)), table4);
#line 42
testRunner.When("the Business Customer proceed to publish the Conference");
#line 43
testRunner.Then("the state of the Conference change to Published");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Conference configuration scenarios for creating and editing Conference settings")]
        [Xunit.TraitAttribute("Description", "An existing Conference is edited and updated")]
        public virtual void AnExistingConferenceIsEditedAndUpdated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An existing Conference is edited and updated", new string[] {
                        "Ignore"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table5.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012U",
                        "CQRS summit 2012 conference (Original)",
                        "cqrs2012p",
                        "05/02/2012",
                        "05/12/2012"});
#line 48
testRunner.Given("an existing conference with this information", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Description"});
            table6.AddRow(new string[] {
                        "CQRS summit 2012 conference (Updated)"});
#line 51
testRunner.And("the Business Customer proceed to update the existing settigns with this informati" +
                    "on", ((string)(null)), table6);
#line 54
testRunner.When("the Business Customer proceed to save the changes");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Description"});
            table7.AddRow(new string[] {
                        "CQRS summit 2012 conference (Updated)"});
#line 55
testRunner.Then("this information is show up in the Conference settings", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Conference configuration scenarios for creating and editing Conference settings")]
        [Xunit.TraitAttribute("Description", "Access an existing Conference")]
        public virtual void AccessAnExistingConference()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access an existing Conference", new string[] {
                        "Ignore"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table8.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012A",
                        "CQRS summit 2012 conference (Access)",
                        "cqrs2012p",
                        "05/02/2012",
                        "05/12/2012"});
#line 62
testRunner.Given("an existing conference with this information", ((string)(null)), table8);
#line 65
testRunner.When("the Business Customer proceed to get acecss to the conference settings");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Owner",
                        "Email",
                        "Name",
                        "Description",
                        "Slug",
                        "Start",
                        "End"});
            table9.AddRow(new string[] {
                        "Gregory Weber",
                        "gregoryweber@contoso.com",
                        "CQRS2012A",
                        "CQRS summit 2012 conference (Access)",
                        "cqrs2012p",
                        "05/02/2012",
                        "05/12/2012"});
#line 66
testRunner.Then("this information is show up in the Conference settings", ((string)(null)), table9);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ConferenceConfigurationScenariosForCreatingAndEditingConferenceSettingsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.steps;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.core.hooks
{
	[Binding]
	public sealed class BaseHooks : BaseSteps
	{
		private static ExtentReports Extent;
		private static ExtentTest Scenario;
		private static ExtentTest FeatureName;
		private static IDictionary<string, ExtentTest> Features = new Dictionary<string, ExtentTest>();

		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			var HtmlReporter = new ExtentHtmlReporter(@"D:\automação\sanofi\Sanofi\TestResults\Report.txt");
			HtmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
			Extent = new ExtentReports();
			Extent.AttachReporter(HtmlReporter);

		}


		[BeforeFeature]
		public static void BeforeFeature(FeatureContext context)
		{
			string titulo = context.FeatureInfo.Title;

			if (Features.TryGetValue(titulo, out ExtentTest feature) == false) { 
				FeatureName = Extent.CreateTest<Feature>(context.FeatureInfo.Title);
				Features.Add(titulo, FeatureName);
			} else
			{
				FeatureName = feature;
			}
		}


		[AfterScenario]
		public void AfterScenario()
		{
			App.Dispose();
		}

		[BeforeScenario]
		public static void BeforeScenario(ScenarioContext context)
		{
			App.Initalize();
			Scenario = FeatureName.CreateNode<Scenario>(context.ScenarioInfo.Title);
		}

		[AfterStep]
		public void InsertingReportingSteps(ScenarioContext context)
		{
			string StepType;
			StepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

			if (context.TestError == null)
			{
				if (StepType == "Given")
					Scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
				else if (StepType == "When")
					Scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
				else if (StepType == "Then")
					Scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
			}
			else if (context.TestError != null)
			{				
				if (StepType == "Given")
					Scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text + context.TestError.Message).Fail(context.TestError.Message);
				else if (StepType == "When")
					Scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text + context.TestError.Message).Fail(context.TestError.Message);
				else if (StepType == "Then")
					Scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text + context.TestError.Message).Fail(context.TestError.Message);
			}
		}

		[AfterTestRun]
		public static void AfterTestRun()
		{
			Extent.Flush();
		}
	}
}

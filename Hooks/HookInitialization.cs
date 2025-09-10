using System.Collections;
using UDC.POM;
using UDC.StepDefinitions.CssStepDefinations;
using UDC.StepDefinitions.TestDataFiles;
using UDC.UDC.Core;

namespace UDC.Hooks
{
    [Binding]
    public class HookInitialization
    {
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        private LoginPage _loginPage;
      

        private string userType;

        public HookInitialization(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            // Set project and feature name for Excel file
            ExcelHelper.SetProjectAndFeature("CSS", featureContext.FeatureInfo.Title);

            DriverContext.InitDriver();
            var driver = DriverContext.Driver;
            var testData = new TestDataModel();
            var _pageObjectCon = new DO_PageObjectContainer();
            DriverContext.Driver.Navigate().GoToUrl(_pageObjectCon.testData.DoTestEnUrl);
            //DriverContext.Driver.Navigate().GoToUrl("https://devportalcommercial.aurionpro.com/authentication/login");
            ReportingManager.CreateTest($"Feature: {featureContext.FeatureInfo.Title}");
            ReportingManager.LogInfo("Login page loaded successfully.");

            string userType = featureContext.FeatureInfo.Tags.FirstOrDefault(tag =>
        tag.Equals("internal", StringComparison.OrdinalIgnoreCase) ||
        tag.Equals("external", StringComparison.OrdinalIgnoreCase));

            if (string.IsNullOrEmpty(userType))
                throw new Exception("Missing @internal or @external tag in feature file.");

            // Store it somewhere accessible (like a static or config holder)
            TestRunContext.UserType = userType;

            var loginPage = new LoginPage(DriverContext.Driver); // Ensure Driver is initialized
            var (username, password) = CredentialManager.GetCredentials(userType);
            loginPage.EnterValidCredentials(username, password);
        }

        [BeforeTestRun]
        public static void SetupReporting()
        {
            ReportingManager.InitReport();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var scenarioTitle = _scenarioContext.ScenarioInfo.Title;

            string program = string.Empty;
            string product = string.Empty;

            foreach (DictionaryEntry entry in _scenarioContext.ScenarioInfo.Arguments)
            {
                Console.WriteLine($"Key: {entry.Key} | Value: {entry.Value}");

                string keyString = entry.Key?.ToString() ?? string.Empty;

                if (keyString.Equals("Program", StringComparison.OrdinalIgnoreCase))
                {
                    program = entry.Value?.ToString() ?? string.Empty;
                }
                else if (keyString.Equals("Product", StringComparison.OrdinalIgnoreCase))
                {
                    product = entry.Value?.ToString() ?? string.Empty;
                }
            }

            string customTestName = !string.IsNullOrEmpty(program) && !string.IsNullOrEmpty(product)
                ? $"{scenarioTitle} - {program} - {product}"
                : scenarioTitle;

            // Store the unique name for this scenario instance
            _scenarioContext["CustomScenarioName"] = customTestName;

            ReportingManager.CreateTest(customTestName);
            ReportingManager.LogInfo($"Starting scenario: {customTestName}");
        }

        [AfterStep]
        public void AfterStep()
        {
            var stepInfo = _scenarioContext.StepContext.StepInfo;

            string scenarioWithData = _scenarioContext.ContainsKey("CustomScenarioName")
                ? _scenarioContext["CustomScenarioName"].ToString()
                : _scenarioContext.ScenarioInfo.Title;

            string status = _scenarioContext.TestError == null ? "Passed" : "Failed";

            if (_scenarioContext.TestError == null)
            {
                ReportingManager.LogPass($"Step passed: {stepInfo.Text}");
            }
            else
            {
                var errorMessage = _scenarioContext.TestError.Message;
                var screenshotPath = DriverContext.TakeScreenshot(stepInfo.Text);
                ReportingManager.LogFail($"Step failed: {stepInfo.Text}. Error: {errorMessage}", screenshotPath);
            }
            ExcelHelper.LogStepResult(scenarioWithData, stepInfo.Text, status);
        }

        [AfterScenario]
        public void TearDownDriver()
        {
            var _pageObjectCon = new DO_PageObjectContainer();
            string scenarioName = _scenarioContext.ContainsKey("CustomScenarioName")
                ? _scenarioContext["CustomScenarioName"].ToString()
                : _scenarioContext.ScenarioInfo.Title;

            if (_scenarioContext.TestError != null)
            {
                ReportingManager.LogFail($"Scenario failed: {scenarioName}");
            }
            else
            {
                ReportingManager.LogPass($"Scenario passed: {scenarioName}");
            }
           // _pageObjectCon.loginPage.ClickOnBellIcon();
            try
            {
                ReportingManager.LogInfo("Navigating back to Dashboard...");
                _pageObjectCon.loginPage.ClickOnDashboard();
                Thread.Sleep(15000);
                ReportingManager.LogInfo("Successfully navigated to Dashboard.");
            }
            catch
            {
                var driver = DriverContext.Driver;
                var loginPage = new LoginPage(driver);
                try
                {

                    // Check if username field is displayed
                    if (loginPage.IsUsernameFieldDisplayed())
                    {
                        string userType = TestRunContext.UserType ?? "internal"; // fallback
                        var (username, password) = CredentialManager.GetCredentials(userType);

                        loginPage.EnterValidCredentials(username, password);
                        ReportingManager.LogInfo("User trying to login with valid credentials.");
                    }
                    ReportingManager.LogInfo("Re-Entered Login credentials ");
                }
                catch
                {
                    //loginPage.SessionTimeoutPopup();
                }
            }
        }

        [AfterTestRun]
        public static void TearDownReporting()
        {
            ReportingManager.FlushReport();
        }

        [AfterFeature]
        public static void AfterFeature(FeatureContext featureContext)
        {
            ReportingManager.LogInfo($"Feature completed: {featureContext.FeatureInfo.Title}");
            ExcelHelper.FlushCurrentFeatureToExcel();
            DriverContext.CloseDriver();
        }
        private static string GetUserTypeFromFeatureTag(FeatureContext featureContext)
        {
            if (featureContext.FeatureInfo.Tags.Contains("internal"))
                return "internal";
            else if (featureContext.FeatureInfo.Tags.Contains("external"))
                return "external";
            else
                throw new Exception("No valid @internal or @external tag found in feature file.");
        }
    }
    public static class TestRunContext
    {
        public static string UserType { get; set; }
    }
}

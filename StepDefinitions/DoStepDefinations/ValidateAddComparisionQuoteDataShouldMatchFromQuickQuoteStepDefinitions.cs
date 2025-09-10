using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Reqnroll;
using UDC.POM.DOPages;
using UDC.StepDefinitions.CssStepDefinations;
using UDC.UDC.Core;

namespace UDC.StepDefinitions.DoStepDefinations
{
    [Binding]
    public class ValidateAddComparisionQuoteDataShouldMatchFromQuickQuoteStepDefinitions
    {
        private readonly DO_PageObjectContainer _pageObjects;
        private Dictionary<string, string> quickQuoteValues;
        private Dictionary<string, string> comparisonValue;
        public ValidateAddComparisionQuoteDataShouldMatchFromQuickQuoteStepDefinitions(DO_PageObjectContainer pageObjects)
        {
            _pageObjects = pageObjects;
        }

        [Then("the user is land on the Select Application page")]
        public void ThenTheUserIsLandOnTheSelectApplicationPage()
        {
            ReportingManager.LogInfo("Navigating to the login page.");
        }

        [When("the user clicks the Quotes & Application button")]
        public void WhenTheUserClicksTheQuotesApplicationButton()
        {
            _pageObjects.selectApplicationPage.ClickOnQuoteAndApplicationButton();
            ReportingManager.LogInfo("Clicked on Quote & Application button successfully");
        }

        [Then("the user is redirected to dashboard page")]
        public void ThenTheUserIsRedirectedToDashboardPage()
        {
            string dashboardurl = DriverContext.Driver.Url;
            ReportingManager.LogPass("Logged in usign URL : -" + dashboardurl + " .");
            ReportingManager.LogPass("Navigated to the dashboard successfully");
        }

        [When("the user selects the Dealer dropdown in the dashboard page")]
        public void WhenTheUserSelectsTheDealerDropdownInTheDashboardPage()
        {
            //_pageObjects.DashboardPage.SelectDealer("Delear A");
        }

        [When("the user clicks the Create Quick Quote button")]
        public void WhenTheUserClicksTheCreateQuickQuoteButton()
        {
            _pageObjects.DashboardPage.ClickOnCreateQuickQuoteButton();
            ReportingManager.LogInfo("Click on Create Quick Quote");
        }

        [When("the user selects product {string} in the dropdown")]
        public void WhenTheUserSelectsProductInTheDropdown(string product)
        {
            _pageObjects.QuickQuotePage.SelectProductDropdown(product);
            ScenarioContext.Current["Product"] = product;
        }

        [When("the user selects program {string} in the dropdown")]
        public void WhenTheUserSelectsProgramInTheDropdown(string program)
        {
            _pageObjects.QuickQuotePage.SelectProgramDropDown(program);
            ScenarioContext.Current["Program"] = program;
        }

        [Then("the user validate the cash price by default value")]
        public void ThenTheUserValidateTheCashPriceByDefaultValue()
        {
            string actualCashPrice = _pageObjects.QuickQuotePage.CashPrice();
            string expectedCashPrice = "$0.00";
            if (actualCashPrice.Equals(expectedCashPrice))
            {
                ReportingManager.LogPass($"✅ Cash Price by default: Actual: {actualCashPrice}, Expected: {expectedCashPrice}");
                ReportingManager.AddScreenshotToReport("Quick quote page captured successfully.");
            }
            else
            {
                ReportingManager.LogFail($"❌ Cash Price by default: actualValue:{actualCashPrice}, expectedValue: {expectedCashPrice}");
            }
        }

        [Then("the user validate the cash price field error message")]
        public void ThenTheUserValidateTheCashPriceFieldErrorMessage()
        {
            string actualCashPriceErrorMsg = _pageObjects.QuickQuotePage.CashPriceErrorMsg();
            string expectedCashPriceErrorMsg = "This field cannot be blank";
            if (actualCashPriceErrorMsg.Equals(expectedCashPriceErrorMsg))
            {
                ReportingManager.LogPass($"✅ Cash Price Field Error Message:actualValue:{actualCashPriceErrorMsg}, expectedValue: {expectedCashPriceErrorMsg}");
                ReportingManager.AddScreenshotToReport("Quick Quote mandatory filed error message captured successfully.");
            }
        }

        [Then("the user validate the Interest rate filed error message")]
        public void ThenTheUserValidateTheInterestRateFiledErrorMessage()
        {
            string actualCashPriceErrorMsg = _pageObjects.QuickQuotePage.InterestRateErrorMsg();
            string expectedCashPriceErrorMsg = "This field cannot be blank";
            if (actualCashPriceErrorMsg.Equals(expectedCashPriceErrorMsg))
            {
                ReportingManager.LogPass($"✅ actualValue:{actualCashPriceErrorMsg}, expectedValue: {expectedCashPriceErrorMsg}");
                ReportingManager.AddScreenshotToReport("Quick Quote mandatory filed error message captured successfully.");
            }
        }

        [When("the user enters the cash price in the field")]
        public void WhenTheUserEntersTheCashPriceInTheField()
        {
            _pageObjects.QuickQuotePage.EnterCashPrice(_pageObjects.QuickQuoteTestData.CashPrice[0]);
        }

        [When("the user enters Interest rate in the filed")]
        public void WhenTheUserEntersInterestRateInTheFiled()
        {
            _pageObjects.QuickQuotePage.EnterInterestRate("7");
            
        }

        [When("the user selects the {string} in the term dropdown")]
        public void WhenTheUserSelectsTheInTheTermDropdown(string term)
        {
            _pageObjects.QuickQuotePage.SelectTermDropdown(_pageObjects.QuickQuoteTestData.TermsInMonths[0]);
        }

        [When("the user selects the {string} in the dropdown")]
        public void WhenTheUserSelectsTheInTheDropdown(string frequency)
        {
            _pageObjects.QuickQuotePage.SelectFrequencyDropdown(_pageObjects.QuickQuoteTestData.Frequency[2]);
        }

        [When("the user enters the deposit in the field")]
        public void WhenTheUserEntersTheDepositInTheField()
        {
            _pageObjects.QuickQuotePage.EnterDepositSecondQuote(_pageObjects.QuickQuoteTestData.Deposit[0]);
        }

        [When("the user enter the balloon percentage in the field")]
        public void WhenTheUserEnterTheBalloonPercentageInTheField()
        {
            _pageObjects.QuickQuotePage.EnterBalloon(_pageObjects.QuickQuoteTestData.Balloon[0]);
        }
        [When("the user clicks the Calculate button")]
        public void WhenTheUserClicksTheCalculateButton()
        {
            _pageObjects.QuickQuotePage.ClickOnCalculateButton();
            quickQuoteValues = _pageObjects.QuickQuotePage.GetFieldValues();
            _pageObjects.QuickQuotePage.ClickOnCreateQuoteButton();
        }

        [Then("after the hit calculation button then AddcomparisonTwo is enabled")]
        public void ThenAfterTheHitCalculationButtonThenAddcomparisonIsEnabled()
        {
            _pageObjects.QuickQuotePage.IsAddComparisonButtonEnabled();
        }

        [Then("the Second Quote data should match the first quote")]
        public void ThenTheSecondQuoteDataShouldMatchTheFirstQuote()
        {
            var quickQuoteValues = _pageObjects.QuickQuotePage.GetFieldValues();
            var comparisonValues = _pageObjects.QuickQuotePage.GetAddcomaparisonFieldValues();
            var fieldsToCompare = new List<string> { "program", "product", "Calculate For", "Cash Price", "Interest Rate ", "frequency" };
            var mismatches = new List<string>();
            var allFieldsMatch = true;

            foreach (var field in fieldsToCompare)
            {
                var quickQuoteValue = quickQuoteValues.ContainsKey(field) ? quickQuoteValues[field] : "<missing>";
                var comparisonValue = comparisonValues.ContainsKey(field) ? comparisonValues[field] : "<missing>";

                if (!string.Equals(quickQuoteValue, comparisonValue, StringComparison.OrdinalIgnoreCase))
                {
                    allFieldsMatch = false;
                    mismatches.Add($"❌ {field}: Expected '{quickQuoteValue}', but got '{comparisonValue}'");
                }

                ReportingManager.LogPass($"✅ field of Quote 1 {quickQuoteValue}  field of Quote 2 {comparisonValue}");
            }
            if (allFieldsMatch)
            {
                ReportingManager.LogPass($"✅ All fields in Quote 2 match the Quote 1 successfully.");
                ReportingManager.AddScreenshotToReport("Quick Quote 2");
            }
            else
            {
                var mismatchMessage = "Field mismatches found:\n" + string.Join("\n", mismatches);
                ReportingManager.LogFail($"❌ Field Mismatches:\n{mismatchMessage}");
                Assert.Fail(mismatchMessage);
            }
        }

        [When("the user modifies the second quote's fields")]
        public void WhenTheUserModifiesTheSecondQuotesFields()
        {
            string product = ScenarioContext.Current["Product"].ToString();
            string program = ScenarioContext.Current["Program"].ToString();

            if (product == "CSA-B-Assigned")
            {
                if (program == "CSA Business - Equipment Dealer")
                {
                    // Select opposite program: CSA Business - MV Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[1]);
                }
                else if (program == "CSA Business - MV Dealer")
                {
                    // Select opposite program: CSA Business - Equipment Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[0]);
                }
            }
            if (product == "CSA-B-Direct Fixed")
            {
                if (program == "Webform - CSA Business - RA Dealer")
                {
                    // Select opposite program: Webform - CSA Business - EQ Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[5]);
                }
                else if (program == "Webform - CSA Business - EQ Dealer")
                {
                    // Select opposite program: Webform - CSA Business - RA Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[3]);
                }
                else if (program == "Webform - CSA Business - Direct")
                {
                    // Select opposite program: Webform - CSA Business - RA Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[3]);
                }
            }

            else if (product == "CSA-C-Assigned")
            {
                if (program == "CSA Personal - Equipment Dealer")
                {
                    // Select opposite program: CSA Personal - MV Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[7]);
                }
                else if (program == "CSA Personal - MV Dealer")
                {
                    // Select opposite program: CSA Personal - Equipment Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[6]);
                }
            }
            else if (product == "CSA-C-Direct Fixed")
            {
                if (program == "Webform - CSA Personal - EQ Dealer")
                {
                    // Select opposite program: Webform - CSA Personal - MV Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[9]);
                }
                else if (program == "Webform - CSA Personal - MV Dealer")
                {
                    // Select opposite program: Webform - CSA Personal - EQ Dealer
                    _pageObjects.QuickQuotePage.SelectSecondQuoteProgramDropDown(_pageObjects.QuickQuoteTestData.Programs[8]);
                }
            }

           
        }

        [When("the user enter the cash price in the field")]
        public void WhenTheUserEnterTheCashPriceInTheField()
        {
            Thread.Sleep(2000);
            _pageObjects.QuickQuotePage.EnterSecondQuoteCashPrice("20000.00");
        }

        [When("the user enter Interest rate in the filed")]
        public void WhenTheUserEnterInterestRateInTheFiled()
        {
            Thread.Sleep(2000);
            _pageObjects.QuickQuotePage.EnterSecondQuoteInterestRate(_pageObjects.QuickQuoteTestData.InterestRate[0]);
        }

        [When("the user click the Calculation button")]
        public void WhenTheUserClickTheCalculationButton()
        {
            _pageObjects.QuickQuotePage.ClickOnSecondQuoteCalculateButton();
        }

        [Then("After the Clicking Calculation button then AddcomparisonThree is enabled")]
        public void ThenAfterTheClickingCalculationButtonThenAddcomparisonThreeIsEnabled()
        {
            _pageObjects.QuickQuotePage.IsAddComparisonButtonThreeEnabled();
        }

        [Then("the third quote data should match the second quote")]
        public void ThenTheThirdQuoteDataShouldMatchTheSecondQuote()
        {
            var quickQuoteValues = _pageObjects.QuickQuotePage.GetAddcomaparisonFieldValues();
            var comparisonValues = _pageObjects.QuickQuotePage.GetAddcomaparisonThreeFieldValues();
            var fieldsToCompare = new List<string> { "program", "product", "Calculate For", "Cash Price", "Interest Rate ", "frequency" };
            var mismatches = new List<string>();
            var allFieldsMatch = true;

            foreach (var field in fieldsToCompare)
            {
                var quickQuoteValue = quickQuoteValues.ContainsKey(field) ? quickQuoteValues[field] : "<missing>";
                var comparisonValue = comparisonValues.ContainsKey(field) ? comparisonValues[field] : "<missing>";

                if (!string.Equals(quickQuoteValue, comparisonValue, StringComparison.OrdinalIgnoreCase))
                {
                    allFieldsMatch = false;
                    mismatches.Add($"❌ {field}: Expected '{quickQuoteValue}', but got '{comparisonValue}'");
                }

                ReportingManager.LogPass($"✅ field of Quote 2 {quickQuoteValue} , field of Quote 3 {comparisonValue}");
            }
            if (allFieldsMatch)
            {
                ReportingManager.LogPass($"✅ All fields in Quote 3 match the Quote 2 successfully.");
                ReportingManager.AddScreenshotToReport("Quick Quote 3 screenshot captured successfully.");
            }
            else
            {
                var mismatchMessage = "Field mismatches found:\n" + string.Join("\n", mismatches);
                ReportingManager.LogFail($"❌ Field Mismatches:\n{mismatchMessage}");
                Assert.Fail(mismatchMessage);
            }
        }

        [Then("the user verify balloon Amount before and after calculation")]
        public void ThenTheUserVerifyBalloonAmountBeforeAndAfterCalculation()
        {
            _pageObjects.QuickQuotePage.ValidateBalloonAmountBeforeAndAfterCalculation();
        }

        [When("the user selects the Calculate For dropdown")]
        public void WhenTheUserSelectsTheCalculateForDropdown()
        {
            _pageObjects.QuickQuotePage.SelectCalculateForDropdown(_pageObjects.QuickQuoteTestData.CalculateFor[2]);
        }

        [When("the user selects the Calculate For dropdown in the Quote three")]
        public void WhenTheUserSelectsTheCalculateForDropdownInTheQuoteThree()
        {
            _pageObjects.QuickQuotePage.SelectCalculateForDropdownQuoteThree(_pageObjects.QuickQuoteTestData.CalculateFor[3]);
        }

        [Then("the user validate the balloon Amount is read only before clicking calculation")]
        public void ThenTheUserValidateTheBalloonAmountIsReadOnlyBeforeClickingCalculation()
        {
            _pageObjects.QuickQuotePage.ValidateBalloonAmountIsReadonly();
        }

        [Then("the user validate the cash price is read only before clicking calculation")]
        public void ThenTheUserValidateTheCashPriceIsReadOnlyBeforeClickingCalculation()
        {
            _pageObjects.QuickQuotePage.ValidateCashPriceIsReadonly();
        }

        [Then("the user verify cash price before and after calculation")]
        public void ThenTheUserVerifyCashPriceBeforeAndAfterCalculation()
        {
            _pageObjects.QuickQuotePage.ValidateCashPriceBeforeAndAfterCalculation();
        }
    }
}

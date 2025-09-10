using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V136.Network;
using UDC.UDC.Core;

namespace UDC.POM.DOPages
{
    public class QuickQuotePage : BasePage
    {
        public QuickQuotePage(IWebDriver driver) : base(driver) { }
        private IWebElement productDropdown => Find(By.XPath("//label[text()='Product']/following-sibling::div/descendant::span"));
        private IWebElement programDropdown => Find(By.XPath("//label[text()='Program']/following-sibling::div/descendant::span"));
        private IWebElement calculateFor => Find(By.XPath("//label[text()='Calculate For']/following-sibling::span"));
        private IWebElement firstQuoteCalculateForDropdown => Find(By.XPath("//label[text()='Calculate For']/following-sibling::div/descendant::span"));
        private IWebElement cashPriceElement => Find(By.XPath("//label[text()='Cash Price']/following-sibling::div/child::input"));
        private IWebElement depositElement => Find(By.XPath("//label[text()='Deposit']/following-sibling::div/descendant::input"));
        private IWebElement interestRate => Find(By.XPath("//label[text()='Interest Rate %']/following-sibling::div/descendant::input"));
        private IWebElement termDropdown => Find(By.XPath("//label[text()='Terms (Months)']/parent::div/descendant::div[contains(@class,'p-dropdown')]/child::span"));
        private IWebElement term => Find(By.XPath("//label[text()='Terms (Months)']/following-sibling::div[@class='col-5 ng-star-inserted']//input"));
       
        private IWebElement frequencyDropdown => Find(By.XPath("//label[text()='Frequency']/parent::div/descendant::div[contains(@class,'p-dropdown')]/child::span"));
        private IWebElement payment => Find(By.XPath("//label[text()='Payment']/following-sibling::span"));
        private IWebElement balloonPercentage => Find(By.XPath("//label[text()='Balloon']/following-sibling::div/descendant::input"));
        private IWebElement balloonAmount => Find(By.XPath("//label[text()='Balloon']/following::div[@class='col-4 ng-star-inserted']/descendant::input"));
        private IWebElement calculateButton => Find(By.XPath("//span[text()='Calculate']"));
        private IWebElement AddComparisonButton => Find(By.XPath("//span[text()='Add Comparison 2']"));
        private IWebElement SecondProgramDropdown => Find(By.XPath("(//label[text()='Program']/following-sibling::div/descendant::span)[2]"));

        private IWebElement SecondQuoteCalculateButton => Find(By.XPath("//label[text()=' Quick Quote 2']/following::span[text()='Calculate']"));
        private IWebElement productDropdown2 => Find(By.XPath("(//label[text()='Product']/following-sibling::div/descendant::span)[2]"));
        private IWebElement calculateFor2 => Find(By.XPath("(//label[text()='Calculate For']/following-sibling::span)[2]"));
        private IWebElement secondQuoteCalculateForDropdown => Find(By.XPath("(//label[text()='Calculate For']/following-sibling::div/descendant::span)[2]"));
        private IWebElement cashPriceElement2 => Find(By.XPath("(//label[text()='Cash Price']/following-sibling::div/child::input)[2]"));
        private IWebElement depositElement2 => Find(By.XPath("(//label[text()='Deposit']/following-sibling::div/descendant::input)[2]"));
        private IWebElement interestRate2 => Find(By.XPath("(//label[text()='Interest Rate %']/following-sibling::div/descendant::input)[2]"));
        private IWebElement secondQuoteTerm => Find(By.XPath("(//label[text()='Terms (Months)']/following-sibling::div[@class='col-5 ng-star-inserted']//input)[2]"));
        private IWebElement SecondTermDropdown => Find(By.XPath("(//label[text()='Terms (Months)']/parent::div/descendant::div[contains(@class,'p-dropdown')]/child::span)[2]"));
        private IWebElement frequencyDropdown2 => Find(By.XPath("(//label[text()='Frequency']/parent::div/descendant::div[contains(@class,'p-dropdown')]/child::span)[2]"));
        private IWebElement secondQuotepayment => Find(By.XPath("(//label[text()='Payment']/following-sibling::div//input)[1]"));
        private IWebElement SecondQuoteballoonPercentage => Find(By.XPath("(//label[text()='Balloon']/following-sibling::div/descendant::input)[2]"));
        private IWebElement SecondQuoteballoonAmount => Find(By.XPath("(//input[@id='amount'])[12]"));
        private IWebElement AddComparisonThreeButton => Find(By.XPath("//span[text()='Add Comparison 3']"));
        private IWebElement thirdProgramDropdown => Find(By.XPath("(//label[text()='Program']/following-sibling::div/descendant::span)[3]"));
        private IWebElement thirdproductDropdown => Find(By.XPath("(//label[text()='Product']/following-sibling::div/descendant::span)[3]"));
        private IWebElement thirdCalculateFor => Find(By.XPath("(//label[text()='Calculate For']/following-sibling::div/descendant::span)[3]"));
        private IWebElement thirdcashPriceElement => Find(By.XPath("(//label[text()='Cash Price']/following-sibling::div/child::input)[3]"));
        private IWebElement thirdInterestRate => Find(By.XPath("(//label[text()='Interest Rate %']/following-sibling::div/descendant::input)[3]"));
        private IWebElement thirdTermDropdown => Find(By.XPath("(//label[text()='Terms (Months)']/parent::div/descendant::div[contains(@class,'p-dropdown')]/child::span)[3]"));
        private IWebElement thirdFrequencyDropdown => Find(By.XPath("(//label[text()='Frequency']/parent::div/descendant::div[contains(@class,'p-dropdown')]/child::span)[3]"));
       
        private IWebElement quoteOneCashPriceErrorMsg => Find(By.XPath("//small[text()='This field cannot be blank']"));
        private IWebElement quoteOneInterestRateErrorMsg => Find(By.XPath("//small[text()='This field cannot be blank']"));
        private IWebElement calculateForDropdown => Find(By.XPath("(//label[text()='Calculate For']/following-sibling::div/descendant::span)[2]"));
        private IWebElement calculateForDropdownQuoteThree => Find(By.XPath("(//label[text()='Calculate For']/following-sibling::div/descendant::span)[3]"));
        private IWebElement thirdQuoteCalculateButton => Find(By.XPath("//label[text()=' Quick Quote 3']/following::span[text()='Calculate']"));
        private IWebElement buttonCreateQuote => Find(By.XPath("//span[contains(text(),'Create Quote')]"));

        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");
        public void SelectProgramDropDown(string value)
        {
            WaitTillTheLoadSpinnerDisappears(15);
            dropdown.SelectCustomDropdown(programDropdown, value, optionsLocator);
        }
        public void SelectProductDropdown(string value)
        {
            WaitTillTheLoadSpinnerDisappears(10);
            dropdown.SelectCustomDropdown(productDropdown, value, optionsLocator);
        }
        public void EnterCashPrice(string value)
        {
            cashPriceElement.Clear();
            cashPriceElement.SendKeys(Keys.Backspace);
            WaitTillTheLoadSpinnerDisappears(10);
            SetImplicitWait(5);
            cashPriceElement.SendKeys(value);
        }
        public void EnterSecondQuoteCashPrice(string value)
        {
            cashPriceElement2.Clear();
            cashPriceElement2.SendKeys(Keys.Backspace);
            SetImplicitWait(10);
            cashPriceElement2.SendKeys(value);
        }
        public void EnterDeposit(string value)
        {
            depositElement.Clear();
            depositElement.SendKeys(value);
        }
        public void EnterDepositSecondQuote(string value)
        {
            depositElement2.Clear();
            depositElement2.SendKeys(value);
        }
        public void EnterInterestRate(string value)
        {
            interestRate.Clear();
            interestRate.SendKeys(value);
        }
        public void EnterSecondQuoteInterestRate(string value)
        {
            interestRate2.Clear();
            interestRate2.SendKeys(Keys.Backspace);
            interestRate2.SendKeys(value);
        }
        public void EnterBalloon(string value)
        {
            balloonPercentage.Clear();
            balloonPercentage.SendKeys(value);
        }
        public void ClickOnCalculateButton()
        {
            calculateButton.Click();
            WaitTillTheLoadSpinnerDisappears(15);
            SetImplicitWait(10);
            ReportingManager.AddScreenshotToReport("Quick Quote screenshot captured successfully.");
            MoveToElement(buttonCreateQuote);
        }
        public void ClickOnSecondQuoteCalculateButton()
        {
            WaitTillTheLoadSpinnerDisappears(10);
            WaitForElementToBeClickable(By.XPath("//label[text()=' Quick Quote 2']/following::span[text()='Calculate']"), 10);
            SecondQuoteCalculateButton.Click();
        }
        public void SelectTermDropdown(string value)
        {
            MoveToElement(frequencyDropdown);            
        }
        public void SelectFrequencyDropdown(string value)
        {
            dropdown.SelectCustomDropdown(frequencyDropdown, value, optionsLocator);
        }
        public Dictionary<string, string> GetFieldValues()
        {
            var values = new Dictionary<string, string>();

            values["program"] = programDropdown.Text.Trim();
            values["product"] = productDropdown.Text.Trim();
            values["Calculate For"] = firstQuoteCalculateForDropdown.Text.Trim();
            values["Cash Price"] = cashPriceElement.GetAttribute("value")?.Trim();
            values["Interest Rate "] = interestRate.GetAttribute("value")?.Trim();
            values["frequency"] = frequencyDropdown.Text.Trim();
            //values["term"] = term.GetAttribute("value")?.Trim();
            //values["Payment"] = payment.Text.Trim();
            return values;
        }
        public Dictionary<string, string> GetAddcomaparisonFieldValues()
        {
            var values = new Dictionary<string, string>();
            values["program"] = SecondProgramDropdown.Text.Trim();
            values["product"] = productDropdown2.Text.Trim();
            values["Calculate For"] = secondQuoteCalculateForDropdown.Text.Trim();
            values["Cash Price"] = cashPriceElement2.GetAttribute("value")?.Trim();
            values["Interest Rate "] = interestRate2.GetAttribute("value")?.Trim();
            values["frequency"] = frequencyDropdown2.Text.Trim();
            //values["term"] = secondQuoteTerm.GetAttribute("value")?.Trim();
            //values["Payment"] = secondQuotepayment.Text.Trim();
            return values;
        }
        public Dictionary<string, string> GetAddcomaparisonThreeFieldValues()
        {
            var values = new Dictionary<string, string>();
            values["program"] = thirdProgramDropdown.Text.Trim();
            values["product"] = thirdproductDropdown.Text.Trim();
            values["Calculate For"] = thirdCalculateFor.Text.Trim();
            values["Cash Price"] = thirdcashPriceElement.GetAttribute("value")?.Trim();
            values["Interest Rate "] = thirdInterestRate.GetAttribute("value")?.Trim();
            values["frequency"] = thirdFrequencyDropdown.Text.Trim();
            //values["term"] = ter3.GetAttribute("value")?.Trim();
            //values["Payment"] = thirdQuotepayment.Text.Trim();
            return values;
        }
        public void IsAddComparisonButtonEnabled()
        {
            bool isEnabled = AddComparisonButton.Enabled;
            if (isEnabled)
            {
                ReportingManager.LogPass("Add Comparison2 Button is Enabled successfully");
                AddComparisonButton.Click();
            }
            else
            {
                ReportingManager.LogPass("Add Comparison2 Button is disabled");
            }
        }
        public void IsAddComparisonButtonThreeEnabled()
        {
            bool isEnabled = AddComparisonThreeButton.Enabled;
            if (isEnabled)
            {
                WaitTillTheLoadSpinnerDisappears(15);
                SafeClick(AddComparisonThreeButton);
                ReportingManager.LogPass("Add Comparison3 Button is Enabled successfully");
            }
            else
            {
                ReportingManager.LogFail("Add Comparison3 Button is disabled");
            }
        }
        public void SelectSecondQuoteProgramDropDown(string value)
        {
            ScrollIntoView(SecondProgramDropdown);
            dropdown.SelectCustomDropdown(SecondProgramDropdown, value, optionsLocator);
            SetImplicitWait(10);
        }
        public string CashPrice()
        {
            string actualCashPrice = cashPriceElement.GetAttribute("value")?.Trim();
            return actualCashPrice;
        }
        public string CashPriceErrorMsg()
        {
            cashPriceElement.Clear();
            cashPriceElement.SendKeys(Keys.Backspace);
            string cashPriceErrorMsg = quoteOneCashPriceErrorMsg.Text.Trim();
            return cashPriceErrorMsg;
        }
        public string InterestRateErrorMsg()
        {
            interestRate.Clear();
            interestRate.SendKeys(Keys.Backspace);
            interestRate.SendKeys(Keys.Enter);
            string interestRateErrorMsg = quoteOneInterestRateErrorMsg.Text.Trim();
            return interestRateErrorMsg;
        }
        public void SelectCalculateForDropdown(string value)
        {
            WaitTillTheLoadSpinnerDisappears(10);
            dropdown.SelectCustomDropdown(calculateForDropdown, value, optionsLocator);
        }
        public void SelectCalculateForDropdownQuoteThree(string value)
        {
            WaitTillTheLoadSpinnerDisappears(10);
            dropdown.SelectCustomDropdown(calculateForDropdownQuoteThree, value, optionsLocator);
        }

        public string ValidateBalloonAmountIsReadonly()
        {
            bool isEnabled = SecondQuoteballoonAmount.Enabled;

            if (!isEnabled)
            {
                ReportingManager.LogFail("Balloon Amount Field is editable");
                throw new Exception("Balloon Amount field is editable");
            }
            else
            {
                ReportingManager.LogPass("Balloon Amount Field is Read-only");
                return "Balloon Amount Field is Read-only";
            }
        }
        public Dictionary<string, string> BeforeCashPrice()
        {
            var values = new Dictionary<string, string>();
            values["cashprice"] = cashPriceElement.Text.Trim();
            return values;
        }
        public Dictionary<string, string> AfterCashPrice()
        {
            var values = new Dictionary<string, string>();
            values["cashprice"] = cashPriceElement.Text.Trim();
            return values;
        }
      
        public void ValidateBalloonAmountBeforeAndAfterCalculation()
        {
            string balloonAmountBeforeCalculation = SecondQuoteballoonAmount.GetAttribute("value")?.Trim();

            Dictionary<string, string> balloonAmountValues = new Dictionary<string, string>
            {
                { "BeforeCalculation", balloonAmountBeforeCalculation }
            };
            SecondQuoteCalculateButton.Click();
            WaitTillTheLoadSpinnerDisappears(10);

            string balloonAmountAfterCalculation = SecondQuoteballoonAmount.GetAttribute("value")?.Trim();

            balloonAmountValues["AfterCalculation"] = balloonAmountAfterCalculation;

            if (balloonAmountValues["BeforeCalculation"] == balloonAmountValues["AfterCalculation"])
            {
                ReportingManager.LogFail("Balloon Amount did not change after calculation.");
                throw new Exception("Balloon Amount did not update as expected.");
            }
            else
            {
                ReportingManager.LogPass("Balloon Amount is successfully updated after calculation");
            }
        }
        public void ValidateCashPriceBeforeAndAfterCalculation()
        {
            string cashPriceBeforeCalculation = thirdcashPriceElement.GetAttribute("value")?.Trim();

            Dictionary<string, string> cashPriceValues = new Dictionary<string, string>
            {
                { "BeforeCalculation", cashPriceBeforeCalculation }
            };

            thirdQuoteCalculateButton.Click();
            WaitTillTheLoadSpinnerDisappears(10);

            string cashPriceAfterCalculation = thirdcashPriceElement.GetAttribute("value")?.Trim();

            cashPriceValues["AfterCalculation"] = cashPriceAfterCalculation;
            if (cashPriceValues["BeforeCalculation"] == cashPriceValues["AfterCalculation"])
            {
                ReportingManager.LogFail("Cash Price did not change after calculation.");
                throw new Exception("Cash Price did not update as expected.");
            }
            else
            {
                ReportingManager.LogPass("Cash Price is successfully updated after calculation.");
            }
            ReportingManager.AddScreenshotToReport("Quick Quote3 screen shot is captured successfully.");
        }
        public void ValidateCashPriceIsReadonly()
        {
            bool isEnabled = cashPriceElement.Enabled;

            if (!isEnabled)
            {
                ReportingManager.LogFail("Cash Price Field is editable");
                throw new Exception("Cash Price field is editable");
            }
            else
            {
                ReportingManager.LogPass("Cash Price Field is Read-only (not editable)");
            }
        }

        public void ClickOnCreateQuoteButton()
        {
            buttonCreateQuote.Click();
            WaitTillTheLoadSpinnerDisappears();
        }
    }
}

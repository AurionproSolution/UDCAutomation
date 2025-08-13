using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoAddAssetPage : BasePage
    {
        public DoAddAssetPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement enterAssetValue => Find(By.XPath("//div[@class='w-8 ng-star-inserted']//input[@id='amount']"));
        private IWebElement enterYear => Find(By.XPath("//label[text()='Year']/following-sibling::div//input"));
        private IWebElement enterMake => Find(By.XPath("//label[text()='Make']/following-sibling::div//input"));
        private IWebElement enterModel => Find(By.XPath("//label[text()='Model']/following-sibling::div//input"));
        private IWebElement enterVariant => Find(By.XPath("//label[text()='Variant']/following-sibling::div//input"));
        private IWebElement enterRegoNo => Find(By.XPath("//label[text()='Rego No.']/following-sibling::div//input"));
        private IWebElement enterVinNo => Find(By.XPath("//label[text()='VIN']/following-sibling::div//input"));
        private IWebElement enterOdometer => Find(By.XPath("//label[text()='Odometer']/following-sibling::div//input"));
        private IWebElement enterSerialChassisNo => Find(By.XPath("//label[normalize-space()='Serial / Chassis No.']/following-sibling::div//input"));
        private IWebElement enterPolicyNumber => Find(By.XPath("//label[normalize-space()='Policy Number']/following-sibling::div//input"));

        public void ClickOnAssetValue(string value)
        {
            enterAssetValue.Clear();
            enterAssetValue.SendKeys(value);
            ReportingManager.LogPass("Entered Asset Value: " + value);
        }
        public void EnterYear(string value)
        {
            enterYear.Clear();
            enterYear.SendKeys(value);
            ReportingManager.LogPass("Entered Year: " + value);
        }
        public void EnterMake(string value)
        {
            enterMake.Clear();
            enterMake.SendKeys(value);
            ReportingManager.LogPass("Entered Make: " + value);
        }
        public void EnterModel(string value)
        {
            enterModel.Clear();
            enterModel.SendKeys(value);
            ReportingManager.LogPass("Entered Model: " + value);
        }
        public void EnterVariant(string value)
        {
            enterVariant.Clear();
            enterVariant.SendKeys(value);
            ReportingManager.LogPass("Entered Variant: " + value);
        }
        public void EnterRegoNo(string value)
        {
            enterRegoNo.Clear();
            enterRegoNo.SendKeys(value);
            ReportingManager.LogPass("Entered Rego No.: " + value);
        }
        public void EnterVinNo(string value)
        {
            enterVinNo.Clear();
            enterVinNo.SendKeys(value);
            ReportingManager.LogPass("Entered VIN: " + value);
        }
        public void EnterOdometer(string value)
        {
            enterOdometer.Clear();
            enterOdometer.SendKeys(value);
            ReportingManager.LogPass("Entered Odometer: " + value);
        }
        public void EnterSerialChassisNo(string value)
        {
            enterSerialChassisNo.Clear();
            enterSerialChassisNo.SendKeys(value);
            ReportingManager.LogPass("Entered Serial / Chassis No.: " + value);
        }
        public void EnterPolicyNumber(string value)
        {
            enterPolicyNumber.Clear();
            enterPolicyNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Policy Number: " + value);
        }
    }
}

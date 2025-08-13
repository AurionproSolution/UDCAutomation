using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoContractSummary : BasePage
    {
        public DoContractSummary(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement submitButton => Find(By.XPath("//span[normalize-space()='Submit']"));
        public void ClickOnSubmitButton()
        {
            submitButton.Click();
            ReportingManager.LogPass("Clicked on Submit Button");
        }
    }
}

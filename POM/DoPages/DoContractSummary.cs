using DocumentFormat.OpenXml.Bibliography;
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
        private IWebElement privacyAutorizationCheckBox => Find(By.XPath("/html/body/p-dynamicdialog/div/div/div[2]/app-dealer-udc-declaration/div[1]/p-checkbox/div/div[2]"));
        private IWebElement financialAdviceDiscloureStatement => Find(By.XPath("/html/body/p-dynamicdialog/div/div/div[2]/app-dealer-udc-declaration/div[2]/p-checkbox/div/div[2]"));
        private IWebElement proceedButton => Find(By.XPath("//span[contains(text(),'Proceed')]"));
        private IWebElement applicationSubmitMessageLabel => Find(By.XPath("//label[contains(text(),'Your Application Submitted Sucessfully!')]"));
        public void ClickOnSubmitButton()
        {
            MoveToElement(submitButton);
            submitButton.Click();
            ReportingManager.LogPass("Clicked on Submit Button");
        }

        public void AcceptOriginatorDeclaration()
        {
            Thread.Sleep(3000);
          
            ClickElementUsingJavaScript(privacyAutorizationCheckBox);
            Thread.Sleep(1000);
          
            ClickElementUsingJavaScript(financialAdviceDiscloureStatement);
            Thread.Sleep(1000);
            ClickElementUsingJavaScript(proceedButton);
            WaitTillTheLoadSpinnerDisappears();
        }

        public void VerifyApplicationSubmit()
        {
            bool labelApplicationSubmitMessage= applicationSubmitMessageLabel.Displayed;

            if (labelApplicationSubmitMessage)
            {
                ReportingManager.LogInfo("Your Application Submitted Sucessfully! display");
                ReportingManager.AddScreenshotToReport("Your Application Submitted Sucessfully! display");
            }
            else 
            {
                ReportingManager.LogFail("Your Application Submitted Sucessfully! is not display");
                ReportingManager.AddScreenshotToReport("\"Your Application Submitted Sucessfully! is not display");
            }

        }
    }
}

using DocumentFormat.OpenXml.Presentation;
using OpenQA.Selenium;
using UDC.StepDefinitions.CssStepDefinations;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoAssetAndInsuranceSummaryPage : BasePage
    {
        
      //  private Dictionary<string, string> AssetDetailsDataModel;
        public DoAssetAndInsuranceSummaryPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement assetEditButton => Find(By.XPath("//i[@class='cursor-pointer fa-pen-to-square fa-regular ng-star-inserted']"));
        private IWebElement assetCopyButton => Find(By.XPath("//i[@class='cursor-pointer fa-clone fa-regular ng-star-inserted']"));
        private IWebElement assetDeleteButton => Find(By.XPath("//i[@class='cursor-pointer fa-regular fa-trash-can ng-star-inserted']"));
        private IWebElement searchAndAddAssetButton => Find(By.XPath("//span[normalize-space()='Search & Add Asset']"));
        private IWebElement searchAndAddTradeInButton => Find(By.XPath("//span[normalize-space()='Search & Add Trade in']"));
        private IWebElement makeTextbox => Find(By.XPath("//label[contains(text(),'Make')]//following::input"));
        private IWebElement modelTextbox => Find(By.XPath("//label[contains(text(),'Model')]//following::input"));
        private IWebElement variantTextbox => Find(By.XPath("//label[contains(text(),'Variant')]//following::input"));
        private IWebElement regoNoTextbox => Find(By.XPath("//label[contains(text(),'Rego No.')]//following::input"));
        private IWebElement vinTextbox => Find(By.XPath("//label[contains(text(),'VIN')]//following::input"));
        private IWebElement serialchasisNoTextbox => Find(By.XPath("//label[contains(text(),'Serial / Chassis No.')]//following::input"));
        private IWebElement policyNumberTextBox=> Find(By.XPath("//label[contains(text(),'Policy Number')]//following::input")); 
        private IWebElement submitButton => Find(By.XPath("//span[contains(text(),'Submit')]"));
        private IWebElement assetCloseButton => Find(By.XPath("//span[contains(text(),'Asset & Insurance Summary')]//following::button"));
       // private readonly DO_PageObjectContainer _pageObjects = new DO_PageObjectContainer();
        public void ClickAssetEditButton()
        {
            assetEditButton.Click();
            WaitTillTheLoadSpinnerDisappears();
            ReportingManager.LogPass("Clicked on Asset Edit Button");
        }

        public void EnterAssetDetails()
        {
            EntreMakeText("Tata Motors");
            EntreModelText("Altroz");
            EntreVariantText("XZ");
            EntreTexRegoNo("123456");
            EntreVINNumberText("12345678912345678");
            EntreSerialChassisNoText("123456");
            EntrePolicyNumberText("9876543");
            submitButton.Click();
        }

        public void ClickOnSubmitButton()
        {
            submitButton.Click();
            WaitTillTheLoadSpinnerDisappears();
        }

        public void ClickOnAssetCloseButton()
        {
            WaitTillTheLoadSpinnerDisappears();
            assetCloseButton.Click();
        }

        public void EntreMakeText(string value)
        {
            makeTextbox.SendKeys(value);
            ReportingManager.LogInfo("Entre Make Text : "+ value);
        }

        public void EntreModelText(string value)
        {
            modelTextbox.SendKeys(value);
            ReportingManager.LogInfo("Entre Model Text : "+ value);
        }

        public void EntreVariantText(string value)
        {
            variantTextbox.SendKeys(value);
            ReportingManager.LogInfo("Entre  Variant Text : " + value);
        }

        public void EntreTexRegoNo(string value)
        {
            regoNoTextbox.SendKeys(value);
            ReportingManager.LogInfo("Entre Rego No Text : " + value);
        }

        public void EntreVINNumberText(string value)
        {
            vinTextbox.SendKeys(value);
            ReportingManager.LogInfo("Entre VINNumber Text : " + value);
        }

        public void EntreSerialChassisNoText(string value)
        {
            serialchasisNoTextbox.SendKeys(value);
            ReportingManager.LogInfo("Entre SerialChassisNo Text : " + value);
        }

        public void EntrePolicyNumberText(string value)
        {
            policyNumberTextBox.SendKeys(value);
            ReportingManager.LogInfo("Entre PolicyNumber Text : " + value);
        }

    }
}

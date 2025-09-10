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
        private readonly DO_PageObjectContainer _pageObjects = new DO_PageObjectContainer();
        public void ClickAssetEditButton()
        {
            assetEditButton.Click();
            WaitTillTheLoadSpinnerDisappears();
            ReportingManager.LogPass("Clicked on Asset Edit Button");
        }

        public void EnterAssetDetails()
        {
            EntreMakeText();
            EntreModelText();
            EntreVariantText();
            EntreTexRegoNo();
            EntreVINNumberText();
            EntreSerialChassisNoText();
            EntrePolicyNumberText();
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

        public void EntreMakeText()
        {
            makeTextbox.SendKeys(_pageObjects.AssetDetailsTestData.Make);
            ReportingManager.LogInfo("Entre Make Text : " + _pageObjects.AssetDetailsTestData.Make);
        }

        public void EntreModelText()
        {
            modelTextbox.SendKeys(_pageObjects.AssetDetailsTestData.Model);
            ReportingManager.LogInfo("Entre Model Text : " + _pageObjects.AssetDetailsTestData.Model);
        }

        public void EntreVariantText()
        {
            variantTextbox.SendKeys(_pageObjects.AssetDetailsTestData.Variant);
            ReportingManager.LogInfo("Entre  Variant Text : " + _pageObjects.AssetDetailsTestData.Variant);
        }

        public void EntreTexRegoNo()
        {
            regoNoTextbox.SendKeys(_pageObjects.AssetDetailsTestData.RegoNo);
            ReportingManager.LogInfo("Entre Rego No Text : " + _pageObjects.AssetDetailsTestData.RegoNo);
        }

        public void EntreVINNumberText()
        {
            vinTextbox.SendKeys(_pageObjects.AssetDetailsTestData.VINNumber);
            ReportingManager.LogInfo("Entre VINNumber Text : " + _pageObjects.AssetDetailsTestData.VINNumber);
        }

        public void EntreSerialChassisNoText()
        {
            serialchasisNoTextbox.SendKeys(_pageObjects.AssetDetailsTestData.SerialChassisNo);
            ReportingManager.LogInfo("Entre SerialChassisNo Text : " + _pageObjects.AssetDetailsTestData.SerialChassisNo);
        }

        public void EntrePolicyNumberText()
        {
            policyNumberTextBox.SendKeys(_pageObjects.AssetDetailsTestData.PolicyNumber);
            ReportingManager.LogInfo("Entre PolicyNumber Text : " + _pageObjects.AssetDetailsTestData.PolicyNumber);
        }

    }
}

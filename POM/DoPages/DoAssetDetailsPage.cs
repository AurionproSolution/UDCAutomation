using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoAssetDetailsPage : BasePage
    {
        public DoAssetDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement productEle => Find(By.XPath("(//div[@class='p-dropdown p-component p-inputwrapper']//span[@role='combobox'])[1]"));
        private IWebElement programEle => Find(By.XPath("(//div[@class='p-dropdown p-component p-inputwrapper']//span[@role='combobox'])[2]"));
        private IWebElement assetTypeEle => Find(By.XPath("//input[@placeholder='Asset Type']"));
        private IWebElement selectConditionEle => Find(By.XPath("//span[@aria-label='New']"));
        private IWebElement term => Find(By.XPath("//label[text()='Term']/following-sibling::div//input"));
        private IWebElement selectFrequency => Find(By.XPath("//label[text()='Frequency']/following-sibling::div//span"));
        private IWebElement enterInterestRate => Find(By.XPath("//percentage//input[@class='p-inputtext p-component p-element p-inputnumber-input p-filled']"));
        private IWebElement clickOnCalculateBtn => Find(By.XPath("//span[text()='Calculate']"));
        private IWebElement cashPriceOfAsset => Find(By.XPath("//label[normalize-space()='Cash Price of Asset']//following-sibling::div//input"));
        private IWebElement originatorRef => Find(By.XPath("//label[normalize-space()='Originator Reference']//following-sibling::div//input"));
        private IWebElement assetInsTradeInHLink => Find(By.XPath("//span[normalize-space()='Asset, Insurance & Trade-in Summary >']"));
        private IWebElement cancelButton => Find(By.XPath("//timesicon[@class='p-element p-icon-wrapper ng-tns-c4033847114-34 ng-star-inserted']//*[name()='svg']"));
        private IWebElement KeyInfoDisCancelButton => Find(By.XPath("//timesicon[@class='p-element p-icon-wrapper ng-tns-c4033847114-56 ng-star-inserted']//*[name()='svg']"));
        private IWebElement KeyInformationDisclosureButton => Find(By.XPath("//label[normalize-space()='Key Information Disclosure >']"));
        private IWebElement NextButton => Find(By.XPath("//span[contains(text(),'Next')]"));
        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");

        public void SelectProduct(string value)
        {
            dropdown.SelectCustomDropdown(productEle, value, optionsLocator);
        }
        public void SelectProgram(string value)
        {
            dropdown.SelectCustomDropdown(programEle, value, optionsLocator);
        }
        public void SelectAssetType(string value)
        {
            dropdown.SelectCustomDropdown(assetTypeEle, value, optionsLocator);
        }
        public void SelectCondition(string value)
        {
            dropdown.SelectCustomDropdown(selectConditionEle, value, optionsLocator);
        }

        public void EnterTerm(string value)
        {
            term.Clear();
            term.SendKeys(value);
        }
        public void SelectFrequency(string value)
        {
            dropdown.SelectCustomDropdown(selectFrequency, value, optionsLocator);
        }
        public void EnterInterestRate(string value)
        {
            enterInterestRate.Clear();
            enterInterestRate.SendKeys(value);
        }
        public void ClickOnCalculateButton()
        {
            MoveToElement(clickOnCalculateBtn);
            clickOnCalculateBtn.Click();
        }
        public void EnterCashPriceOfAsset(string value)
        {
            cashPriceOfAsset.Clear();
            cashPriceOfAsset.SendKeys(value);
        }
        public void EnterOriginatorRef(string value)
        {
            originatorRef.Clear();
            originatorRef.SendKeys(value);
        }
        public void ClickOnAssetInsTradeInHLink()
        {
            ScrollAndClickElement(assetInsTradeInHLink);
            ReportingManager.LogPass("Clicked on Asset, Insurance & Trade-in Summary link");
        }
        public void ClickOnCancelButton()
        {
            cancelButton.Click();
            ReportingManager.LogPass("Clicked on Cancel Button");
        }
        public void ClickOnKeyInformationDisclosureButton()
        {
            KeyInformationDisclosureButton.Click();
            ReportingManager.LogPass("Clicked on Key Information Disclosure Button");
        }
        public void ClickOnKeyInfoDisCancelButton()
        {
            KeyInfoDisCancelButton.Click();
            ReportingManager.LogPass("Clicked on Key Information Disclosure Cancel Button");
        }

        public void ClickOnNextButton()
        {
            MoveToElement(NextButton);
            NextButton.Click();
            WaitTillTheLoadSpinnerDisappears();
            ReportingManager.LogPass("Clicked on Next Button");
        }

    }
}

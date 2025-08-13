using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoAssetAndInsuranceSummaryPage : BasePage
    {
        public DoAssetAndInsuranceSummaryPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement assetEditButton => Find(By.XPath("//i[@class='cursor-pointer fa-pen-to-square fa-regular ng-star-inserted']"));
        private IWebElement assetCopyButton => Find(By.XPath("//i[@class='cursor-pointer fa-clone fa-regular ng-star-inserted']"));
        private IWebElement assetDeleteButton => Find(By.XPath("//i[@class='cursor-pointer fa-regular fa-trash-can ng-star-inserted']"));
        private IWebElement searchAndAddAssetButton => Find(By.XPath("//span[normalize-space()='Search & Add Asset']"));
        private IWebElement searchAndAddTradeInButton => Find(By.XPath("//span[normalize-space()='Search & Add Trade in']"));

        public void ClickAssetEditButton()
        {
            assetEditButton.Click();
            ReportingManager.LogPass("Clicked on Asset Edit Button");
        }

    }
}

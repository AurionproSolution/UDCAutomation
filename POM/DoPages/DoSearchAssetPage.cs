using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UDC.POM.DoPages
{
    public class DoSearchAssetPage : BasePage
    {
        public DoSearchAssetPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement motorCheckRadioButton => Find(By.XPath("//label[normalize-space()='Motocheck']"));
        private IWebElement dealerInventoryRadioButton => Find(By.XPath("//label[normalize-space()='Dealer Inventory']"));
        private IWebElement selectSearchBy => Find(By.XPath("(//div[@class='p-dropdown p-component p-inputwrapper']//span[@role='combobox'])[4]"));
        private IWebElement enterNumber => Find(By.XPath("//div[@class='col-3 ng-star-inserted']//input[@id='text']"));
        private IWebElement searchButton => Find(By.XPath("//p-button[@class='p-element pointer text-semi-bold ng-star-inserted']//button[@type='button']"));
        private IWebElement resetButton => Find(By.XPath("//span[normalize-space()='Reset']"));
        private IWebElement addAsset => Find(By.XPath("//span[normalize-space()='Add Asset']"));

    }
}

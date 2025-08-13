using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DOPages
{
    public class DoDashboardPage : BasePage
    {
        public DoDashboardPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement createStandardQuote => Find(By.XPath("//span[normalize-space()='+ Create Standard Quote']"));
        private IWebElement selectCSA => Find(By.XPath("//a[normalize-space()='Credit Sale Agreement']"));

        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");

        public void ClickCreateStandardQuote()
        {
            createStandardQuote.Click();
        }
        public void SelectCSA()
        {
            selectCSA.Click();
        }

    }
}

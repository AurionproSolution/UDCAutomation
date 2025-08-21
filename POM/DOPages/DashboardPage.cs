using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using UDC.UDC.Core;

namespace UDC.POM.DOPages
{
    public class DashboardPage : BasePage
    {
        public DashboardPage(IWebDriver driver) : base(driver) { }
        private IWebElement createQuickQuoteButton => Find(By.XPath("//span[text()='+ Create Quick Quote']"));
        private IWebElement createQStandardQuoteButton => Find(By.XPath("//span[text()='+ Create Standard Quote']"));
        private IWebElement bellIconButton => Find(By.XPath("//span[contains(@class,'fa-bell swing-icon')]"));
        private IWebElement menuElement => Find(By.XPath("//span[text()='Menu']"));
        private IWebElement dashboardElement => Find(By.XPath("//span[text()='Dashboard']"));
        private IWebElement viewBtn => Find(By.XPath("//span[text()='View']"));
        private IWebElement resetBtn => Find(By.XPath("//span[text()='Reset']"));
        private IWebElement searchQuoteField => Find(By.XPath("//input[@placeholder='Search Quote']"));
        private IWebElement DealerDropdown => Find(By.XPath("(//div[@aria-label='dropdown trigger'])[1]"));

        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");

        public void SelectDealer(string value)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector(".p-progressspinner")));
            WaitTillTheLoadSpinnerDisappears(10);
            //WaitTillTheLoadSpinnerDisappearsAndElementExist(By.XPath("//span[text()='Dealer ']"));
            SetImplicitWait(15);
            dropdown.SelectCustomDropdown(DealerDropdown, value, optionsLocator);
            ReportingManager.LogPass($"Selected dealer is {value}");
        }

        public void ClickOnCreateQuickQuoteButton()
        {
            SetImplicitWait(15);
            WaitTillTheLoadSpinnerDisappears(15);
            createQuickQuoteButton.Click();
            ReportingManager.LogInfo("Click On Create Quick Quote Button");
        }
        public void ClickOnStandardQuickQuoteButton()
        {
            createQStandardQuoteButton.Click();
            ReportingManager.LogInfo("Click On Standard Quick Quote Button");
        }
        public void ClickOnViewBtn()
        {
            viewBtn.Click();
        }
        public void ClickOnResetBtn()
        {
            resetBtn.Click();
        }
        public void SearchQuote(string value)
        {
            searchQuoteField.SendKeys(value);
        }
    }
}

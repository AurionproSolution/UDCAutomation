using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDC.StepDefinitions.CssStepDefinations;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoSearchCustomerPage : BasePage
    {
        private readonly DO_PageObjectContainer _pageObjects;
        public DoSearchCustomerPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement businessRadioButton => Find(By.XPath("//label[normalize-space()='Business']"));
        private IWebElement individualRadioButton => Find(By.XPath("//label[normalize-space()='Individual']"));
        private IWebElement enterTrust => Find(By.XPath("//label[normalize-space()='Trust']"));
        private IWebElement selectSearchBy => Find(By.XPath("(//div[@class='p-dropdown p-component p-inputwrapper']//span[@role='combobox'])[1]"));
        private IWebElement searchButton => Find(By.XPath("//p-button[@class='p-element pointer text-semi-bold ng-star-inserted']//button[@type='button']"));
        private IWebElement trustNameTextBox => Find(By.XPath("//label[contains(text(),'Trust Name')]//following::input"));
        private IWebElement linkAddNewCustomer => Find(By.XPath("//span[contains(text(),'Add New Customer')]"));
        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");
        public void ClickOnBusinessRadioButton()
        {
            businessRadioButton.Click();
            ReportingManager.LogPass("Clicked on Business Radio Button");
        }
        public void ClickOnIndividualRadioButton()
        {
            individualRadioButton.Click();
            ReportingManager.LogPass("Clicked on Individual Radio Button");
        }
        public void ClickOnEnterTrustRadioButton()
        {
            enterTrust.Click();
            ReportingManager.LogPass("Clicked on Trust Radio Button");
        }
        public void ClickOnSelectSearchBy(string option)
        {
            dropdown.SelectCustomDropdown(selectSearchBy, option, optionsLocator);
            ReportingManager.LogPass($"Selected option '{option}' from the '{selectSearchBy.Text}' dropdown.");
        }
        public void ClickOnSearchButton()
        {
            searchButton.Click();
            ReportingManager.LogPass("Clicked on Search Button");
        }

        public void EnterTrustNameInTrustNameField()
        {
            trustNameTextBox.SendKeys("T");
            ReportingManager.LogPass("Enter Trust Name In Trust Name Field");
        }

        public void ClickOnAddNewCustomerLink()
        {
            MoveToElement(linkAddNewCustomer);
            linkAddNewCustomer.Click();
            ReportingManager.LogPass("Click On Add New Customer Link");
            WaitTillTheLoadSpinnerDisappears();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages.DoIndividualPages
{
    public class DoAddressDetailsPage : BasePage
    {
        public DoAddressDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement GpsSearch => Find(By.XPath("//input[@name='physicalSearchValue']"));
        private IWebElement selectResidenceType => Find(By.XPath("//label[text()='Residence Type ']//following-sibling::div/p-dropdown/div"));
        private IWebElement yearsAtAddress => Find(By.XPath("(//input[@aria-valuenow='undefined'])[1]"));
        private IWebElement monthsAtAddress => Find(By.XPath("(//input[@aria-valuenow='undefined'])[2]"));
        private IWebElement reuseForPostalAddress => Find(By.XPath("//div[@class='p-inputswitch p-component']//span[@class='p-inputswitch-slider']"));
        private IWebElement enterBuildingName => Find(By.XPath("(//label[text()='Building Name']//following-sibling::div//input)[1]"));
        private IWebElement selectFloorType => Find(By.XPath("(//label[text()='Floor Type']//following-sibling::div//p-dropdown/div)[1]"));
        private IWebElement enterFloorNumber => Find(By.XPath("(//label[text()='Floor Number']//following-sibling::div//input)[1]"));
        private IWebElement selectUnitType => Find(By.XPath("(//label[text()='Unit Type']//following-sibling::div/p-dropdown/div)[1]"));
        private IWebElement enterUnitNumber => Find(By.XPath("(//label[text()='Unit Number']//following-sibling::div/input)[1]"));
        private IWebElement enterStreetNumber => Find(By.XPath("(//label[text()='Street Number']//following-sibling::div/input)[1]"));
        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");
        public void EnterGpsSearch(string value)
        {
            GpsSearch.Clear();
            GpsSearch.SendKeys(value);
            ReportingManager.LogPass("Entered GPS Search: " + value);
        }
        public void SelectResidenceType(string value)
        {
            dropdown.SelectCustomDropdown(selectResidenceType, value, optionsLocator);
            ReportingManager.LogPass("Selected Residence Type: " + value);
        }
        public void EnterYearsAtAddress(string value)
        {
            yearsAtAddress.Clear();
            yearsAtAddress.SendKeys(value);
            ReportingManager.LogPass("Entered Years at Address: " + value);
        }
        public void EnterMonthsAtAddress(string value)
        {
            monthsAtAddress.Clear();
            monthsAtAddress.SendKeys(value);
            ReportingManager.LogPass("Entered Months at Address: " + value);
        }
        public void ClickOnReuseForPostalAddress()
        {
            reuseForPostalAddress.Click();
            ReportingManager.LogPass("Clicked on Reuse for Postal Address");
        }
        public void EnterBuildingName(string value)
        {
            enterBuildingName.Clear();
            enterBuildingName.SendKeys(value);
            ReportingManager.LogPass("Entered Building Name: " + value);
        }
        public void SelectFloorType(string value)
        {
            dropdown.SelectCustomDropdown(selectFloorType, value, optionsLocator);
            ReportingManager.LogPass("Selected Floor Type: " + value);
        }
        public void EnterFloorNumber(string value)
        {
            enterFloorNumber.Clear();
            enterFloorNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Floor Number: " + value);
        }
        public void SelectUnitType(string value)
        {
            dropdown.SelectCustomDropdown(selectUnitType, value, optionsLocator);
            ReportingManager.LogPass("Selected Unit Type: " + value);
        }
        public void EnterUnitNumber(string value)
        {
            enterUnitNumber.Clear();
            enterUnitNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Unit Number: " + value);
        }
        public void EnterStreetNumber(string value)
        {
            enterStreetNumber.Clear();
            enterStreetNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Street Number: " + value);
        }
    }
}

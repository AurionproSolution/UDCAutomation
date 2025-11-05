using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDC.StepDefinitions.CssStepDefinations;
using UDC.UDC.Core;

namespace UDC.POM.DoPages.DoTrustPages
{
    public class DoTrustAddressDetailsPage : BasePage
    {
        private readonly DO_PageObjectContainer _pageObjects;
        public DoTrustAddressDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement physicalAddressSearchBox=> Find(By.XPath("//label[contains(text(),'Physical Address')]//following::Input"));
        private IWebElement physicalAddressSearchBoxOption => Find(By.XPath("//label[contains(text(),'Physical Address')]//following::li"));
        private IWebElement textBoxTimeAtAddressInYears => Find(By.XPath("(//label[contains(text(),'Time at Address')]//following::input)[1]"));
        private IWebElement textBoxTimeAtAddressInMonths => Find(By.XPath("(//label[contains(text(),'Time at Address')]//following::input)[2]"));
        private IWebElement textBoxFloorNumber => Find(By.XPath("//label[contains(text(),'Floor Number')]//following::input"));
        private IWebElement registerAddressSearchBox => Find(By.XPath("//label[contains(text(),'Registered Address')]//following::Input"));
        private IWebElement registerAddressSearchBoxOption => Find(By.XPath("//label[contains(text(),'Registered Address')]//following::li"));
        private IWebElement textBoxTimeAtAddressInYearsForRegisterAddress => Find(By.XPath("//label[contains(text(),'Registered Address')]//following::label[contains(text(),'Time at Address')]//following::input[1]"));
        private IWebElement textBoxTimeAtAddressInMonthsForRegisterAddress => Find(By.XPath("//label[contains(text(),'Registered Address')]//following::label[contains(text(),'Time at Address')]//following::input[2]"));
        private IWebElement  ButtonNext=> Find(By.XPath("//span[contains(text(),'Next')]"));
        private IWebElement postalAddressSearchBox => Find(By.XPath("(//input[@name='physicalSearchValue'])[2]"));
        private IWebElement postalAddressSearchBoxOption => Find(By.XPath("(//input[@name='physicalSearchValue'])[2]//following::li"));
        private IWebElement postalAddressFloorNumber => Find(By.XPath("(//input[@name='physicalSearchValue'])[2]//following::label[contains(text(),'Floor Number')]//following::input"));
        private IWebElement radioButtonPOBox => Find(By.XPath("//label[contains(text(),'P. O. Box')]//preceding::span[@class='p-radiobutton-icon']"));
        public void EnterAddressDetails()
        {
            physicalAddressSearchBox.SendKeys(_pageObjects.CustomerDetailsTestData.PhysicalAddress);
            ReportingManager.LogInfo("Entre Physical Address : " + _pageObjects.CustomerDetailsTestData.PhysicalAddress);
            Thread.Sleep(5000);
            physicalAddressSearchBoxOption.Click();
            Thread.Sleep(2000);
            textBoxTimeAtAddressInYears.SendKeys(_pageObjects.CustomerDetailsTestData.TimeAtAddressInYears);
            ReportingManager.LogInfo("Entre Time At Address In Years : " + _pageObjects.CustomerDetailsTestData.TimeAtAddressInYears);
            Thread.Sleep(2000);
            textBoxTimeAtAddressInMonths.SendKeys(_pageObjects.CustomerDetailsTestData.TimeAtAddressInMonths);
            ReportingManager.LogInfo("Entre Time At Address In Months : " + _pageObjects.CustomerDetailsTestData.TimeAtAddressInMonths);
            Thread.Sleep(5000);
            textBoxFloorNumber.SendKeys(_pageObjects.CustomerDetailsTestData.FloorNumber);
            ReportingManager.LogInfo("Entre Floor Number : " + _pageObjects.CustomerDetailsTestData.FloorNumber);
            Thread.Sleep(2000);
            MoveToElement(postalAddressSearchBox);
            //radioButtonPOBox.Click();
            Thread.Sleep(2000);
            postalAddressSearchBox.SendKeys(_pageObjects.CustomerDetailsTestData.PostalAddress);
            ReportingManager.LogInfo("Entre Postal Address : " + _pageObjects.CustomerDetailsTestData.PostalAddress);
            Thread.Sleep(2000);
            postalAddressSearchBoxOption.Click();
            Thread.Sleep(5000);
            postalAddressFloorNumber.SendKeys(_pageObjects.CustomerDetailsTestData.PostalAddressFloorNumber);
            ReportingManager.LogInfo("Entre Postal Address Floor Number : " + _pageObjects.CustomerDetailsTestData.PostalAddressFloorNumber);
            Thread.Sleep(2000);
            registerAddressSearchBox.SendKeys(_pageObjects.CustomerDetailsTestData.RegisterAddress);
            ReportingManager.LogInfo("Entre Register Address : " + _pageObjects.CustomerDetailsTestData.RegisterAddress);
            Thread.Sleep(5000);
            registerAddressSearchBoxOption.Click();
            Thread.Sleep(2000); ;
            textBoxTimeAtAddressInYearsForRegisterAddress.SendKeys(_pageObjects.CustomerDetailsTestData.TimeAtAddressInYears);
            ReportingManager.LogInfo("Entre Years For Register Address : " + _pageObjects.CustomerDetailsTestData.TimeAtAddressInYears);
            Thread.Sleep(2000);
            textBoxTimeAtAddressInMonthsForRegisterAddress.SendKeys(_pageObjects.CustomerDetailsTestData.TimeAtAddressInMonths);
            ReportingManager.LogInfo("Entre Months For Register Address : " + _pageObjects.CustomerDetailsTestData.TimeAtAddressInMonths);
            Thread.Sleep(2000);
            MoveToElement(ButtonNext);
            ButtonNext.Click();
            WaitTillTheLoadSpinnerDisappears();
            ReportingManager.AddScreenshotToReport("User Navigate to Address Detasils Page");
        }

    }
}

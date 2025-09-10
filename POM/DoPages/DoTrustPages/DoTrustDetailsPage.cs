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
    public class DoTrustDetailsPage : BasePage
    {
        private readonly DO_PageObjectContainer _pageObjects;
        public DoTrustDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement dropdownTrustType => Find(By.XPath("//label[contains(text(),'Trust Type ')]//following::span[@class='p-element p-dropdown-label p-inputtext p-dropdown-label-empty ng-star-inserted']"));
        private IWebElement dropDownTrustOption => Find(By.XPath("//span[contains(text(),'Trust - Domestic')]"));
        private IWebElement textBoxTrustname => Find(By.XPath("//label[contains(text(),'Trust Name ')]//following::input"));
        private IWebElement textBoxRegisteredNumber => Find(By.XPath("(//label[contains(text(),'Registered Number ')]//following::input)[1]"));
        private IWebElement dropdownPrimaryNatureOfTrust => Find(By.XPath("//label[contains(text(),'Primary Nature Of Trust')]//following::span[@class='p-element p-dropdown-label p-inputtext p-dropdown-label-empty ng-star-inserted']"));

        private IWebElement dropdownPrimaryNatureOfTrustOption => Find(By.XPath("//label[contains(text(),'Primary Nature Of Trust')]//following::li"));
        private IWebElement textBoxTimeTrustInYears => Find(By.XPath("(//label[contains(text(),'Time In Trust')]//following::input)[1]"));
        private IWebElement textBoxTimeTrustInMonths => Find(By.XPath("(//label[contains(text(),'Time In Trust')]//following::input)[2]"));
        private IWebElement contactDetailsBusineesDrodpwn => Find(By.XPath("(//label[contains(text(),'Business')]//following::input)[1]"));
        private IWebElement contactDetailsBusineesTextBox1 => Find(By.XPath("//input[@placeholder='Area code']"));
        private IWebElement contactDetailsBusineesTextBox2 => Find(By.XPath("//input[@placeholder='Phone number']"));
        private IWebElement textBoxEmail => Find(By.XPath("//label[contains(text(),'Email')]//following::input"));
        private IWebElement  ButtonNext=> Find(By.XPath("//span[contains(text(),'Next')]"));

        public void EnterTrustDetails()
        {
            dropdownTrustType.Click();
            Thread.Sleep(1000);
            dropDownTrustOption.Click();
            Thread.Sleep(1000);
            dropdownPrimaryNatureOfTrust.Click();
            Thread.Sleep(1000);
            dropdownPrimaryNatureOfTrustOption.Click();
            Thread.Sleep(1000);
            textBoxTrustname.Clear();
            Thread.Sleep(1000);
            string userName = GenerateRandomwName();
            textBoxTrustname.SendKeys(userName);
            Thread.Sleep(1000);
            textBoxRegisteredNumber.SendKeys(_pageObjects.CustomerDetailsTestData.RegisterNumber);
            ReportingManager.LogInfo("Entre Register Number : " + _pageObjects.CustomerDetailsTestData.RegisterNumber);
            Thread.Sleep(1000);           
            textBoxTimeTrustInYears.SendKeys(_pageObjects.CustomerDetailsTestData.TrustinYears);
            ReportingManager.LogInfo("Entre Time Trust in Years : " + _pageObjects.CustomerDetailsTestData.TrustinYears);
            Thread.Sleep(1000);
            textBoxTimeTrustInMonths.SendKeys(_pageObjects.CustomerDetailsTestData.TrustinMonth);
            ReportingManager.LogInfo("Entre Time Trust in Months : " + _pageObjects.CustomerDetailsTestData.TrustinMonth);
            Thread.Sleep(1000);           
            contactDetailsBusineesDrodpwn.SendKeys(_pageObjects.CustomerDetailsTestData.BusinessContactDetails);
            ReportingManager.LogInfo("Select Business Dropdown  : " + _pageObjects.CustomerDetailsTestData.BusinessContactDetails);
            Thread.Sleep(1000);
            contactDetailsBusineesTextBox1.SendKeys(_pageObjects.CustomerDetailsTestData.BusinessContactDetails1);
            ReportingManager.LogInfo("Select Business Textbox 1   : " + _pageObjects.CustomerDetailsTestData.BusinessContactDetails1);                       
            Thread.Sleep(1000);
            contactDetailsBusineesTextBox2.SendKeys(_pageObjects.CustomerDetailsTestData.Phone);
            ReportingManager.LogInfo("Entre Phone Number : " + _pageObjects.CustomerDetailsTestData.Phone);
            Thread.Sleep(1000);
            textBoxEmail.SendKeys(_pageObjects.CustomerDetailsTestData.Email);
            ReportingManager.LogInfo("Entre Email  : " + _pageObjects.CustomerDetailsTestData.Email);
            Thread.Sleep(1000);
            MoveToElement(ButtonNext);
            ButtonNext.Click();
            WaitTillTheLoadSpinnerDisappears();
        }

        public string GenerateRandomwName()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101); // Generates a number between 1 and 100
            Console.WriteLine("Random number: " + randomNumber);
            string usename = "Test"+ randomNumber.ToString();
            return usename;

        }

    }
}

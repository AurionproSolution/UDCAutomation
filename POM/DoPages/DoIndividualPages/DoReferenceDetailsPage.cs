using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages.DoIndividualPages
{
    public class DoReferenceDetailsPage : BasePage
    {
        public DoReferenceDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement addContactDetailsButton => Find(By.XPath("//span[normalize-space()='Add Contact Details']"));
        public void ClickOnAddContactDetailsButton()
        {
            addContactDetailsButton.Click();
            ReportingManager.LogPass("Clicked on Add Contact Details Button");
        }
    }
}
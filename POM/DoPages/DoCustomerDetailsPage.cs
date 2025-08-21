using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages
{
    public class DoCustomerDetailsPage : BasePage
    {
        public DoCustomerDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement addBorrowerOrGuarantors => Find(By.XPath("//span[normalize-space()='Add Borrowers / Guarantors']"));
        private IWebElement nextButton => Find(By.XPath("//span[normalize-space()='Next']"));

        public void ClickAddBorrowerOrGuarantors()
        {
            addBorrowerOrGuarantors.Click();
            ReportingManager.LogPass("Clicked on Add Borrowers / Guarantors");
        }
        public void ClickNextButton()
        {
            nextButton.Click();
            ReportingManager.LogPass("Clicked on Next Button");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages.DoIndividualPages
{
    public class DoFinancialPositionPage : BasePage
    {
        public DoFinancialPositionPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement enterTakeHomePay => Find(By.XPath("//p-inputnumber[@class='p-element p-inputwrapper p-inputwrapper-filled ng-pristine ng-invalid ng-touched']//input[@role='spinbutton']"));
        public void EnterTakeHomePay(string value)
        {
            enterTakeHomePay.Clear();
            enterTakeHomePay.SendKeys(value);
            ReportingManager.LogPass("Entered Take Home Pay: " + value);
        }


    }
}

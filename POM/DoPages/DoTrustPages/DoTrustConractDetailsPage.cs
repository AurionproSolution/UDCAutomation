using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UDC.POM.DoPages.DoTrustPages
{
    public class DoTrustConractDetailsPage : BasePage
    {
        public DoTrustConractDetailsPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement checkBoxConfirmation=> Find(By.XPath("//label[contains(text(),' I confirm that all customer details are correct.')]//preceding::div[@class='p-checkbox-box']"));
        private IWebElement ButtonSubmit => Find(By.XPath("//span[contains(text(),'Submit')]"));
       
        public void EnterContactDetails()
        {
            MoveToElement(checkBoxConfirmation);
            checkBoxConfirmation.Click();
            Thread.Sleep(200);
            MoveToElement(ButtonSubmit);
            ButtonSubmit.Click();
            WaitTillTheLoadSpinnerDisappears();
        }

    }
}

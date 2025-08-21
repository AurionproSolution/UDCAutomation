using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UDC.POM.DOPages
{
    public class DOLoginPage:BasePage
    {
        public DOLoginPage(IWebDriver driver) : base(driver) { }
        private IWebElement loginWithFisButtonEle => Find(By.XPath("//input[@type='text']"));
    }
}

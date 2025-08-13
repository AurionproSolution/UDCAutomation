using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Math;
using OpenQA.Selenium;

namespace UDC.POM
{
    public class SelectApplicationPage:BasePage
    {
        public SelectApplicationPage(IWebDriver driver) : base(driver) { }
        private IWebElement quotesAndApplicationButton => Find(By.XPath("//div[text()=' Quotes & Applications ']"));
        public void ClickOnQuoteAndApplicationButton()
        {
            Thread.Sleep(8000);
            WaitForPageToLoad(quotesAndApplicationButton);
            ClickElementUsingJavaScript(quotesAndApplicationButton);
            //quotesAndApplicationButton.Click();
        }
    }
}

using OpenQA.Selenium;

namespace UDC.POM.DoPages.DoIndividualPages
{
    public class DoPersonalDetailsPage : BasePage
    {
        public DoPersonalDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement firstName => Find(By.XPath("//label[normalize-space()='First Name']/following-sibling::div//input"));

    }
}

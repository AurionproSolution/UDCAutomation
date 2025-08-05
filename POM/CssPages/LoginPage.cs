using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDC.POM.CssPages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement username => Find(By.XPath("//input[@id='username']"));
        private IWebElement password => Find(By.XPath("//input[@id='password']"));
        private IWebElement loginButton => Find(By.XPath("//span[text() ='Login']"));
        private By selectCss => By.XPath("//div[@routerlink='/commercial']");

        public void Username(string UserName)
        {
            username.SendKeys(UserName);
        }
        public void Password(string PassWord)
        {
            password.SendKeys(PassWord);
        }

        public void Login() 
        { 
            loginButton.Click();
        }

        public void SelectCssPortal()
        {
           
            IWebElement selectCssElement = WaitForElementToBeVisible(selectCss,10);
            selectCssElement.Click();
        }


    }
}

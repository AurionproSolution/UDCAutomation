using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDC.UDC.Core;

namespace UDC.POM
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
        private IWebElement dashboard => Find(By.XPath("//i[@class='fa-regular fa-wallet']"));
        private IWebElement UserNameReLogin => Find(By.XPath("//input[@aria-label='Username']"));

        public void EnterUsername(string UserName)
        {
            username.SendKeys(UserName);
            ReportingManager.LogPass("Entered Username");
        }
        public void EnterPassword(string PassWord)
        {
            password.SendKeys(PassWord);
            ReportingManager.LogPass("Entered Password");
        }

        public void LoginButton() 
        { 
            loginButton.Click();
            ReportingManager.LogPass("Login Sucessfully");
        }

        public void SelectCssPortal()
        {
           
            IWebElement selectCssElement = WaitForElementToBeVisible(selectCss,10);
            selectCssElement.Click();
        }

        public void EnterValidCredentials(string userName, string passWord)
        {
            EnterUsername(userName);
            EnterPassword(passWord);

        }

        
        public void ClickOnDashboard()
        {
            // Wait for spinner to disappear
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            wait.Until(drv =>
            {
                try
                {
                    return !drv.FindElement(By.CssSelector(".p-progressspinner")).Displayed;
                }
                catch (NoSuchElementException)
                {
                    return true; // Element is no longer in the DOM
                }
            });
            var dashboardPoElement = wait.Until(ExpectedConditions.ElementExists(By.XPath("//i[@class='fa-regular fa-wallet']")));
            wait.Until(ExpectedConditions.ElementToBeClickable(dashboardPoElement));
            HoverOverElement(dashboard);
            ReportingManager.LogPass("Clicked on Dashboard from MenuSlidebar");
        }

        public bool IsUsernameFieldDisplayed()
        {
            return UserNameReLogin.Displayed;
        }

    }

    public static class CredentialManager
    {
        public static (string Username, string Password) GetCredentials(string userType)
        {
            return userType.ToLower() switch
            {
                "internal" => ("Sandeep.bedekar", "Testing@2211"),
                "external" => ("AURPR.RESTAPI.CSS", "29^wOGU)F)5g"),
                _ => throw new ArgumentException("Invalid user type provided.")
            };
        }
    }
}

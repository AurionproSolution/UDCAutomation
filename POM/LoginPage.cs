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
        private IWebElement userNameReLogin => Find(By.XPath("//input[@aria-label='Username']"));
        private IWebElement loginWithFisButton => Find(By.XPath("//span[text()='Login with FIS']"));
        private IWebElement fisUsername => Find(By.XPath("//mat-label[text()='Username']/following::input"));
        private IWebElement fisProceedButton => Find(By.XPath("//span[text()='Proceed']"));
        private IWebElement fisPassword => Find(By.XPath("//mat-label[text()='Password']/following::input"));
        private IWebElement fisSigninButton => Find(By.XPath("//button[text()='Sign in']"));
        private IWebElement quotesAndApplicationsEle => Find(By.XPath("//div[text()=' Quotes & Applications ']"));
        private IWebElement otpElement => Find(By.XPath("//div[@class='otp-container']//child::mat-label\r\n "));
        public void EnterUsername(string userName)
        {
            username.SendKeys(userName);
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
        public void EnterFisUsername(string Username)
        {
            SetImplicitWait(10);
            WaitForPageToLoad(fisUsername);
            WaitTillTheElementIsLoaded(fisUsername);
            fisUsername.SendKeys(Username);
            ReportingManager.LogPass("Entered username successfully.");
        }
        public void ClickProceedButton()
        {
            ClickElementUsingJavaScript(fisProceedButton);
            ReportingManager.LogPass("Click on Proceed Button");
        }
        public void EnterFisPassword(string Password)
        {
            SetImplicitWait(10);
            WaitTillTheElementIsLoaded(fisPassword);
            fisPassword.SendKeys(Password);
            ReportingManager.LogPass("Entered password successfully.");
        }
        public void ClickOnSignInButton()
        {
            SetImplicitWait(10);
            fisSigninButton.Click();
            //WebDriverWait waitForElement = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            //var createStandardQuoteElement = waitForElement.Until(ExpectedConditions.ElementExists(By.XPath("//button[text()='Sign in']")));
            //waitForElement.Until(ExpectedConditions.ElementToBeClickable(signInButton));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            //js.ExecuteScript("arguments[0].click();", signInButton);
            ReportingManager.LogPass("Clicked on sign In button successfully");

        }

        public void EnterValidCredentials(string Username, string Password)
        {
            ClickLoginWithFisButton();
            EnterFisUsername(Username);
            ClickProceedButton();
            EnterFisPassword(Password);
            OtpElementIsDisplayed(Username, Password);
            ClickOnSignInButton();
            SetImplicitWait(10);
        }
        public void OtpElementIsDisplayed(string username, string password)
        {
            try
            {
                if (otpElement.Displayed)
                {
                    DriverContext.Driver.Navigate().Refresh();
                    SetImplicitWait(10);
                    ReportingManager.LogPass("OTP element is displayed to bypass OTP refreshed the page.");
                    EnterFisUsername(username);
                    ClickProceedButton();
                    EnterFisPassword(password);
                    //OtpElementIsDisplayed();
                    //ClickonSignInButton();
                    SetImplicitWait(5);
                }
            }
            catch
            {

            }
        }
        public void ClickLoginWithFisButton()
        {

            SetImplicitWait(5);
            //// Wait for spinner to disappear
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            //wait.Until(drv =>
            //{
            //    try
            //    {
            //        return !drv.FindElement(By.CssSelector(".p-progressspinner")).Displayed;
            //    }
            //    catch (NoSuchElementException)
            //    {
            //        return true; // Element is no longer in the DOM
            //    }
            //});
            //var LoginWithFisButtonElement = wait.Until(ExpectedConditions.ElementExists(By.XPath("//span[text()='Login with FIS']")));
            //wait.Until(ExpectedConditions.ElementToBeClickable(LoginWithFisButtonElement));
            loginWithFisButton.Click();
            ReportingManager.LogPass("Clicked on login with FIS button successfully");
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
            return userNameReLogin.Displayed;
        }
    }
    public static class CredentialManager
    {
        public static (string Username, string Password) GetCredentials(string userType)
        {
            return userType.ToLower() switch
            {
                "internal" => ("ANVARRAJU.MARRI", "Aurionpro@2211"),
                "external" => ("Anvarraju.marri1", "Aurionpro@2211"),
                _ => throw new ArgumentException("Invalid user type provided.")
            };
        }
    }
}

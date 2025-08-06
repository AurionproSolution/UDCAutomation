using Microsoft.AspNetCore.Razor.Language.Intermediate;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using System;
using UDC.POM;
using UDC.POM.CssPages;
using UDC.UDC.Core;

namespace UDC.StepDefinitions.CssStepDefinations
{
    [Binding]
    public class VerifyDashboardLoginStepDefinitions
    {
        public readonly PageObjectContainer _pageObject;
        public LoginPage loginPage = new LoginPage(DriverContext.Driver);
        public VerifyDashboardLoginStepDefinitions(PageObjectContainer pageObject)
        {
            _pageObject = pageObject;
        }

        //[Given("the user is on the loginpage")]
        //public void GivenTheUserIsOnTheLoginpage()
        //{
        //    ReportingManager.LogInfo("Navigating to URL in browser");
        //    DriverContext.Driver.Navigate().GoToUrl("https://aurpr-ia.assetfinance.myfis.cloud/IACSSPortal/authentication/login");
        //}

        [When("the user enters {string} and {string} and clicks on the Login button")]
        public void WhenTheUserEntersAndAndClicksOnTheLoginButton(string username, string password)
        {
            ReportingManager.LogInfo("User enters username");
            //_pageObject.loginPage.username(username);
            //ReportingManager.LogInfo("User enters password");
            //_pageObject.CSSLoginPage.Password(password);
            _pageObject.loginPage.LoginButton();
            ReportingManager.LogInfo("User Logged in succesfully");

        }

        [Then("the user should be successfully redirected to the select application page and the user selects {string}")]
        public void ThenTheUserShouldBeSuccessfullyRedirectedToTheSelectApplicationPageAndTheUserSelects(string p0)
        {
            ReportingManager.LogInfo("User selects CSS Portal");
            _pageObject.loginPage.SelectCssPortal();
        }

        [Then("the user redirects to portal dashboard and the user select {string} from dealer's dropdown")]
        public void ThenTheUserRedirectsToPortalDashboardAndTheUserSelectFromDealersDropdown(string p0)
        {
            ReportingManager.LogInfo("User redirects to Dashboard");
            

        }

        [Then("the user redirects to portal dashboard")]
        public void ThenTheUserRedirectsToPortalDashboard()
        {
            //throw new PendingStepException();
        }

        [When("the user select {string} from dealer's dropdown")]
        public void WhenTheUserSelectFromDealersDropdown(string dealer)
        {
            //throw new PendingStepException();
        }

        [Then("the user should be able to see dealer details")]
        public void ThenTheUserShouldBeAbleToSeeDealerDetails()
        {
           // throw new PendingStepException();
        }

        

    }
}

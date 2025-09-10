using Reqnroll;
using System;
using UDC.POM.DoPages;
using UDC.StepDefinitions.CssStepDefinations;

namespace UDC.StepDefinitions.DoStepDefinations
{
    [Binding]
    public class StandardQuoteHappyPathStepDefinitions
    {
        private readonly DO_PageObjectContainer _pageObjects;
        private Dictionary<string, string> quickQuoteValues;
        private Dictionary<string, string> comparisonValue;

        public StandardQuoteHappyPathStepDefinitions(DO_PageObjectContainer pageObjects)
        {
            _pageObjects = pageObjects;
        }

       
        [Then("User Navigate to Asset Details Pages and click on Asset, Insurance & Trade-in Summary  button")]
        public void ThenUserNavigateToAssetDetailsPagesAndClickOnAssetInsuranceTrade_InSummaryButton()
        {
            _pageObjects.DoAssetDetailsPage.WaitTillTheLoadSpinnerDisappears();
            _pageObjects.DoAssetDetailsPage.ClickOnAssetInsTradeInHLink();
        }


        [Then("the suer clicks the Asset & Insurance summary  edit button")]
        public void ThenTheSuerClicksTheAssetInsuranceSummaryEditButton()
        {
            _pageObjects.DoAssetAndInsuranceSummaryPage.ClickAssetEditButton();
        }


        [Then("the user enter all mandatory fields in the Add Asset page")]
        public void ThenTheUserEnterAllMandatoryFieldsInTheAddAssetPage()
        {
            _pageObjects.DoAssetAndInsuranceSummaryPage.EnterAssetDetails();
        }



        [Then("User clicks Submit")]
        public void ThenUserClicksSubmit()
        {
            _pageObjects.DoAssetAndInsuranceSummaryPage.ClickOnSubmitButton();
        }

        [Then("Asset & Insurance Summary popup should be display")]
        public void ThenAssetInsuranceSummaryPopupShouldBeDisplay()
        {
            _pageObjects.DoAssetAndInsuranceSummaryPage.ClickOnAssetCloseButton();
            _pageObjects.DoAssetDetailsPage.EnterOriginatorRef("Test123");
        }

        [Then("User clicks Calculate")]
        public void ThenUserClicksCalculate()
        {
            _pageObjects.DoAssetDetailsPage.ClickOnCalculateButton();
            _pageObjects.DoAssetDetailsPage.WaitTillTheLoadSpinnerDisappears();
        }

        [Then("the user clicks the Key disclosure and clicks the next button")]
        public void ThenTheUserClicksTheKeyDisclosureAndClicksTheNextButton()
        {
      //      _pageObjects.DoAssetDetailsPage.ClickOnKeyInformationDisclosureButton();
            _pageObjects.DoAssetDetailsPage.ClickOnNextButton();
            _pageObjects.DoAssetDetailsPage.WaitTillTheLoadSpinnerDisappears();
        }

        [Then("the user is redirected to customer details page")]
        public void ThenTheUserIsRedirectedToCustomerDetailsPage()
        {
            _pageObjects.DoCustomerDetailsPage.VerifyBorrowersandGuarantors();
        }

        [When("the user clicks the add borrower And guarantor button")]
        public void WhenTheUserClicksTheAddBorrowerAndGuarantorButton()
        {
            _pageObjects.DoCustomerDetailsPage.ClickAddBorrowerOrGuarantors();
        }

        [When("the user selects {string}in the dropdown")]
        public void WhenTheUserSelectsInTheDropdown(string p0)
        {
           _pageObjects.DoSearchCustomerPage.ClickOnSelectSearchBy("Trust Name");
        }

        [When("the user enters the Trust in the field and clicks Search button")]
        public void WhenTheUserEntersTheTrustInTheFieldAndClicksSearchButton()
        {
            _pageObjects.DoSearchCustomerPage.ClickOnEnterTrustRadioButton();
            Thread.Sleep(1000);
            _pageObjects.DoSearchCustomerPage.EnterTrustNameInTrustNameField();
            _pageObjects.DoSearchCustomerPage.ClickOnSearchButton();
            _pageObjects.DoAssetDetailsPage.WaitTillTheLoadSpinnerDisappears();
        }

        [When("user click on Add New Customer Button")]
        public void WhenUserClickOnAddNewCustomerButton()
        {
            _pageObjects.DoSearchCustomerPage.ClickOnAddNewCustomerLink();
            _pageObjects.DoSearchCustomerPage.WaitTillTheLoadSpinnerDisappears();
        }


        [Then("User Navigate to Trust Details page and entre Mandatory details and click on Next Button")]
        public void ThenUserNavigateToTrustDetailsPageAndEntreMandatoryDetailsAndClickOnNextButton()
        {
            _pageObjects.DoTrustDetailsPage.EnterTrustDetails();
        }

        [Then("User Navigate to Address Details page and entre Mandatory details and click on Next Button")]
        public void ThenUserNavigateToAddressDetailsPageAndEntreMandatoryDetailsAndClickOnNextButton()
        {
            _pageObjects.DoTrustAddressDetailsPage.EnterAddressDetails();
            _pageObjects.DoAssetDetailsPage.ClickOnNextButton();
            _pageObjects.DoAssetDetailsPage.ClickOnNextButton();
        }

        [Then("user navigate to Contract Details page and click on submit button")]
        public void ThenUserNavigateToContractDetailsPageAndClickOnSubmitButton()
        {
            _pageObjects.DoTrustConractDetailsPage.EnterContactDetails();
        }

        [Then("the user clicks the check boxes in the Originator Declaration page then clicks the Proceed button")]
        public void ThenTheUserClicksTheCheckBoxesInTheOriginatorDeclarationPageThenClicksTheProceedButton()
        {
            _pageObjects.DoAssetDetailsPage.ClickOnNextButton();
            _pageObjects.DoContractSummary.ClickOnSubmitButton();
            _pageObjects.DoSearchCustomerPage.WaitTillTheLoadSpinnerDisappears();
            _pageObjects.DoContractSummary.AcceptOriginatorDeclaration();
        }

        [Then("Quote submission Message should display")]
        public void ThenQuoteSubmissionMessageShouldDisplay()
        {
            _pageObjects.DoContractSummary.VerifyApplicationSubmit();
        }


    }


}

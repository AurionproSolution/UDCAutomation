using OpenQA.Selenium;
using UDC.UDC.Core;

namespace UDC.POM.DoPages.DoIndividualPages
{
    public class DoPersonalDetailsPage : BasePage
    {
        public DoPersonalDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement selectTitle => Find(By.XPath("//label[text()='Title']//following-sibling::div/p-dropdown/div"));
        private IWebElement firstName => Find(By.XPath("//label[normalize-space()='First Name']/following-sibling::div//input"));
        private IWebElement lastName => Find(By.XPath("//label[normalize-space()='Last Name']/following-sibling::div//input"));
        private IWebElement selectGender => Find(By.XPath("//label[text()='Gender']//following-sibling::div/p-dropdown/div"));
        private IWebElement dateOfBirth => Find(By.XPath("//label[text()='Date of Birth']/following-sibling::div//input"));
        private IWebElement selectNoOfDependents => Find(By.XPath("//label[text()='No. of Dependents']//following-sibling::div/p-dropdown/div"));
        private IWebElement maritalStatus => Find(By.XPath("//label[text()='Marital Status']/following-sibling::div/p-dropdown/div"));
        private IWebElement enterAreaCode => Find(By.XPath("//input[@placeholder='Area code']"));
        private IWebElement enterPhoneNumber => Find(By.XPath("//input[@placeholder='Phone number']"));
        private IWebElement enterEmail => Find(By.XPath("//input[@class='p-inputtext p-component p-element ng-untouched ng-pristine ng-invalid']"));
        private IWebElement selectLicenceType => Find(By.XPath("//label[text()='Licence Type']//following-sibling::div/p-dropdown/div"));
        private IWebElement enterLicenceNumber => Find(By.XPath("//label[normalize-space()='Licence Number']/following-sibling::div/input"));
        private IWebElement enterVersionNumber => Find(By.XPath("//label[normalize-space()='Version Number']/following-sibling::div/input"));
        private IWebElement selectCountryOfIssue => Find(By.XPath("//label[text()='Country of Issue']//following-sibling::div/p-dropdown/div"));
        private IWebElement enterCountryOfCitizenship => Find(By.XPath("//p-dropdown[@formcontrolname='countryOfCitizenship']//span[@role='combobox']"));
        private IWebElement clickOnNextButton => Find(By.XPath("//span[normalize-space()='Next']"));
        By optionsLocator = By.XPath("//p-dropdownitem[@class='p-element ng-star-inserted']");

        public void SelectTitle(string value)
        {
            dropdown.SelectCustomDropdown(selectTitle, value, optionsLocator);
            ReportingManager.LogPass("Selected Title: " + value);
        }
        public void EnterFirstName(string value)
        {
            firstName.Clear();
            firstName.SendKeys(value);
            ReportingManager.LogPass("Entered First Name: " + value);
        }
        public void EnterLastName(string value)
        {
            lastName.Clear();
            lastName.SendKeys(value);
            ReportingManager.LogPass("Entered Last Name: " + value);
        }
        public void SelectGender(string value)
        {
            dropdown.SelectCustomDropdown(selectGender, value, optionsLocator);
            ReportingManager.LogPass("Selected Gender : " + value);
        }
        public void EnterDateOfBirth(string value)
        {
            dateOfBirth.Clear();
            dateOfBirth.SendKeys(value);
            ReportingManager.LogPass("Entered Date of Birth: " + value);
        }
        public void SelectNoOfDependents(string value)
        {
            dropdown.SelectCustomDropdown(selectNoOfDependents, value, optionsLocator);
            ReportingManager.LogPass("Selected No. of Dependents: " + value);
        }
        public void SelectMaritalStatus(string value)
        {
            dropdown.SelectCustomDropdown(maritalStatus, value, optionsLocator);
            ReportingManager.LogPass("Selected Marital Status: " + value);
        }
        public void EnterAreaCode(string value)
        {
            enterAreaCode.Clear();
            enterAreaCode.SendKeys(value);
            ReportingManager.LogPass("Entered Area Code: " + value);
        }
        public void EnterPhoneNumber(string value)
        {
            enterPhoneNumber.Clear();
            enterPhoneNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Phone Number: " + value);
        }
        public void EnterEmail(string value)
        {
            enterEmail.Clear();
            enterEmail.SendKeys(value);
            ReportingManager.LogPass("Entered Email: " + value);
        }
        public void SelectLicenceType(string value)
        {
            dropdown.SelectCustomDropdown(selectLicenceType, value, optionsLocator);
            ReportingManager.LogPass("Selected Licence Type: " + value);
        }
        public void EnterLicenceNumber(string value)
        {
            enterLicenceNumber.Clear();
            enterLicenceNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Licence Number: " + value);
        }
        public void EnterVersionNumber(string value)
        {
            enterVersionNumber.Clear();
            enterVersionNumber.SendKeys(value);
            ReportingManager.LogPass("Entered Version Number: " + value);
        }
        public void SelectCountryOfIssue(string value)
        {
            dropdown.SelectCustomDropdown(selectCountryOfIssue, value, optionsLocator);
            ReportingManager.LogPass("Selected Country of Issue: " + value);
        }
        public void EnterCountryOfCitizenship(string value)
        {
            dropdown.SelectCustomDropdown(enterCountryOfCitizenship, value, optionsLocator);
            ReportingManager.LogPass("Selected Country of Citizenship: " + value);
        }
        public void ClickOnNextButton()
        {
            clickOnNextButton.Click();
            ReportingManager.LogPass("Clicked on Next Button");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UDC.POM.DoPages.DoIndividualPages
{
    public class DoEmploymentDetailsPage : BasePage
    {
        public DoEmploymentDetailsPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement enterEmployerName => Find(By.XPath("//input[@class='p-inputtext p-component p-element form-control valueClass ng-untouched ng-pristine ng-star-inserted ng-invalid']"));
        private IWebElement selectOccupation => Find(By.XPath("//label[text()='Occupation']//following-sibling::div/p-dropdown/div"));
        private IWebElement selectEmployeeType => Find(By.XPath("//label[text()='Employment Type']//following-sibling::div/p-dropdown/div"));
        private IWebElement yearWithCurrentEmployer => Find(By.XPath("//input[@required='true']"));
        private IWebElement monthWithCurrentEmployer => Find(By.XPath("//p-inputnumber[@class='p-element p-inputwrapper form-control valueClass ng-untouched ng-pristine ng-valid ng-star-inserted']//input[@role='spinbutton']"));


    }
}

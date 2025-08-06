using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDC.POM.CssPages;
using UDC.POM;
using UDC.UDC.Core;
using UDC.StepDefinitions.TestDataFiles;

namespace UDC.StepDefinitions.CssStepDefinations
{
    public class PageObjectContainer
    {
        public LoginPage loginPage { get; }
        public CssDashboard cssDashboard { get; }
        public TestDataModel testData { get; }
        public PageObjectContainer()
        {
            var driver = DriverContext.Driver;
            loginPage = new LoginPage(driver);
            cssDashboard = new CssDashboard(driver);
            //testData = JsonUtilities.ReadJson<TestDataModel>("TestDataFiles/PortalUrls.json");

        }
    }
}

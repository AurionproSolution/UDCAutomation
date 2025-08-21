using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDC.POM.CssPages;
using UDC.POM;
using UDC.UDC.Core;
using UDC.StepDefinitions.TestDataFiles;
using UDC.POM.DOPages;

namespace UDC.StepDefinitions.CssStepDefinations
{
    public class PageObjectContainer
    {
        public LoginPage loginPage { get; }
        public CssDashboard cssDashboard { get; }
        public TestDataModel testData { get; }
        public SelectApplicationPage selectApplicationPage { get; }
        public DashboardPage DashboardPage { get; }
        public QuickQuotePage QuickQuotePage { get; }
        public QuickQuoteDataModel QuickQuoteTestData { get; }
        public DropdownHelper DropdownHelper { get; set; }

        public PageObjectContainer()
        {
            var driver = DriverContext.Driver;
            loginPage = new LoginPage(driver);
            cssDashboard = new CssDashboard(driver);
            DashboardPage = new DashboardPage(driver);
            QuickQuotePage = new QuickQuotePage(driver);
            DashboardPage = new DashboardPage(driver);
            selectApplicationPage = new SelectApplicationPage(driver);
            testData = JsonUtilities.ReadJson<TestDataModel>("TestDataFiles/PortalUrls.json");
            QuickQuoteTestData = JsonUtilities.ReadJson<QuickQuoteDataModel>("TestDatafiles/QuickQuote.json");
        }
    }
}

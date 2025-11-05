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
using UDC.POM.DoPages;
using UDC.POM.DoPages.DoTrustPages;

namespace UDC.StepDefinitions.CssStepDefinations
{
    public class DO_PageObjectContainer
    {
        public LoginPage loginPage { get; }
        public CssDashboard cssDashboard { get; }
        public TestDataModel testData { get; }
        public SelectApplicationPage selectApplicationPage { get; }
        public DashboardPage DashboardPage { get; }
        public QuickQuotePage QuickQuotePage { get; }
        public QuickQuoteDataModel QuickQuoteTestData { get; }
        public DropdownHelper DropdownHelper { get; set; }
        public DoAssetDetailsPage DoAssetDetailsPage { get; set; }
        public DoAssetAndInsuranceSummaryPage DoAssetAndInsuranceSummaryPage { get; set; }
        public DoCustomerDetailsPage DoCustomerDetailsPage { get; set; }
        public DoSearchCustomerPage DoSearchCustomerPage { get; set; }
        public DoTrustDetailsPage DoTrustDetailsPage { get; set; }
        public DoTrustAddressDetailsPage DoTrustAddressDetailsPage { get; set; }
        public DoTrustConractDetailsPage DoTrustConractDetailsPage {  get; set; }
        public DoContractSummary DoContractSummary { get; set; }
        public AssetDetailsDataModel AssetDetailsTestData { get; }
        public CustomerDetailsDataModel CustomerDetailsTestData { get;}
        public DO_PageObjectContainer()
        {
            var driver = DriverContext.Driver;
            loginPage = new LoginPage(driver);
            cssDashboard = new CssDashboard(driver);
            DashboardPage = new DashboardPage(driver);
            QuickQuotePage = new QuickQuotePage(driver);
            DashboardPage = new DashboardPage(driver);
            selectApplicationPage = new SelectApplicationPage(driver);
            testData = JsonUtilities.ReadJson<TestDataModel>("TestDataFiles_DO/PortalUrls.json");
            QuickQuoteTestData = JsonUtilities.ReadJson<QuickQuoteDataModel>("TestDataFiles_DO/QuickQuote.json");
            DoAssetDetailsPage = new DoAssetDetailsPage(driver);
            DoAssetAndInsuranceSummaryPage=new DoAssetAndInsuranceSummaryPage(driver);
            DoCustomerDetailsPage=new DoCustomerDetailsPage(driver);
            DoSearchCustomerPage = new DoSearchCustomerPage(driver);
            DoTrustDetailsPage = new DoTrustDetailsPage(driver);
            DoTrustAddressDetailsPage = new DoTrustAddressDetailsPage(driver);
            DoTrustConractDetailsPage = new DoTrustConractDetailsPage(driver);
            DoContractSummary = new DoContractSummary(driver);
            AssetDetailsTestData = JsonUtilities.ReadJson<AssetDetailsDataModel>("TestDataFiles_DO/AssetSummary.json");
            CustomerDetailsTestData = JsonUtilities.ReadJson<CustomerDetailsDataModel>("TestDataFiles_DO/CustomerDetails.json");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDC.StepDefinitions.TestDataFiles
{
    public class TestDataModel
    {
        public string BaseUrl { get; set; }
        public string DoTestEnUrl { get; set; }

    }
    public class QuickQuoteDataModel
    {
        public List<string> Programs { get; set; }
        public List<string> Products { get; set; }
        public List<string> Frequency { get; set; }
        public List<string> CashPrice { get; set; }
        public List<string> InterestRate { get; set; }
        public List<string> TermsInMonths { get; set; }
        public List<string> Deposit { get; set; }
        public List<string> CalculateFor { get; set; }
        public List<string> Balloon { get; set; }
    }


    public class AssetDetailsDataModel
    {
        public string  Make { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public string RegoNo { get; set; }
        public string VINNumber { get; set; }
        public string SerialChassisNo { get; set; }
        public string PolicyNumber { get; set; }

    }

    public class CustomerDetailsDataModel
    {
        public string TrustName { get; set; }
        public string RegisterNumber { get; set; }
        public string TrustinYears { get; set; }
        public string TrustinMonth { get; set; }
        public string BusinessContactDetails { get; set; }
        public string BusinessContactDetails1 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PhysicalAddress { get; set; }
        public string TimeAtAddressInYears { get; set; }
        public string TimeAtAddressInMonths { get; set; }
        public string FloorNumber { get; set; }
        public string PostalAddress { get; set; }
        public string PostalAddressFloorNumber { get; set; }
        public string RegisterAddress { get; set; }

    }
}

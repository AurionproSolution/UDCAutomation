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
}

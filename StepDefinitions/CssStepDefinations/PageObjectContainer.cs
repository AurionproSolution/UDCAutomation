using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDC.POM.CssPages;
using UDC.UDC.Core;

namespace UDC.StepDefinitions.CssStepDefinations
{
    public class PageObjectContainer
    {
        public LoginPage CSSLoginPage { get; }
        public Dashboard CSSDashboard { get; }

        public PageObjectContainer()
        {
            var driver = DriverContext.Driver;
            CSSLoginPage = new LoginPage(driver);
            CSSDashboard = new Dashboard(driver);

        }
    }
}

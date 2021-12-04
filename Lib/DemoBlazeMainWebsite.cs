using DemoBlazeWebsite.Lib.Driver_config;
using DemoBlazeWebsite.Pages;
using DemoBlazeWebsite.Settings;
using OpenQA.Selenium;

namespace DemoBlazeWebsite.Lib
{
    public class DemoBlazeMainWebsite
    {
        public readonly IWebDriver _driver;
        public readonly CartPage _cartPage;
        public readonly HomePage _homePage;
        public readonly LogInPage _logInPage;
        public readonly SignInPage _signInPage;


        public DemoBlazeMainWebsite(string drivername, int pageLoadWaitInSecs = 10, int implivitwaitInSecs = 10)
        {
            _driver = new SeleniumDriverConfig(drivername, pageLoadWaitInSecs, implivitwaitInSecs).Driver;
            _cartPage = new CartPage(_driver);
            _homePage = new HomePage(_driver);
            _logInPage = new LogInPage(_driver);
            _signInPage = new SignInPage(_driver);

        }

    }
}

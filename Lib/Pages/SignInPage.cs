
using OpenQA.Selenium;

namespace DemoBlazeWebsite.Pages
{
    public class SignInPage
    {
        private IWebDriver _driver;

        public SignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

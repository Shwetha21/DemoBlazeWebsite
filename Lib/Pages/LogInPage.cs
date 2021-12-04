using OpenQA.Selenium;

namespace DemoBlazeWebsite.Pages
{
    public class LogInPage
    {
        private IWebDriver _driver;

        public LogInPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

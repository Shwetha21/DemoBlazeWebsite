using OpenQA.Selenium;

namespace DemoBlazeWebsite.Pages
{
    public class CartPage
    {
        private IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}

using DemoBlazeWebsite.Models;
using DemoBlazeWebsite.Settings;
using DemoBlazeWebsite.Testdata;
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

        private IWebElement placeOrder => _driver.FindElement(By.CssSelector("[data-target=\"#orderModal\"]"));
        private IWebElement name => _driver.FindElement(By.Id("name"));
        private IWebElement country => _driver.FindElement(By.Id("country"));
        private IWebElement city => _driver.FindElement(By.Id("city"));
        private IWebElement creditCard => _driver.FindElement(By.Id("card"));
        private IWebElement month => _driver.FindElement(By.Id("month"));
        private IWebElement year => _driver.FindElement(By.Id("year"));
        private IWebElement purchaseOrder => _driver.FindElement(By.CssSelector("[onclick=\"purchaseOrder()\"]"));
        private IWebElement confirmation => _driver.FindElement(By.XPath("/html/body/div[10]/h2"));

        private Customer customerdetails => CustomerTestData.GetDetails();

        public void GoToCartPage(UrlSettings urlSettings)
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl($"{urlSettings.DemoBlazeUrl}/cart.html");
        }

        public void PlaceOrder()
        {
            placeOrder.Click();
        }

        public void FillDetails()
        {
            name.SendKeys(customerdetails.Name);
            country.SendKeys(customerdetails.Country);
            city.SendKeys(customerdetails.City);
            creditCard.SendKeys(customerdetails.CreditCard);
            month.SendKeys(customerdetails.Month.ToString());
            year.SendKeys(customerdetails.Year.ToString());
        }

        public void PurchaseOrder()
        {
            purchaseOrder.Click();
        }

        public string OrderConfirmed()
        {
            return confirmation.Text;
        }
    }
}

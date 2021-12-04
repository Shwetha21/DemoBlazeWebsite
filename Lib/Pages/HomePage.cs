using DemoBlazeWebsite.Settings;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoBlazeWebsite.Pages
{
    public class HomePage
    {
        readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement samsungGalaxyS6 => _driver.FindElement(By.CssSelector("[class=\"hrefch\"]"));
        private IWebElement addToCart => _driver.FindElement(By.CssSelector("[onclick=\"addToCart(1)\"]"));
        private IWebElement clikOnCart => _driver.FindElement(By.CssSelector(" [onclick=\"showcart()\"]"));
        private IWebElement samsungGalaxyS6Added => _driver.FindElement(By.CssSelector("//*[@id=\"tbodyid\"]/tr[1]/td[2]"));

        public void GoToHomePage(UrlSettings urlSettings)
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl($"{urlSettings.DemoBlazeUrl}");
        }

        public void SelectSamSungGalaxyPhone()
        {
            samsungGalaxyS6.Click();
        }

        public void AddToCart()
        {
            addToCart.Click();
        }

        public void ClickonCart()
        {
            _driver.SwitchTo().Alert().Accept();
            clikOnCart.Click();
            Assert.IsTrue(samsungGalaxyS6Added.Text.Contains("Samsung"));
        }
    }
}

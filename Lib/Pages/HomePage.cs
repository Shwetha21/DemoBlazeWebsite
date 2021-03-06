using DemoBlazeWebsite.Settings;
using OpenQA.Selenium;
using System.Threading;

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
        private IWebElement addSonyVaio7ToCart => _driver.FindElement(By.CssSelector("[onclick=\"addToCart(9)\"]"));
        private IWebElement clikOnCart => _driver.FindElement(By.Id("cartur"));
        private IWebElement samsungGalaxyS6Added => _driver.FindElement(By.XPath("//*[@id=\"tbodyid\"]/tr[1]/td[2]"));
        private IWebElement laptop => _driver.FindElement(By.CssSelector("[onclick=\"byCat('notebook')\"]"));
        private IWebElement sonyVaioI7 => _driver.FindElement(By.CssSelector("[href=\"prod.html?idp_=9\"]"));
        private IWebElement sonyVaioI7Added => _driver.FindElement(By.XPath("//*[@id=\"tbodyid\"]/tr/td[2]"));
        private IWebElement monitor => _driver.FindElement(By.CssSelector("[onclick=\"byCat('monitor')\"]"));
        private IWebElement asusHd => _driver.FindElement(By.XPath("//*[@id=\"tbodyid\"]/div[2]/div/div/h4/a"));
        private IWebElement addAsusHdToCart => _driver.FindElement(By.CssSelector("[onclick=\"addToCart(14)\"]"));
        private IWebElement asusHdAdded => _driver.FindElement(By.XPath("//*[@id=\"tbodyid\"]/tr/td[2]"));

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
            Thread.Sleep(5000);
            _driver.SwitchTo().Alert().Accept();
            clikOnCart.Click();
        }

        public string CheckTheCart()
        {
            return samsungGalaxyS6Added.Text;
        }

        public void ClickOnLaptop()
        {
            laptop.Click();
        }

        public void SelectSonyVaioI7()
        {
            Thread.Sleep(1000);
            sonyVaioI7.Click();
        }

        public string CheckSonyVaioI7()
        {
            return sonyVaioI7Added.Text;
        }

        public void AddSovyVaioI7ToCart()
        {
            addSonyVaio7ToCart.Click();
            Thread.Sleep(5000);
            _driver.SwitchTo().Alert().Accept();
            clikOnCart.Click();
        }

        public void ClickOnMonitor()
        {
            IWebElement monitor = _driver.FindElement(By.CssSelector("[onclick=\"byCat('monitor')\"]"));
            monitor.Click();
        }

        public void SelectAsusHd()
        {
            Thread.Sleep(5000);
            asusHd.Click();
        }

        public void AddAsusHdToCart()
        {
            addAsusHdToCart.Click();
            Thread.Sleep(5000);
            _driver.SwitchTo().Alert().Accept();
            clikOnCart.Click();
        }

        public string CheckAsusHdAdded()
        {
            return asusHdAdded.Text;
        }
    }
}

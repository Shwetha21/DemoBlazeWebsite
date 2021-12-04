using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Steps
{
    public class BuyMonitorSteps
    {
        readonly IWebDriver _driver;

        private IWebElement clikOnCart => _driver.FindElement(By.XPath(" //*[@id=\"cartur\"]"));
        private IWebElement samsungGalaxyS6 => _driver.FindElement(By.XPath("//*[@id=\"tbodyid\"]/tr[1]/td[2]"));
        


        public BuyMonitorSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Then(@"the phone should be succeffully added to the cart")]
        public void ThenThePhoneShouldBeSucceffullyAddedToTheCart()
        {
            _driver.SwitchTo().Alert().Accept();
            clikOnCart.Click();
            Assert.IsTrue(samsungGalaxyS6.Text.Contains("Samsung"));
        }

    }
}

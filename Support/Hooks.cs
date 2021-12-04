using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Support
{
    [Binding]
    public class Hooks
    {
        IWebDriver _driver;
        public Hooks(IWebDriver driver)
        {
            _driver = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Dispose();
        }
    }
}

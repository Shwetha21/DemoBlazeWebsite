//Placeholder to add steps to test buyin Monitor
using DemoBlazeWebsite.Lib;
using DemoBlazeWebsite.Settings;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Steps
{
    [Binding]
    public class BuyMonitorSteps
    {
        private UrlSettings _urlSettings { get; }

        private DemoBlazeMainWebsite _demoBlazemainWebsite; 
        public BuyMonitorSteps(UrlSettings urlSettings,
                                DemoBlazeMainWebsite demoBlazemainWebsite)
        {
            _urlSettings = urlSettings;
            _demoBlazemainWebsite = demoBlazemainWebsite;
        }

        [Given(@"i visit home page")]
        public void GivenIVisitHomePage()
        {
            _demoBlazemainWebsite._homePage.GoToHomePage(_urlSettings);
        }

        [Given(@"I am in Monitor section")]
        public void GivenIAmInMonitorSection()
        {
            _demoBlazemainWebsite._homePage.ClickOnMonitor();
        }

        [Given(@"choose asus monitor")]
        public void GivenChooseAsusMonitor()
        {
            _demoBlazemainWebsite._homePage.SelectAsusHd();
        }

        [When(@"i add the monitor to the cart")]
        public void WhenIAddTheMonitorToTheCart()
        {
            _demoBlazemainWebsite._homePage.AddAsusHdToCart();
        }

        [Then(@"monitor should be successfully added")]
        public void ThenMonitorShouldBeSuccessfullyAdded()
        {
            Assert.That(_demoBlazemainWebsite._homePage.CheckAsusHdAdded, Does.Contain("ASUS"));
        }

        [AfterScenario]
        public void DisposeWebdriver()
        {
            _demoBlazemainWebsite._driver.Dispose();
        }
    }
}

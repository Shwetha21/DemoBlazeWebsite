using DemoBlazeWebsite.Lib;
using DemoBlazeWebsite.Settings;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Steps
{
    [Binding]
    public class BuyLapTopSteps
    {
        private UrlSettings _urlSettings { get; }

        private DemoBlazeMainWebsite _demoBlazemainWebsite = new DemoBlazeMainWebsite("chrome");
        public BuyLapTopSteps(UrlSettings urlSettings)
        {
            _urlSettings = urlSettings;
        }

        [Given(@"I go in Home page")]
        public void GivenIGoInHomePage()
        {
            _demoBlazemainWebsite._homePage.GoToHomePage(_urlSettings);
        }

        [Given(@"I am in laptop section")]
        public void GivenIAmInLaptopSection()
        {
            _demoBlazemainWebsite._homePage.ClickOnLaptop();
        }

        [Given(@"choose sony Vaio I(.*)")]
        public void GivenChooseSonyVaioI(int p0)
        {
            _demoBlazemainWebsite._homePage.SelectSonyVaioI7();
        }

        [When(@"i add the laptop to the cart")]
        public void WhenIAddTheLaptopToTheCart()
        {
            _demoBlazemainWebsite._homePage.AddSovyVaioI7ToCart();
        }

        [Then(@"laptop should be successfully added")]
        public void ThenLaptopShouldBeSuccessfullyAdded()
        {
            Assert.That(_demoBlazemainWebsite._homePage.CheckSonyVaioI7, Does.Contain("Sony vaio i7"));
        }

        [AfterScenario]
        public void DisposeWebdriver()
        {
            _demoBlazemainWebsite._driver.Dispose();
        }

    }
}

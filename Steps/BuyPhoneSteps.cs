using DemoBlazeWebsite.Lib;
using DemoBlazeWebsite.Pages;
using DemoBlazeWebsite.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Steps
{
    [Binding]
    public class BuyPhoneSteps
    {
        private UrlSettings _urlSettings { get; }

        private DemoBlazeMainWebsite _demoBlazemainWebsite = new DemoBlazeMainWebsite("chrome");

        public BuyPhoneSteps(UrlSettings urlSettings)
        {
            _urlSettings = urlSettings;
        }

        [Given(@"I am in Home page")]
        public void GivenIAmInHomePage()
        {
            _demoBlazemainWebsite._homePage.GoToHomePage(_urlSettings);
        }

        [Given(@"I click on phone I want to buy")]
        public void GivenIClickOnPhoneIWantToBuy()
        {
            _demoBlazemainWebsite._homePage.SelectSamSungGalaxyPhone();
        }

        [When(@"I add the phone to the cart")]
        public void WhenIAddThePhoneToTheCart()
        {
            _demoBlazemainWebsite._homePage.AddToCart();
        }

        [Then(@"the phone should be succeffully added to the cart")]
        public void ThenThePhoneShouldBeSucceffullyAddedToTheCart()
        {
            Assert.That(_demoBlazemainWebsite._homePage.CheckTheCart(), Does.Contain("Samsung"));
        }

        [AfterScenario]
        public void DisposeWebdriver()
        {
            _demoBlazemainWebsite._driver.Dispose();
        }
    }
}

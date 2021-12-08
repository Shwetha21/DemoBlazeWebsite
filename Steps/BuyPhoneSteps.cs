using DemoBlazeWebsite.Lib;
using DemoBlazeWebsite.Settings;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DemoBlazeWebsite.Steps
{
    [Binding]
    public class BuyPhoneSteps
    {
        private UrlSettings _urlSettings { get; }

        private DemoBlazeMainWebsite _demoBlazemainWebsite; 

        public BuyPhoneSteps(UrlSettings urlSettings,
                            DemoBlazeMainWebsite demoBlazemainWebsite)
        {
            _urlSettings = urlSettings;
            _demoBlazemainWebsite = demoBlazemainWebsite;
        }

        #region AddToCart
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
        #endregion

        #region PSurchase
        [Given(@"I am in Cart page")]
        public void GivenIAmInCartPage()
        {
            _demoBlazemainWebsite._cartPage.GoToCartPage(_urlSettings);
        }

        [Given(@"I click on place the order")]
        public void GivenIClickOnPlaceTheOrder()
        {
            _demoBlazemainWebsite._cartPage.PlaceOrder();
        }

        [Given(@"I fill in all the details")]
        public void GivenIFillInAllTheDetails()
        {
            _demoBlazemainWebsite._cartPage.FillDetails();
        }

        [When(@"I click on purchace")]
        public void WhenIClickOnPurchace()
        {
            _demoBlazemainWebsite._cartPage.PurchaseOrder();
        }

        [Then(@"the order should be placed")]
        public void ThenTheOrderShouldBePlaced()
        {
            Assert.That(_demoBlazemainWebsite._cartPage.OrderConfirmed(), Does.Contain("Thank you"));
        }
        #endregion

        [AfterScenario]
        public void DisposeWebdriver()
        {
            _demoBlazemainWebsite._driver.Dispose();
        }
    }
}

using HOTELpinSight;
using HOTELpinSight.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace SFAutomationFramework.Steps
{  

    [Binding]
    public class E2EHotelFlowSteps
    {
        private IWebDriver _driver;

        private LoginPage _loginPage;
        private HotelSearchPage _hotelSearchPage;
        private SearchingPage _searchingPage;
        private ResultsPage _resultsPage;
        private CheckOutPage _checkOutPage;

        [Given(@"I have entered to pinSight application")]
        public void GivenIHaveEnteredToPinSightApplication()
        {
            _driver = WebDriverFactory.Create();
            _loginPage = LoginPage.NavigateTo(_driver);
        }
        
        [When(@"I enter city to search hotel")]
        public void WhenIEnterCityToSearchHotel()
        {
            _hotelSearchPage.Search("MVD");
        }
        
        [When(@"I have added to cart the selected hotel room")]
        public void WhenIHaveAddedToCartTheSelectedHotelRoom()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have checked out")]
        public void WhenIHaveCheckedOut()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"room should be booked")]
        public void ThenRoomShouldBeBooked()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
using HOTELpinSight;
using HOTELpinSight.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using System.Configuration;
using SFAutomationFramework.Pages;

namespace SFAutomationFramework.Steps
{ 
    [Binding]
    public class E2EHotelFlowSteps
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        //private HotelSearchPage _hotelSearchPage;
        private SearchingPage _searchingPage;
        //private ResultsPage _resultsPage;
        private CheckOutPage _checkOutPage;

        //Parmeters Choose traveler
        string paxNameOne = "Hector Norte";

        //Parameters Credit Card
        string cardName = "Rohan Pandit";
        string cardNumber = "4111111111111111";
        string cvvNumber = "123";
        string nameCard = "Rohan Pandit";
        string expMonth = "Apr";
        string expYear = "2018";

        //Parameters Billing Address
        string addressLine1 = "Legacy Drive Suite 53600";
        string city = "Piano";
        string country = "United States";
        string zip = "75034";
        string state = "Texas";
        
        //Parameters Comminication Details
        string phoneBilling = "89890898875";

        //Expected string at successfull book, confirmation page
        string expectedMessage = "Your reservation is booked. No need to call us to reconfirm this reservation.";

        string browserName = ConfigurationManager.AppSettings["BROWSER"];

        [Given(@"I have entered to pinSight application")]
        public void GivenIHaveEnteredToPinSightApplication()
        {
            _driver = WebDriverFactory.Create();
            LoginPage login = new LoginPage(_driver);
            
            _loginPage = LoginPage.NavigateTo(_driver);
            string userConf = ConfigurationManager.AppSettings["USER"];
            string passConf = ConfigurationManager.AppSettings["PASS"];
            _loginPage.EnterCredentials(userConf, passConf);            
        }
        
        [When(@"I enter (.*) to search hotel")]
        public void WhenIEnterCityToSearchHotel(string city)
        {
            city = "NYC";
            HotelSearchPage hotelSearch = new HotelSearchPage(_driver);
            hotelSearch.Search(city);
            hotelSearch.SelectOneAdult();
            hotelSearch.ClickSearch();
        }
        
        [When(@"I have added to cart the selected hotel room")]
        public void WhenIHaveAddedToCartTheSelectedHotelRoom()
        {
            ResultsPage hotelResults = new ResultsPage(_driver);
            hotelResults.ClickShowRooms();
            //hotelResults.ClickAmenities();
            HotelDetailsPage hotelDetails = new HotelDetailsPage(_driver);            
            hotelDetails.ClickAddToCart();
            //hotelResults.ClickCheckOutButton();
        }
        
        [When(@"I have checked out")]
        public void WhenIHaveCheckedOut()
        {
            CheckOutPage hotelCheckOut = new CheckOutPage(_driver);
            hotelCheckOut.SelectPax(paxNameOne);
            hotelCheckOut.EnterCreditCard(cardName, cardNumber, cvvNumber, expMonth, expYear);
            hotelCheckOut.EnterBillingAddress(addressLine1, country, state, city, zip);
            hotelCheckOut.EnterCommunicationDetails(phoneBilling);
            hotelCheckOut.CheckAgreement();
        }
        
        [Then(@"room should be booked")]
        public void ThenRoomShouldBeBooked()
        {
            ConfirmationPage hotelConfirmation = new ConfirmationPage(_driver);
            hotelConfirmation.CheckConfNum();

            //Assert.IsTrue(expectedMessage
        }
    }
}

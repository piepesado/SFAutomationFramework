using HOTELpinSight;
using HOTELpinSight.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;
using System.Configuration;
using SFAutomationFramework.Pages;
using System;

namespace SFAutomationFramework.Steps
{ 
    [Binding]
    public class E2EHotelFlowSteps
    {
        private IWebDriver _driver;          
        
        //Parmeters Choose traveler
        string paxNameOne = "Hector Norte";

        //Parameters Credit Card
        string cardName = "Rohan Pandit";
        string cardNumber = "4111111111111111";
        string cvvNumber = "123";
        string nameCard = "Rohan Pandit";
        string expMonth = "April";
        string expYear = "2018";

        //Parameters Billing Address
        string addressLine1 = "Legacy Drive Suite 53600";
        string city = "Piano";
        string country = "United States";
        string zip = "75034";
        string state = "TX";
        
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
            
            login = LoginPage.NavigateTo(_driver);
            string userConf = ConfigurationManager.AppSettings["USER"];
            string passConf = ConfigurationManager.AppSettings["PASS"];
            login.EnterCredentials(userConf, passConf);            
        }
        
        [When(@"I enter (.*) to search hotel")]
        public void WhenIEnterCityToSearchHotel(string city)
        {
            // city = "NYC";
            HotelSearchPage hotelSearch = new HotelSearchPage(_driver);
            hotelSearch.Search(city);
            hotelSearch.SelectOneAdult();

            // HACK -- need to sleep for the date control to render.
            Thread.Sleep(2000);

            hotelSearch.ClickSearch();
        }
        
        [When(@"I have added to cart the selected hotel room")]
        public void WhenIHaveAddedToCartTheSelectedHotelRoom()
        {
            ResultsPage hotelResults = new ResultsPage(_driver);
            hotelResults.EnsurePageIsLoaded();

            hotelResults.ClickShowRooms();
            //hotelResults.ClickAmenities();
            HotelDetailsPage hotelDetails = new HotelDetailsPage(_driver);            
            hotelDetails.ClickAddToCart();
            hotelDetails.ClickCheckOutButton();
        }
        
        [When(@"I have checked out")]
        public void WhenIHaveCheckedOut()
        {
            CheckOutPage hotelCheckOut = new CheckOutPage(_driver);
            hotelCheckOut.EnsurePageIsLoaded();
            hotelCheckOut.SelectPassengerDropDown();
            hotelCheckOut.EnterCreditCard(cardName, cardNumber, cvvNumber, expMonth, expYear);
            hotelCheckOut.EnterBillingAddress(addressLine1, country, state, city, zip);            
            hotelCheckOut.EnterCommunicationDetails(phoneBilling);
            hotelCheckOut.CheckAgreement();
            hotelCheckOut.ClickConfirmBook();
        }
        
        [Then(@"room should be booked")]
        public void ThenRoomShouldBeBooked()
        {
            ConfirmationPage hotelConfirmation = new ConfirmationPage(_driver);
            hotelConfirmation.CheckConfNum();

            //Assert.IsTrue(expectedMessage
        }

        /// <summary>
        /// Clean up the 
        /// </summary>
        [AfterScenario]
        public void Cleanup()
        {
            try
            {
                if (_driver != null)
                {
                    _driver.Close();
                    _driver.Dispose();
                    _driver = null;
                }
            }
            catch (Exception)
            {
                // We will swallow any exceptions in the cleanup step.
            }
        }
    }
}

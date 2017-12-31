using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace HOTELpinSight.Pages
{
    public class ResultsPage : BasePage
    {
        public ResultsPage(IWebDriver driver) : base(driver)
        {
        }

        //MAP and CARD views common elements
        [FindsBy(How = How.Id, Using = "mapGoogle")]
        private IWebElement _googleMap;

        [FindsBy(How = How.Id, Using = "hotelnamesearch")]
        private IWebElement _searchHotelByName;

        [FindsBy(How = How.Id, Using = "sortby")]
        private IWebElement _sortByCombo;

        [FindsBy(How = How.Id, Using = "filterIcon")]
        private IWebElement _filterButton;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) section.map-container:nth-child(2) t-hotel-map-results-page.x-scope.t-hotel-map-results-page-0 div.google-map-wrapper.style-scope.t-hotel-map-results-page:nth-child(2) div.gmap-left-col.style-scope.t-hotel-map-results-page:nth-child(6) t-hotel-result-item.listing-result-item.style-scope.t-hotel-map-results-page.x-scope.t-hotel-result-item-0:nth-child(4) div.hotel-detail-wrap.clearfix.style-scope.t-hotel-result-item div.hoteldetails.style-scope.t-hotel-result-item div.pvs.amenities-wrap.clearfix.style-scope.t-hotel-result-item div.trustscore-wrap.style-scope.t-hotel-result-item div.text-right.btn-show-rooms-wrap.style-scope.t-hotel-result-item t-button.btn-show-rooms.style-scope.t-hotel-result-item.x-scope.t-button-1 paper-button.style-scope.t-button.x-scope.paper-button-0:nth-child(1) > span.style-scope.t-button:nth-child(1)")]
        private IWebElement _searchRoomsButton;

        [FindsBy(How = How.Id, Using = "cardicon")]
        private IWebElement _cardView;

        [FindsBy(How = How.Id, Using = "mapicon")]
        private IWebElement _mapView;

        //CARD view elements
        //Try to find filter sliders identifiers.

        //Hotel Details pop up
        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) section.map-container:nth-child(2) t-hotel-map-results-page.x-scope.t-hotel-map-results-page-0 div.google-map-wrapper.style-scope.t-hotel-map-results-page:nth-child(2) div.gmap-right-col.style-scope.t-hotel-map-results-page:nth-child(7) div.modal.fade.in.modal-hotel-detail.style-scope.t-hotel-map-results-page div.modal-dialog.style-scope.t-hotel-map-results-page div.modal-content.style-scope.t-hotel-map-results-page div.style-scope.t-hotel-map-results-page iron-pages.style-scope.t-hotel-map-results-page:nth-child(6) div.results_tab_content.roooms.clearfix.style-scope.t-hotel-map-results-page.iron-selected:nth-child(2) t-hotel-room-list.style-scope.t-hotel-map-results-page.x-scope.t-hotel-room-list-0 div.style-scope.t-hotel-room-list div.style-scope.t-hotel-room-list:nth-child(8) t-hotel-room-item.style-scope.t-hotel-room-list.x-scope.t-hotel-room-item-0:nth-child(2) div.roomsrow.border-btm-blue.style-scope.t-hotel-room-item div.new-room-wrap.row.layout.horizontal.style-scope.t-hotel-room-item div.col-sm-3.text-right.style-scope.t-hotel-room-item div.price_box01.ptm.style-scope.t-hotel-room-item:nth-child(6) t-button.primary.style-scope.t-hotel-room-item.x-scope.t-button-2:nth-child(2) paper-button.style-scope.t-button.x-scope.paper-button-0:nth-child(1) > span.style-scope.t-button:nth-child(1)")]
        private IWebElement _addToCartButton;

        //Add to cart confirmation pop up
        [FindsBy(How = How.Id, Using = "btnCheckOutCart")]
        private IWebElement _checkOutButton;

        [FindsBy(How = How.Id, Using = "btnCartContinue")]
        private IWebElement _continueShopping;

        //Actions

        public void ClickCardView()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_cardView));
            _cardView.Click();
        }
        
        public void ClickShowRooms()
        {            
            WaitForElementVisible(_searchRoomsButton);                          
            _searchRoomsButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _searchRoomsButton);            
        }


        public void ClickAddToCart()
        {
            Actions clickAddCart = new Actions(_driver);
            WaitForElementVisible(_addToCartButton);
            clickAddCart.MoveToElement(_addToCartButton).Perform();
            clickAddCart.Click(_addToCartButton);            
            clickAddCart.Build();
            clickAddCart.Perform();
            //_addToCartButton.Click();
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _addToCartButton);
        }

        public void ClickCheckOutButton()
        {
            WaitForElementVisible(_checkOutButton);
            _checkOutButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _checkOutButton);
        }

        public void CheckImAtCheckOut()
        {
            WaitForElementVisible(_checkOutButton);
        }        

        /*
        public void ClickCheckOut()
        {
            WaitForElementVisible(_checkOutButton);
            _checkOutButton.Click();
        };
        */

        public CheckOutPage ClickSearch()
        {
            _checkOutButton.Click();
            return new CheckOutPage(_driver);
        }
    }
}

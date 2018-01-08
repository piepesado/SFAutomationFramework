﻿using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SFAutomationFramework.Pages;

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
        [FindsBy(How = How.Id, Using = "text-button")]
        private IWebElement _addToCartButton;

        //Add to cart confirmation pop up
        [FindsBy(How = How.Id, Using = "btnCheckOutCart")]
        private IWebElement _checkOutButton;

        [FindsBy(How = How.Id, Using = "btnCartContinue")]
        private IWebElement _continueShopping;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) section.map-container:nth-child(2) t-hotel-map-results-page.x-scope.t-hotel-map-results-page-0 div.google-map-wrapper.style-scope.t-hotel-map-results-page:nth-child(2) div.gmap-right-col.style-scope.t-hotel-map-results-page:nth-child(7) div.modal.fade.in.modal-hotel-detail.style-scope.t-hotel-map-results-page div.modal-dialog.style-scope.t-hotel-map-results-page div.modal-content.style-scope.t-hotel-map-results-page div.style-scope.t-hotel-map-results-page div.clearfix.style-scope.t-hotel-map-results-page:nth-child(2) div.clearfix.style-scope.t-hotel-map-results-page:nth-child(4) paper-tabs.rooms_details.style-scope.t-hotel-map-results-page.x-scope.paper-tabs-0 div.style-scope.paper-tabs:nth-child(2) div.fit-container.style-scope.paper-tabs paper-tab.style-scope.t-hotel-map-results-page.x-scope.paper-tab-0:nth-child(4) > div.tab-content.style-scope.paper-tab")]
        private IWebElement _amenitiesTab;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) section.map-container:nth-child(2) t-hotel-map-results-page.x-scope.t-hotel-map-results-page-0 div.google-map-wrapper.style-scope.t-hotel-map-results-page:nth-child(2) div.gmap-right-col.style-scope.t-hotel-map-results-page:nth-child(7) div.modal.fade.in.modal-hotel-detail.style-scope.t-hotel-map-results-page div.modal-dialog.style-scope.t-hotel-map-results-page div.modal-content.style-scope.t-hotel-map-results-page div.style-scope.t-hotel-map-results-page div.clearfix.style-scope.t-hotel-map-results-page:nth-child(2) div.clearfix.style-scope.t-hotel-map-results-page:nth-child(4) paper-tabs.rooms_details.style-scope.t-hotel-map-results-page.x-scope.paper-tabs-0 div.style-scope.paper-tabs:nth-child(2) div.fit-container.style-scope.paper-tabs paper-tab.style-scope.t-hotel-map-results-page.x-scope.paper-tab-0.iron-selected:nth-child(3) > div.tab-content.style-scope.paper-tab")]
        private IWebElement _roomDetailsTab;

        //Actions

        public void ClickCardView()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_cardView));
            _cardView.Click();
        }       

        public void CheckImAtCheckOut()
        {
            WaitForElementVisible(_checkOutButton);
        }        

        public HotelDetailsPage ClickShowRooms()
        {
            // Old way with CSS selector
            //WaitForElementVisible(_searchRoomsButton);
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _searchRoomsButton);
            //_searchRoomsButton.Click();

            // This is a hack for the pinSIGHT hotel page because the hotel details
            // are displayed in a popup dialog in the browser. Essentially, the dialog
            // is overlayed on top of the existing page. We need to account for the delay
            // in rendering the popup.

            IWebElement showRoomsButton = null;

            for (int i = 0; i < 120; i++)
            {
                var buttons = _driver.FindElements(By.TagName("t-button"));
                showRoomsButton = buttons.FirstOrDefault(e => e.Text.Equals("SHOW ROOMS", StringComparison.InvariantCultureIgnoreCase));
                if (showRoomsButton == null)
                {
                    // Wait for a second and attempt to find it again.
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    // We have the button. Break out.
                    break;
                }
            }

            if (showRoomsButton == null)
            {
                throw new Exception("Failed to find a SHOW ROOMS button on the hotel search result page.");
            }

            WaitForElementVisible(showRoomsButton);

            // Wait for some time for rendering to be complete.
            Thread.Sleep(2000);
            showRoomsButton.Click();

            return new HotelDetailsPage(_driver);

        }

        public void EnsurePageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.Title.Contains("Hotel Result"));
        }
    }
}

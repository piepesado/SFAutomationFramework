using HOTELpinSight.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFAutomationFramework.Pages
{
    public class HotelDetailsPage : BasePage
    {
        public HotelDetailsPage(IWebDriver driver) : base(driver)
        {
        }

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

        //Hotel Details pop up Actions

        public void ClickAddToCart()
        {
            WaitForElementVisible(_addToCartButton);
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click()", _addToCartButton);
            _addToCartButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _addToCartButton);

            /*
            Actions clickAddCart = new Actions(_driver);
            clickAddCart.MoveToElement(_addToCartButton).Perform();
            clickAddCart.Click(_addToCartButton);
            
            clickAddCart.Build();
            clickAddCart.Perform();
            //_addToCartButton.Click();
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _addToCartButton);                     
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click()", _addToCartButton);
            */
        }
    }
}

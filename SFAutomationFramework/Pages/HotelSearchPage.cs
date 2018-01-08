using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;

namespace HOTELpinSight.Pages
{
    public class HotelSearchPage : BasePage
    {

        public HotelSearchPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "ucPWP_ctl08_55218_lnkGoToBackOffice")]
        private IWebElement _backOfficeButton;

        [FindsBy(How = How.Id, Using = "autoSuggest")]
        private IWebElement _search;

        [FindsBy(How = How.CssSelector, Using = "#dropBox>ul>li:nth-child(1)")]
        private IWebElement _searchOption;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.home-wrapper section.main-content:nth-child(2) div.container:nth-child(2) div.row div.col-sm-12.col-md-4:nth-child(1) div.search-form tlg-search-widget.x-scope.tlg-search-widget-0:nth-child(2) tlg-hotel-search-page.style-scope.tlg-search-widget.x-scope.tlg-hotel-search-page-0:nth-child(1) tlg-hotel-search.style-scope.tlg-hotel-search-page.x-scope.tlg-hotel-search-0:nth-child(2) div.search-comp-room-added.style-scope.tlg-hotel-search div.search-comp-room-passenger.style-scope.tlg-hotel-search tlg-search-passenger.style-scope.tlg-hotel-search.x-scope.tlg-search-passenger-0:nth-child(2) div.search-comp-room-pax.style-scope.tlg-search-passenger div.stepper-wrap.horizontal-margin-right.style-scope.tlg-search-passenger:nth-child(1) t-stepper.flex.style-scope.tlg-search-passenger.x-scope.t-stepper-0 div.layout.horizontal.center.style-scope.t-stepper div.layout.horizontal.center.style-scope.t-stepper:nth-child(5) > iron-icon.style-scope.t-stepper.x-scope.iron-icon-0")]
        private IWebElement _minusAdult;


        //Not sure about the identifiers

        //Datepickers
        [FindsBy(How = How.Id, Using = "input")]
        private IWebElement _checkInDatePicker;
        
        [FindsBy(How = How.LinkText, Using = "Pick a year from the dropdown")]
        private IWebElement _checkInDatePickerYear;

        [FindsBy(How = How.LinkText, Using = "Pick a month from the dropdown")]
        private IWebElement _checkInDatePickerMonth;

        [FindsBy(How = How.LinkText, Using = "Go to the previous month")]
        private IWebElement _checkInDatePickerNavBack;

        [FindsBy(How = How.LinkText, Using = "Go to the next month")]
        private IWebElement _checkInDatePickerNavNext;
        

        [FindsBy(How = How.Id, Using = "input")]
        private IWebElement _checkOutDatePicker;

        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement _searchButton;

        //[FindsBy(How = How.Name, Using = "check-in-date")]
        //private IWebElement _checkinDate;

        public void SelectOneAdult()
        {
            Actions selectOne = new Actions(_driver);
            selectOne.MoveToElement(_minusAdult);
            selectOne.Click(_minusAdult);
            selectOne.Build();
            selectOne.Perform();
        }

        //Candidate for Base page actions
        public void Search(string value)
        {
            WaitForElementVisible(_search);
            _search.SendKeys(value);
            WaitForElementVisible(_searchOption);
            Actions selectLoc = new Actions(_driver);
            selectLoc.MoveToElement(_searchOption);
            selectLoc.Click(_searchOption);           
            selectLoc.Build();
            selectLoc.Perform();
        }

        //Calendars

        public void SelectCheckIn()
        {                    
            Actions selectCheckIn = new Actions(_driver);
            selectCheckIn.MoveToElement(_checkInDatePicker);
            //WaitForElementVisible(_checkInDatePicker);
            _checkInDatePicker.Click();
            if(_checkInDatePickerYear.Text != "2018")
                new SelectElement(_checkInDatePickerYear).SelectByValue("2018");
            new SelectElement(_checkInDatePickerMonth).SelectByValue("January");

            IList<IWebElement> rows = _checkInDatePicker.FindElements(By.TagName("tr"));
            IList<IWebElement> columns = _checkInDatePicker.FindElements(By.TagName("td"));

            foreach(IWebElement cell in columns)
            {
                if (cell.ToString().Equals("6"))
                {
                    cell.FindElement(By.LinkText("6")).Click();
                    break;
                }
            }
            selectCheckIn.Perform();            
        }

        public void SelectCheckOut()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("document.getElementById('input').removeAttribute('readonly',0);"); // Enables the from date box

            
            _checkOutDatePicker.Clear();
            _checkOutDatePicker.SendKeys("01/10/2018"); //Enter date in required format
        }

        public void EnsurePageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_backOfficeButton));
        }

        public SearchingPage ClickSearch()
        {
            _searchButton.Click();
            return new SearchingPage(_driver);
        }
    }
}

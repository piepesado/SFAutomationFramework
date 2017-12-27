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

        public void Search(string value)
        {
            WaitForElementVisible(_search);
            _search.SendKeys(value);
            WaitForElementVisible(_searchOption);
            Actions selectLoc = new Actions(_driver);
            selectLoc.MoveToElement(_searchOption);
            selectLoc.Click(_searchOption);
           // WaitForElementVisible(_checkInDatePicker);
            selectLoc.Build();
            selectLoc.Perform();
        }

        //Calendars

        public void SelectCheckIn()
        {
            //WaitForElementVisible(_checkInDatePicker);
            //((IJavaScriptExecutor)_driver).ExecuteScript("document.getElementById('input').removeAttribute('readonly',0);"); // Enables the from date box


            //_checkInDatePicker.Clear();
            //_checkInDatePicker.SendKeys("10/01/2018"); //Enter date in required format

            
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

        /*
        public void SelectCheckOut()
        {
            Actions selectCheckOut = new Actions(_driver);
            selectCheckOut.MoveToElement(_checkOutDatePicker);
            _checkInDatePicker.Click();
            if (_checkInDatePicker.Text != "2018")
                new SelectElement(_checkOutDatePickerYear).SelectByValue("2018");
            new SelectElement(_checkOutDatePickerMonth).SelectByValue("May");

            IList<IWebElement> rows = _checkInDatePicker.FindElements(By.TagName("tr"));
            IList<IWebElement> columns = _checkInDatePicker.FindElements(By.TagName("td"));

            foreach (IWebElement cell in columns)
            {
                if (cell.ToString().Equals("6"))
                {
                    cell.FindElement(By.LinkText("6")).Click();
                    break;
                }
            }

            selectCheckIn.Perform();
        }

        public void ClickSearchHotel()
        {
            _searchButton.Click();
        }
        */

        /*
        public void ClickSearchHotel()
        {
            _searchButton.Click();
        }
        */

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

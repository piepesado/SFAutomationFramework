using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using SFAutomationFramework.Pages;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace HOTELpinSight.Pages
{
    public class CheckOutPage : BasePage
    {
        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        //Pax Info
        [FindsBy(How = How.Id, Using = "dLabel0")]
        private IWebElement _pax1;

        [FindsBy(How = How.Id, Using = "ddlTraveller0")]
        private IWebElement _passenger1FromSelectList;

        [FindsBy(How = How.Id, Using = "dLabel1")]
        private IWebElement _pax2;

        //Credit Card details
        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.style-scope.tlg-payment-item:nth-child(1) fieldset.form-group.style-scope.tlg-payment-item > input.form-control.style-scope.tlg-payment-item")]
        private IWebElement _cardNumber;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-payment-item:nth-child(2) fieldset.form-group.style-scope.tlg-payment-item div.row.style-scope.tlg-payment-item div.col-sm-10.style-scope.tlg-payment-item > input.form-control.style-scope.tlg-payment-item")]
        private IWebElement _cvv2;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.style-scope.tlg-payment-item:nth-child(3) fieldset.form-group.style-scope.tlg-payment-item > input.form-control.style-scope.tlg-payment-item")]
        private IWebElement _nameCard;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.col-md-4.style-scope.tlg-payment-item:nth-child(4) fieldset.form-group.style-scope.tlg-payment-item div.row.style-scope.tlg-payment-item div.col-sm-6.style-scope.tlg-payment-item:nth-child(1) > select.form-control.style-scope.tlg-payment-item")]
        private IWebElement _expDateMonth;

        //Credit card expiration dates
        [FindsBy(How = How.Id, Using = "dLabel0")]
        private IWebElement _clickDropDownPax;

        [FindsBy(How = How.Id, Using = "ddlTraveller0")]
        private IWebElement _guestSelect;

        internal void EnsurePageIsLoaded()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.Title.Contains("Checkout"));
            Thread.Sleep(2000);
        }

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.col-md-4.style-scope.tlg-payment-item:nth-child(4) fieldset.form-group.style-scope.tlg-payment-item div.row.style-scope.tlg-payment-item div.col-sm-6.style-scope.tlg-payment-item:nth-child(2) > select.form-control.style-scope.tlg-payment-item")]
        private IWebElement _expDateYear;

        //Billig Address

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(2) div.col-sm-6.style-scope.tlg-billing-address:nth-child(1) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement _address1;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(1) fieldset.form-group.style-scope.tlg-billing-address > select.form-control.style-scope.tlg-billing-address")]
        private IWebElement _country;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(2) fieldset.form-group.style-scope.tlg-billing-address > select.form-control.style-scope.tlg-billing-address:nth-child(3)")]
        private IWebElement _state;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(3) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement _city;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(4) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement _zip;

        //Communication Details

        [FindsBy(How = How.Id, Using = "cPhone")]
        private IWebElement _phoneNumber;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(4) fieldset.form-group.style-scope.tlg-billing-address > label.text_bold.clr-54.style-scope.tlg-billing-address")]
        private IWebElement _email;

        //Agreement checkbox

        [FindsBy(How = How.Id, Using = "chkTerms")]
        private IWebElement _chkAgreement;

        //Complete Booking button

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-communication-details.style-scope.tlg-trip-summary:nth-child(4) div.product-header.style-scope.tlg-communication-details div.row.checkout-comm-details.layout.horizontal.style-scope.tlg-communication-details div.col-sm-5.col-md-4.text-right.layout.vertical.end-justified.style-scope.tlg-communication-details div.text-right.ptm.style-scope.tlg-communication-details:nth-child(4) > button.btn.btn-warning.style-scope.tlg-communication-details")]
        private IWebElement _completeBookButton;

        //Actions

        public void SelectPax(string namePax1)
        {
            _pax1.Click();
            Thread.Sleep(1000);
            _passenger1FromSelectList.Click();
            Thread.Sleep(1000);
        }

        public void EnterCreditCard(string name, string number, string cvv, string expMonth, string expYear)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _cardNumber);
            WaitForElementVisible(_cardNumber);
            _cardNumber.SendKeys(number);
            _cardNumber.SendKeys(Keys.Tab);
            _cvv2.SendKeys(cvv);
            _cvv2.SendKeys(Keys.Tab);
            _nameCard.SendKeys(name);
            _nameCard.SendKeys(Keys.Tab);
            new SelectElement(_expDateMonth).SelectByText(expMonth);
            new SelectElement(_expDateYear).SelectByText(expYear);
        }

        public void SelectPassengerDropDown()
        {
            WaitForElementVisible(_clickDropDownPax);
            _clickDropDownPax.Click();
            WaitForElementVisible(_guestSelect);
            _guestSelect.Click();
        }

        public void EnterBillingAddress(string address, string country, string state, string city, string zip)
        {
            WaitForElementVisible(_address1);
            _address1.SendKeys(address);
            _address1.SendKeys(Keys.Tab);
            new SelectElement(_country).SelectByText(country);
            WaitForElementVisible(_state);
            new SelectElement(_state).SelectByValue(state);
            _city.SendKeys(city);
            _city.SendKeys(Keys.Tab);
            //Thread.Sleep(2000);
            _zip.SendKeys(zip);                      
        }

        public void EnterCommunicationDetails(string phone)
        {
            WaitForElementVisible(_phoneNumber);
            _phoneNumber.SendKeys(phone);
            _phoneNumber.SendKeys(Keys.End);
        }

        public void CheckAgreement()
        {            
            WaitForElementVisible(_chkAgreement);
            Actions clickCheck = new Actions(_driver);
            clickCheck.MoveToElement(_chkAgreement).Perform();
            clickCheck.Click(_chkAgreement);
            clickCheck.Build();
            clickCheck.Perform();
            
            //((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", _chkAgreement);                   
            
        }

        public ConfirmationPage ClickConfirmBook()
        {
            WaitForElementVisible(_completeBookButton);
            _completeBookButton.Click();
            return new ConfirmationPage(_driver);
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

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

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(3) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement _zip;

        //Communication Details

        [FindsBy(How = How.Id, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-communication-details.style-scope.tlg-trip-summary:nth-child(4) div.product-header.style-scope.tlg-communication-details div.row.checkout-comm-details.layout.horizontal.style-scope.tlg-communication-details div.col-sm-7.col-md-8.style-scope.tlg-communication-details div.row.ptm.style-scope.tlg-communication-details:nth-child(3) div.col-sm-12.col-md-6.style-scope.tlg-communication-details:nth-child(1) fieldset.form-group.style-scope.tlg-communication-details > input.form-control.style-scope.tlg-communication-details")]
        private IWebElement _phoneNumber;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-communication-details.style-scope.tlg-trip-summary:nth-child(4) div.product-header.style-scope.tlg-communication-details div.row.checkout-comm-details.layout.horizontal.style-scope.tlg-communication-details div.col-sm-7.col-md-8.style-scope.tlg-communication-details div.row.ptm.style-scope.tlg-communication-details:nth-child(3) div.col-sm-12.col-md-6.style-scope.tlg-communication-details:nth-child(2) fieldset.form-group.style-scope.tlg-communication-details > input.form-control.style-scope.tlg-communication-details")]
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
            WaitForElementVisible(_pax1);
            new SelectElement(_pax1).SelectByValue(namePax1);
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
            new SelectElement(_expDateMonth).SelectByValue(expMonth);
            new SelectElement(_expDateYear).SelectByValue(expYear);
        }

        public void EnterBillingAddress(string address, string country, string state, string city, string zip)
        {
            WaitForElementVisible(_address1);
            _address1.SendKeys(address);
            _address1.SendKeys(Keys.Tab);
            new SelectElement(_country).SelectByValue(country);
            new SelectElement(_state).SelectByValue(state);
            _city.SendKeys(city);
            _city.SendKeys(Keys.Tab);
            _zip.SendKeys(zip);
        }

        public void EnterCommunicationDetails(string phone)
        {
            WaitForElementVisible(_phoneNumber);
            _phoneNumber.SendKeys(phone);
        }

        public void CheckAgreement()
        {
            WaitForElementVisible(_chkAgreement);
            _chkAgreement.Click();
        }
    }
}

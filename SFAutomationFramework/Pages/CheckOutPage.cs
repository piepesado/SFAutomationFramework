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
        private IWebElement pax1;

        [FindsBy(How = How.Id, Using = "dLabel1")]
        private IWebElement pax2;

        //Credit Card details
        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.style-scope.tlg-payment-item:nth-child(1) fieldset.form-group.style-scope.tlg-payment-item > input.form-control.style-scope.tlg-payment-item")]
        private IWebElement cardNumber;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-payment-item:nth-child(2) fieldset.form-group.style-scope.tlg-payment-item div.row.style-scope.tlg-payment-item div.col-sm-10.style-scope.tlg-payment-item > input.form-control.style-scope.tlg-payment-item")]
        private IWebElement cvv2;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.style-scope.tlg-payment-item:nth-child(3) fieldset.form-group.style-scope.tlg-payment-item > input.form-control.style-scope.tlg-payment-item")]
        private IWebElement nameCard;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.col-md-4.style-scope.tlg-payment-item:nth-child(4) fieldset.form-group.style-scope.tlg-payment-item div.row.style-scope.tlg-payment-item div.col-sm-6.style-scope.tlg-payment-item:nth-child(1) > select.form-control.style-scope.tlg-payment-item")]
        private IWebElement expDateMonth;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item div.ptl.style-scope.tlg-payment-item:nth-child(2) div.row.style-scope.tlg-payment-item:nth-child(3) div.col-sm-6.col-md-4.style-scope.tlg-payment-item:nth-child(4) fieldset.form-group.style-scope.tlg-payment-item div.row.style-scope.tlg-payment-item div.col-sm-6.style-scope.tlg-payment-item:nth-child(2) > select.form-control.style-scope.tlg-payment-item")]
        private IWebElement expDateYear;

        //Billig Address

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(2) div.col-sm-6.style-scope.tlg-billing-address:nth-child(1) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement address1;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(1) fieldset.form-group.style-scope.tlg-billing-address > select.form-control.style-scope.tlg-billing-address")]
        private IWebElement country;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(2) fieldset.form-group.style-scope.tlg-billing-address > select.form-control.style-scope.tlg-billing-address:nth-child(3)")]
        private IWebElement state;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(3) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement city;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-multi-payment.style-scope.tlg-trip-summary:nth-child(3) div.pll.prl.style-scope.tlg-multi-payment tlg-payment-item.single.style-scope.tlg-multi-payment:nth-child(3) div.card-detail.style-scope.tlg-payment-item tlg-billing-address.style-scope.tlg-payment-item:nth-child(3) div.ptl.style-scope.tlg-billing-address div.ptl.style-scope.tlg-billing-address div.row.style-scope.tlg-billing-address:nth-child(3) div.col-sm-6.col-md-3.style-scope.tlg-billing-address:nth-child(3) fieldset.form-group.style-scope.tlg-billing-address > input.form-control.style-scope.tlg-billing-address")]
        private IWebElement zip;

        //Communication Details

        [FindsBy(How = How.Id, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-communication-details.style-scope.tlg-trip-summary:nth-child(4) div.product-header.style-scope.tlg-communication-details div.row.checkout-comm-details.layout.horizontal.style-scope.tlg-communication-details div.col-sm-7.col-md-8.style-scope.tlg-communication-details div.row.ptm.style-scope.tlg-communication-details:nth-child(3) div.col-sm-12.col-md-6.style-scope.tlg-communication-details:nth-child(1) fieldset.form-group.style-scope.tlg-communication-details > input.form-control.style-scope.tlg-communication-details")]
        private IWebElement phoneNumber;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-communication-details.style-scope.tlg-trip-summary:nth-child(4) div.product-header.style-scope.tlg-communication-details div.row.checkout-comm-details.layout.horizontal.style-scope.tlg-communication-details div.col-sm-7.col-md-8.style-scope.tlg-communication-details div.row.ptm.style-scope.tlg-communication-details:nth-child(3) div.col-sm-12.col-md-6.style-scope.tlg-communication-details:nth-child(2) fieldset.form-group.style-scope.tlg-communication-details > input.form-control.style-scope.tlg-communication-details")]
        private IWebElement email;

        //Agreement checkbox

        [FindsBy(How = How.Id, Using = "chkTerms")]
        private IWebElement chkAgreement;

        //Complete Booking button

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row.jsPreloaderHiddenContainer:nth-child(1) div.col-sm-12.col-md-12 div.RightPanel:nth-child(2) div.bg-white.border-top.mbl:nth-child(2) tlg-trip-summary.x-scope.tlg-trip-summary-0 tlg-communication-details.style-scope.tlg-trip-summary:nth-child(4) div.product-header.style-scope.tlg-communication-details div.row.checkout-comm-details.layout.horizontal.style-scope.tlg-communication-details div.col-sm-5.col-md-4.text-right.layout.vertical.end-justified.style-scope.tlg-communication-details div.text-right.ptm.style-scope.tlg-communication-details:nth-child(4) > button.btn.btn-warning.style-scope.tlg-communication-details")]
        private IWebElement completeBookButton;

        //Actions


    }
}

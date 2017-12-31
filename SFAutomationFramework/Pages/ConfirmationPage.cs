using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTELpinSight.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SFAutomationFramework.Pages
{
    public class ConfirmationPage : BasePage
    {
        public ConfirmationPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "confirmation-number")]
        private IWebElement _confirmationNumber;

        [FindsBy(How = How.CssSelector, Using = "div.wrapper.master-wrapper section.main-content:nth-child(2) div.container div.row:nth-child(1) div.col-sm-12.col-md-12 div.LeftPanel div:nth-child(1) div:nth-child(1) div.order-summary-wrap.bg-white.border-top div.pal:nth-child(1) > div.f-16.color-84.pts.pbl")]
        private IWebElement _successMessage;

        //Actions
        public void CheckConfNum()
        {
            WaitForElementVisible(_confirmationNumber);
        }
    }
}

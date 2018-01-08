﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using System.Threading;

namespace HOTELpinSight.Pages
{
    /// <summary>
    /// The base class implementation of a page.
    /// </summary>
    public class BasePage
    {
        protected IWebDriver _driver;

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="driver"></param>
        public BasePage(IWebDriver driver)
        {
            _driver = driver ?? throw new ArgumentNullException(nameof(driver));
            PageFactory.InitElements(_driver, this);
        }

        /// <summary>
        /// Wait for an element to be visible.
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NoSuchElementException"></exception>"
        public void WaitForElementVisible(IWebElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));

            // This loop is a hack to wait for the element to be rendered on a page. This is
            // useful for HTML that is dynamically generated by a Javascript framework.
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    wait.Until(d => element.Displayed);
                    break;
                }
                catch (Exception)
                {
                    Thread.Sleep(1000);
                }
            }

        }

        //Add this method to Framework
        public void EnsurePageIsLoaded(string pageTitle)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            wait.Until(d => d.Title.Contains(pageTitle));
            Thread.Sleep(2000);
        }

        /// <summary>
        /// Enters user strings
        /// </summary>
        /// <param name="element"></param>   
        /// <param name="text"></param>  
        public void SetElementText(IWebElement element, string text)
        {
            WaitForElementVisible(element);
            element.Clear();
            element.Click();
            Assert.Equals(element.GetAttribute("value"), text);
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace HOTELpinSight.Pages
{
    /// <summary>
    /// The login page for the pinSight Hotel platform.
    /// </summary>
    public class LoginPage : BasePage
    {       

        [FindsBy(How = How.Id, Using = "userName")]
        private IWebElement _username;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _passWord;
        

        [FindsBy(How = How.Id, Using = "SubmitButton")]
        private IWebElement _signInButton;

        public string Username
        {
            get
            {
                return _username.Text;
            }
            set
            {
                _username.SendKeys(value);
            }
        }

        public string Password
        {
            set
            {
                _passWord.SendKeys(value);
            }
        }        

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Navigate to the page.
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static LoginPage NavigateTo(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver));
            }

            //driver.Navigate().GoToUrl(PAGE_URL);
            driver.Url = ConfigurationManager.AppSettings["QA_URL"];
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.StartsWith("Login"));
            return new LoginPage(driver);
        }

        /// <summary>
        /// Click the login button.
        /// </summary>
        /// <returns></returns>
        public HotelSearchPage Login()
        {
            _signInButton.Click();
            return new HotelSearchPage(_driver);
        }

        /// <summary>
        /// Log into the application using the given credentials.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public HotelSearchPage Login(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            HotelSearchPage hotelSearchPage = Login();
            return hotelSearchPage;
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace UITests
{
    public class DriverInit
    {
        IWebDriver _driver;
        string url = "http://localhost:8080/Default.aspx";

        public IWebDriver GetDriver()
        {
            InitiateDriver();
            return _driver;
        }

        public void InitiateDriver()
        {
            _driver = new FirefoxDriver();
            _driver.Url = url;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}
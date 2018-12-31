using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace UITests
{
    public class MainPageElements
    {
        IWebDriver _driver;
        WebDriverWait _wait;


        public MainPageElements(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
     
        public void EnterANumber(string num)
        {
            _driver.FindElement(By.Id("number")).SendKeys(num);
        }

        public void ClearNumberField()
        {
            _driver.FindElement(By.Id("number")).Clear();
        }

        public string GetNumberFieldText()
        {
           return _driver.FindElement(By.Id("number")).Text;
        }

        public void ClickCheckIfItsPrimeButton()
        {
            _driver.FindElement(By.Id("Button1")).Click();
            
        }

        public bool CheckGifIsShown()
        {
            var giflabel = _driver.FindElements(By.Id("giflabel"));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("giflabel")));
            return giflabel.Count() > 0 && giflabel.FirstOrDefault().Displayed;
        }

        public bool CheckAJokeFieldIsShown()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("jokeResult")));
            return _driver.FindElement(By.Id("jokeResult")).Displayed;
        }

        public string GetJokeText()
        {       
            return _driver.FindElement(By.Id("jokeResult")).Text;
        }

        public bool ErrorMessageFieldIsShown()
        {
            var error = _driver.FindElements(By.Id("RequiredFieldValidator1"));
            return error.Count() > 0 && error.FirstOrDefault().Displayed;
        }

        public string GetErrorMessageText()
        {
            return _driver.FindElement(By.Id("RequiredFieldValidator1")).Text;
        }

        public void WaitForGifToBeVisible()
        {
            var result = _driver.FindElement(By.Id("result"));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(result, "You entered " + GetNumberFieldText() + ".This is a prime number! Here's a joke for you:"));
        }
    }
}

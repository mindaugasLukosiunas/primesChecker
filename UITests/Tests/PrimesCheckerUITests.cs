using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace UITests.Tests
{
    public class PrimesCheckerUITests
    {
        /*These are UI tests using FireFox driver. Of course you could run the same tests on Chrome or other browser.
         Using the popular Page-Object model, where elements and methods are defined in one class, and test consist of human readable methods,
         therefore it is clear what they do exactly.*/
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new DriverInit().GetDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void GifIsShownWhenEnteredNotAPrimeNumber()
        {
            var primeCheckerPage = new MainPageElements(_driver);
            primeCheckerPage.EnterANumber("6");
            primeCheckerPage.ClickCheckIfItsPrimeButton();
            primeCheckerPage.CheckGifIsShown().Should().BeTrue();
        }

        [Test]
        public void NoJokeTextIsShownWhenEnteredNotAPrimeNumber()
        {
            var primeCheckerPage = new MainPageElements(_driver);
            primeCheckerPage.EnterANumber("6");
            primeCheckerPage.ClickCheckIfItsPrimeButton();
            primeCheckerPage.CheckGifIsShown().Should().BeTrue();
            primeCheckerPage.GetJokeText().Should().Contain("No joke this time. :(");
        }

        [Test]
        public void AJokeIsShownWhenEnteredAPrimeNumber()
        {
            var primeCheckerPage = new MainPageElements(_driver);
            primeCheckerPage.EnterANumber("7");
            primeCheckerPage.ClickCheckIfItsPrimeButton();
            primeCheckerPage.CheckAJokeFieldIsShown().Should().BeTrue();
            primeCheckerPage.GetJokeText().Should().NotContain("No joke this time. :(");
        }

        [Test]
        public void ErrorMessageIsShownWhenEnteredAnInvalidSymbol([Values("", "a", "*")] string symbol)
        {
            var primeCheckerPage = new MainPageElements(_driver);
            primeCheckerPage.EnterANumber(symbol);
            primeCheckerPage.ClickCheckIfItsPrimeButton();
            primeCheckerPage.ErrorMessageFieldIsShown().Should().BeTrue();
            primeCheckerPage.GetErrorMessageText().Should().Contain("You are more likely to get a joke if it's a positive integer!");
        }

        [Test]
        public void ErrorMessageDisappearsWhenValidNumberIsEntered()
        {
            var primeCheckerPage = new MainPageElements(_driver);
            primeCheckerPage.EnterANumber("/");
            primeCheckerPage.ClickCheckIfItsPrimeButton();
            primeCheckerPage.ErrorMessageFieldIsShown().Should().BeTrue();
            primeCheckerPage.GetErrorMessageText().Should().Contain("You are more likely to get a joke if it's a positive integer!");
            primeCheckerPage.ClearNumberField();
            primeCheckerPage.EnterANumber("7");
            primeCheckerPage.ClickCheckIfItsPrimeButton();
            primeCheckerPage.ErrorMessageFieldIsShown().Should().BeFalse();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}

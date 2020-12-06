using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Answer_Digital_Automation_test.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;


namespace Answer_Digital_Automation_test
{
    [Binding]
    public class Class1
    {
        IWebDriver driver;
        TheInternetHome HomePage;
        TheInternetLogin LoginPage;
        LoggedIn LoggedInChecker;

        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            HomePage = new TheInternetHome(driver);
            LoginPage = new TheInternetLogin(driver);
            LoggedInChecker = new LoggedIn(driver);
        }
        [Given(@"I am on the correct site")]
        public void GivenOnCorrectSite()
        {
            HomePage.Navigate("https://the-internet.herokuapp.com/");
        }
        [Then(@"I click on Form Authentication")]
        public void ClickOnFormAuthentication()
        {
            HomePage.ClickAuthentication();
        }
        [Then(@"I type my correct username")]
        public void TypeCorrectUsername()
        {
            LoginPage.TypeUsername("tomsmith");
        }
        [Then(@"I type my correct password")]
        public void TypeCorrectPassword()
        {
            LoginPage.TypePassword("SuperSecretPassword!");
        }
        [Then(@"I Press Login")]
        public void PressLogin()
        {
            LoginPage.PressLogin();
        }
        [Then(@"I should see logged in")]
        public void CheckLoginPage()
        {

            string result = LoggedInChecker.LoggedResult();
            StringAssert.Contains("You logged into a secure area!", result);
            //   LoginPage.TypePassword("SuperSecretPassword!");
            // You logged into a secure area!
        }

        [Then(@"I type my Wrong username")]
        public void TypeWrongUsername()
        {
            LoginPage.TypeUsername("tommy");
        }

        [Then(@"I type my Wrong password")]
        public void TypeWrongPassword()
        {
            LoginPage.TypePassword("password");
        }


        [Then(@"I should see unable to log in Password")]
        public void FailedLoginCheckPassword()
        {
            string result = LoginPage.FailedToLoginMessage();
            StringAssert.Contains("Your password is invalid!", result);

        }
        [Then(@"I should see unable to log in Username")]
        public void FailedLoginCheckUsername()
        {
            string result = LoginPage.FailedToLoginMessage();
            StringAssert.Contains("Your username is invalid!", result);

        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}

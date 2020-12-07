using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Answer_Digital_Automation_test.Pages;
using NUnit.Framework;
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
        InfiniteScroll infiniteScrollPage;
        TypingPage TypePage;

        /*
        this happens at the start of every test.
        what we do is create a chrome driver and maximize the window, then we give the driver to the page classes i created
        that will display certain pages of the test.
        I used SpecFlow for automation testing because i find it easier to test in steps and the gherkin syntax helps me break down my tests to
        understandable levels.
        I have all the tests on this one steps page as creating multiple step pages can get diffult as i have a before and after scenario set up here
        i would need to be able to set up these drivers in the other class as well after the setup has been done.
        */
        [BeforeScenario]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            HomePage = new TheInternetHome(driver);
            LoginPage = new TheInternetLogin(driver);
            LoggedInChecker = new LoggedIn(driver);
            infiniteScrollPage = new InfiniteScroll(driver);
            TypePage = new TypingPage(driver);
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

        [Then(@"i log out")]
        public void PressLogout()
        {
            LoggedInChecker.Loggout();
        }

        [Then(@"I should see i have logged out message")]
        public void CheckLoginPage()
        {
            string result = LoginPage.LoggedOutMessage();
            StringAssert.Contains("You logged out of the secure area!", result);
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

        [Then(@"I click on Infinite Scroll")]
        public void ClickOnInfiniteScroll()
        {
            HomePage.ClickInfiniteScrollLink();

        }

        [Then(@"I Scroll to the bottem of the page")]
        public void ScrollDownPage()
        {
            //to wait for the page to load/ new text to load
            Thread.Sleep(1482);
            infiniteScrollPage.ScrollToBottem();

        }

        [Then(@"I Scroll to the Top of the page")]
        public void ScrollUpPage()
        {
            Thread.Sleep(1482);
            infiniteScrollPage.ScrollToTop();
        }

        [Then(@"I should see Infinite Scroll Text")]
        public void CheckInfiniteScrollText()
        {
            Assert.IsTrue(infiniteScrollPage.IsTextVisible());

        }

        [Then(@"I click on Key Presses")]
        public void ClickOnKeyPresses()
        {
            HomePage.ClickKeyPresses();

        }

        // dont know why there is no space between I and Type as it wouldnt work.
        [Then(@"Itype the a key")]
        public void TypeA()
        {
            TypePage.TypeIn("a");
        }

        [Then(@"Icheck the a key has been typed")]
        public void CheckIfAPressed()
        {
            string result = TypePage.CheckTyped();
            StringAssert.Contains("You entered: a", result);
        }

        [Then(@"I type the space key")]
        public void TypeSpace()
        {
            TypePage.TypeIn(" ");
        }

        [Then(@"I check the space key has been typed")]
        public void CheckIfSpacePressed()
        {
            string result = TypePage.CheckTyped();
            StringAssert.Contains("You entered: SPACE", result);
        }

        [Then(@"I type the . key")]
        public void TypeDot()
        {
            TypePage.TypeIn(".");
        }

        [Then(@"I check the . key has been typed")]
        public void CheckDotPressed()
        {
            string result = TypePage.CheckTyped();
            StringAssert.Contains("You entered: PERIOD", result);
        }

        [Then(@"Itype the z key")]
        public void TypeZ()
        {
            TypePage.TypeIn("Z");
        }

        [Then(@"Icheck the z key has been typed")]
        public void CheckZPressed()
        {
            string result = TypePage.CheckTyped();
            StringAssert.Contains("You entered: Z", result);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}

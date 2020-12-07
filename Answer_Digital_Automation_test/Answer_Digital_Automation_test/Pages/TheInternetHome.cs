
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Answer_Digital_Automation_test.Pages
{
    class TheInternetHome
    {
        //This is the home page of the test. this is where all the tests start before they click on their page.
        private IWebDriver driver;
        public TheInternetHome(IWebDriver Driver)
        {
            //I use this.driver just in case to make sure the classes driver is the one changing.
            this.driver = Driver;
            //Here we put all the elements of the page into the driver.
            PageFactory.InitElements(driver, this);
        }
        //Pages used for this test.
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[21]/a")]
        private IWebElement ForAuthenticationLink;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[26]/a")]
        private IWebElement InfiniteScrollLink;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[31]/a")]
        private IWebElement KeyPressesLink;



        //Navigate to the home page at the start of test.
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        //click on the test being executed.
        public void ClickAuthentication()
        {
            ForAuthenticationLink.Click();
        }
        public void ClickInfiniteScrollLink()
        {
            InfiniteScrollLink.Click();
        }
        public void ClickKeyPresses()
        {
            KeyPressesLink.Click();
        }
    }
}

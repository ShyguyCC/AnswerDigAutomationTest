using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;

namespace Answer_Digital_Automation_test.Pages
{
    class TheInternetHome
    {
        private IWebDriver driver;
        public TheInternetHome(IWebDriver Driver)
        {
            //using this.driver just in case.
            this.driver = Driver;
            //this driver with this object.
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[21]/a")]
        private IWebElement ForAuthenticationLink;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[26]/a")]
        private IWebElement InfiniteScrollLink;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul/li[31]/a")]
        private IWebElement KeyPressesLink;




        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
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

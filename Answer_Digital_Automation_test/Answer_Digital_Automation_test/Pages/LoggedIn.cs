using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Answer_Digital_Automation_test.Pages
{
    class LoggedIn
    {
        private IWebDriver driver;
        public LoggedIn(IWebDriver Driver)
        {
            //using this.driver just in case.
            this.driver = Driver;
            //this driver with this object.
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div")]
        private IWebElement LoggedInResult;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/a")]
        private IWebElement LogoutButton;


        public String LoggedResult()
        {
            return LoggedInResult.Text;
        }
        public void Loggout()
        {
            LogoutButton.Click();
        }
    }
}

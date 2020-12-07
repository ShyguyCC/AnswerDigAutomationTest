using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Answer_Digital_Automation_test.Pages
{
    class LoggedIn
    {
        //This page is for Test Case 1 Login Scenario 3 successful login.
        private IWebDriver driver;
        public LoggedIn(IWebDriver Driver)
        {
            //I use this.driver just in case to make sure the classes driver is the one changing.
            this.driver = Driver;
            //Here we put all the elements of the page into the driver.
            PageFactory.InitElements(driver, this);
        }
        //finds the logout button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/a")]
        private IWebElement LogoutButton;
        //presses the logout button.
        public void Loggout()
        {
            LogoutButton.Click();
        }
    }
}

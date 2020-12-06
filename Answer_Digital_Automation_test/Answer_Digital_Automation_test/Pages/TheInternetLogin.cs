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
    class TheInternetLogin
    {
        private IWebDriver driver;
        public TheInternetLogin(IWebDriver Driver)
        {
            //using this.driver just in case.
            this.driver = Driver;
            //this driver with this object.
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[1]/div/input")]
        private IWebElement UsernameInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[2]/div/input")]
        private IWebElement PasswordInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/button")]
        private IWebElement LoginButton;
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div")]
        private IWebElement FailedToLoginText;


        public void TypeUsername(string name)
        {
            UsernameInput.SendKeys(name);
        }
        public void TypePassword(string password)
        {
            PasswordInput.SendKeys(password);
        }
        public void PressLogin()
        {
            LoginButton.Click();
        }
        public string FailedToLoginMessage()
        {
            return FailedToLoginText.Text;
        }
    }
}

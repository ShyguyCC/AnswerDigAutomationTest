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
    class TypingPage
    {
        private IWebDriver driver;
        public TypingPage(IWebDriver Driver)
        {
            //using this.driver just in case.
            this.driver = Driver;
            //this driver with this object.
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/input")]
        private IWebElement TypingElement;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/p[2]")]
        private IWebElement CheckingElement;

        public void TypeIn(string input)
        {
            TypingElement.SendKeys(input);
        }
        public string CheckTyped()
        {
            return CheckingElement.Text;
        }
    }
}

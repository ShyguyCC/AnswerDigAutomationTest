using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Answer_Digital_Automation_test.Pages
{
    class TypingPage
    {
        //This page is for Test Case 3 Key presses
        private IWebDriver driver;
        public TypingPage(IWebDriver Driver)
        {
            //I use this.driver just in case to make sure the classes driver is the one changing.
            this.driver = Driver;
            //Here we put all the elements of the page into the driver.
            PageFactory.InitElements(driver, this);
        }
        //we are using XPath as it targets the element directly.
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/input")]
        private IWebElement TypingElement;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/p[2]")]
        private IWebElement CheckingElement;

        //Type in has a string input so we can have 4 or more different inputs without needed new functions.
        public void TypeIn(string input)
        {
            TypingElement.SendKeys(input);
        }
        //here we get text back to see if what we typed is the same as what the text says.
        public string CheckTyped()
        {
            return CheckingElement.Text;
        }
    }
}

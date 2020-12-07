using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Answer_Digital_Automation_test.Pages
{
    class TheInternetLogin
    {
        //This page is for Test Case 1 Login Scenario 3 successful login.
        private IWebDriver driver;
        public TheInternetLogin(IWebDriver Driver)
        {
            //I use this.driver just in case to make sure the classes driver is the one changing.
            this.driver = Driver;
            //Here we put all the elements of the page into the driver.
            PageFactory.InitElements(driver, this);
        }
        //input boxes we use to type
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[1]/div/input")]
        private IWebElement UsernameInput;
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/div[2]/div/input")]
        private IWebElement PasswordInput;
        //button used to try to login
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form/button")]
        private IWebElement LoginButton;
        //text to check if test was a success
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div")]
        private IWebElement FailedToLoginText;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div")]
        private IWebElement LoggedOutText;

        //Input a user name and password through the string so no multiple of funtions.
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
        //Return String to check if message was correct.
        public string FailedToLoginMessage()
        {
            return FailedToLoginText.Text;
        }
        public string LoggedOutMessage()
        {
            return LoggedOutText.Text;
        }
    }
}

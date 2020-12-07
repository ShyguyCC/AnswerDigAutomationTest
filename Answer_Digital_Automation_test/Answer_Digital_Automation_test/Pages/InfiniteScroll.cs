using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Answer_Digital_Automation_test.Pages
{
    class InfiniteScroll
    {
        //This page is for Test Case 2 Infinite Scroll.
        private IWebDriver driver;
        //Im using javascriptexecutor here to scroll to the bottem and top of the page
        private IJavaScriptExecutor JavScrExe;
        public InfiniteScroll(IWebDriver Driver)
        {
            //I use this.driver just in case to make sure the classes driver is the one changing.
            this.driver = Driver;
            JavScrExe = (IJavaScriptExecutor)driver;
            //Here we put all the elements of the page into the driver.
            PageFactory.InitElements(driver, this);
        }
        //find the text we use to determin we are at the top of the page.
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/h3")]
        private IWebElement InfiniteScrollText;
        //here we use executescript to scroll to the very bottem of the page we can.
        public void ScrollToBottem()
        {
            JavScrExe.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        //here we do the opposit of above funtion, which scrolls us to the top.
        public void ScrollToTop()
        {
            JavScrExe.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight)");
        }
        //this is to check if the infinite scroll text at the top of the page is being displayed.
        public bool IsTextVisible()
        {
            return InfiniteScrollText.Displayed;
        }

    }
}

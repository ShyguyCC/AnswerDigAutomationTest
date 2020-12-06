using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace Answer_Digital_Automation_test.Pages
{
    class InfiniteScroll
    {
        private IWebDriver driver;
        private IJavaScriptExecutor js;
        public InfiniteScroll(IWebDriver Driver)
        {
            //using this.driver just in case.
            this.driver = Driver;
            js = (IJavaScriptExecutor)driver;
            //this driver with this object.
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/h3")]
        private IWebElement InfiniteScrollText;
        public void ScrollToBottem()
        {
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
        public void ScrollToTop()
        {
            js.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight)");
        }
        //this is to check if the infinite scroll text at the top of the page is being displayed.
        public bool IsTextVisible()
        {
            return InfiniteScrollText.Displayed;
        }

    }
}

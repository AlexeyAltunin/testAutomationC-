using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriverPageObject
{
    public class AnyPage
    {
        private PageManager pageManager;

        public AnyPage(PageManager pageManager)
        {
            this.pageManager = pageManager;
        }

        protected bool IsElementPresent(By by)
        {
            return pageManager.driver.FindElements(by).Count > 0;
        }

        protected IWebElement waitUntilVisible(By by)
        {
            return pageManager.wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
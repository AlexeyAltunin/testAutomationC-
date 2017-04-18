using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverPageObject
{
    public class InternalPage : AnyPage
    {
        public InternalPage(PageManager pageManager)
            : base(pageManager)
        {
        }

        public IWebElement LogoutLink()
        {
            return waitUntilVisible(By.Id("PH_logoutLink"));
        }

        public bool IsOnThisPage()
        {
            return IsElementPresent(By.Id("PH_logoutLink"));
        }
    }
}
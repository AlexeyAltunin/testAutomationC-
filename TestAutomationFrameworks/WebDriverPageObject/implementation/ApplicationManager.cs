using System;
using OpenQA.Selenium;

namespace WebDriverPageObject
{
    public class ApplicationManager
    {
        public ApplicationManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            Pages = new PageManager(capabilities, baseUrl, hubUrl);

            Auth = new LoginHelper(this);
            Navigator = new NavigationHelper(this);
        }

        public PageManager Pages { get; set; }

        public LoginHelper Auth { get; set; }
        public NavigationHelper Navigator { get; set; }
    }
}
﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace WebDriverPageObject
{
    public class PageManager
    {
        internal IWebDriver driver;
        internal WebDriverWait wait;
        internal string baseUrl;

        public PageManager(ICapabilities capabilities, string baseUrl, string hubUrl)
        {
            driver = WebDriverFactory.GetDriver(hubUrl, capabilities);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            if (!driver.Url.StartsWith(baseUrl))
            {
                driver.Navigate().GoToUrl(baseUrl);
            }
            this.baseUrl = baseUrl;

            Login = InitElements(new LoginPage(this));
            Internal = InitElements(new InternalPage(this));
            UserProfile = InitElements(new UserProfilePage(this));
        }

        private T InitElements<T>(T page) where T : AnyPage
        {
            PageFactory.InitElements(driver, page);
            return page;
        }

        public void AcceptApert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public InternalPage Internal { get; set; }

        public LoginPage Login { get; set; }

        public UserProfilePage UserProfile { get; set; }
    }
}
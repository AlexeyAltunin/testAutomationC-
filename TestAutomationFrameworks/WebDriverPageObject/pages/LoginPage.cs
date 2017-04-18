using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverPageObject
{
    public class LoginPage : AnyPage
    {
        public LoginPage(PageManager pageManager)
            : base(pageManager)
        {
        }

        [FindsBy(How = How.Id, Using = "mailbox__login")]
        public IWebElement UsernameField;

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement PasswordField;

        [FindsBy(How = How.Id, Using = "mailbox__auth__button")]
        public IWebElement SubmitButton;

        public bool IsOnThisPage()
        {
            return IsElementPresent(By.Id("mailbox__login"));
        }
    }
}
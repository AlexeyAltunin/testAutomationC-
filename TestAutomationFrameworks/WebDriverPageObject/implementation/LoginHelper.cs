using System;

namespace WebDriverPageObject
{
    public class LoginHelper
    {
        private PageManager pages;

        public LoginHelper(ApplicationManager manager)
        {
            this.pages = manager.Pages;
        }

        public void Login(AccountData account)
        {
            pages.Login.UsernameField.Clear();
            pages.Login.UsernameField.SendKeys(account.Username);

            pages.Login.PasswordField.Clear();
            pages.Login.PasswordField.SendKeys(account.Password);

            pages.Login.SubmitButton.Click();
        }

        public void Logout()
        {
            pages.Internal.LogoutLink().Click();
        }

        public bool IsLoggedIn()
        {
            return pages.Internal.IsOnThisPage();
        }

        public bool IsLoggedOut()
        {
            return pages.Login.IsOnThisPage();
        }
    }
}
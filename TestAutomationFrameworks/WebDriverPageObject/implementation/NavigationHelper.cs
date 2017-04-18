using System;

namespace WebDriverPageObject
{
    public class NavigationHelper
    {
        private PageManager pages;

        public NavigationHelper(ApplicationManager manager)
        {
            this.pages = manager.Pages;
        }
    }
}
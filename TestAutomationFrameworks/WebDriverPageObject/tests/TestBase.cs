using NUnit.Framework;
using System;
using OpenQA.Selenium.Remote;

namespace WebDriverPageObject
{
	[TestFixture()]
	public class TestBase
	{
        protected ApplicationManager app;
        string url = "https://mail.ru/";

        [SetUp]
        public void StartApplication() 
        {
            app = new ApplicationManager(DesiredCapabilities.Chrome(), url, null);
        }

       /* 
        [TearDown]
        public void StopBrowser()
        {
            if (wd != null)
            {
                wd.Quit();
                wd = null;
            }
        }
        */
    }
}

using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace UiAutomationFramework
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			IWebDriver driver;
			DesiredCapabilities capabilities = new DesiredCapabilities();
			capabilities = new DesiredCapabilities("chrome", "66.0", new Platform(PlatformType.Any));
			capabilities.SetCapability("enableVNC", true);
			//driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

			driver.Navigate().GoToUrl("http://saucelabs.com");
			IWebElement header = driver.FindElement(By.Id("site - header"));
	
			Assert.True(header.Displayed);
			driver.Quit();
		}
	}
}

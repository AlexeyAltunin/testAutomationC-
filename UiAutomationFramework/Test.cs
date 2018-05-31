using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UiAutomationFramework
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			IWebDriver driver = new ChromeDriver();
			//Firefox's proxy driver executable is in a folder already
			//  on the host system's PATH environment variable.
			driver.Navigate().GoToUrl("http://saucelabs.com");
			IWebElement header = driver.FindElement(By.Id("site - header"));
	
			Assert.True(header.Displayed);
			driver.Quit();
		}
	}
}

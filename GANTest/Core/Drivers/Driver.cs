using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GANTest.Core.Drivers
{
	public class Driver
	{
		public static IWebDriver TestDriver { get; set; }

		public void Initialize()
		{
			TestDriver = new ChromeDriver();
			TestDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
		}

		public void CleanUp()
		{
			TestDriver.Quit();
		}

		public void WaitForPageLoad(int timeout)
		{
			TestDriver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
		}
	}
}


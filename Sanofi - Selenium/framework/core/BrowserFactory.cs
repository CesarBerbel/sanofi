using BrowserStack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;

namespace Sanofi___Selenium.framework.core
{
	class BrowserFactory
	{
		private static IWebDriver driver;
		private static Local local;

		public static IWebDriver Driver
		{
			get
			{
				if (driver == null)
					throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
				return driver;
			}
			private set
			{
				driver = value;
			}
		}

		public static void InitBrowser(string browserName)
		{
			switch (browserName)
			{
				case "Firefox":
						driver = new FirefoxDriver();
					break;


				case "Chrome":
						driver = new ChromeDriver();
					break;
				case "BrowserStack":
					local = new Local();

					List<KeyValuePair<string, string>> bsLocalArgs = new List<KeyValuePair<string, string>>() {
					new KeyValuePair<string, string>("key", "q7krd5VsYyH7auBnpfs7"), };
					local.start(bsLocalArgs);

					ChromeOptions capability = new ChromeOptions();
					capability.AddAdditionalCapability("os", "Windows", true);
					capability.AddAdditionalCapability("os_version", "10", true);
					capability.AddAdditionalCapability("browser", "Chrome", true);
					capability.AddAdditionalCapability("browser_version", "latest-beta", true);
					capability.AddAdditionalCapability("resolution", "1920x1080", true);
					capability.AddAdditionalCapability("project", "Sanofi", true);
					capability.AddAdditionalCapability("build", "Conecta", true);
					capability.AddAdditionalCapability("name", "Regressao", true);
					capability.AddAdditionalCapability("browserstack.local", "true", true);
					capability.AddAdditionalCapability("browserstack.debug", "true", true);
					capability.AddAdditionalCapability("browserstack.selenium_version", "3.14.0", true);
					capability.AddAdditionalCapability("browserstack.user", "csarberbel1", true);
					capability.AddAdditionalCapability("browserstack.key", "q7krd5VsYyH7auBnpfs7", true);

					driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability);
					break;
			}
			Driver.Manage().Window.Maximize();
		}

		public static void LoadApplication(string url)
		{
			Driver.Url = url;
		}

		public static void CloseAllDrivers()
		{
			if (local != null) {
				local.stop();
			}
			Driver.Close();
			Driver.Quit();
		}
	}
}
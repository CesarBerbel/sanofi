using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class PreLoginPage
	{
		[FindsBy(How = How.Name, Using = "name")]
		public IWebElement Usuario { get; set; }

		[FindsBy(How = How.Name, Using = "pass")]
		public IWebElement Senha { get; set; }

		[FindsBy(How = How.XPath, Using = "//div[@id='vue-app']//button")]
		public IWebElement Enviar { get; set; }

		public void DoPreLogin(bool vai)
		{
			if (vai) { 
				Usuario.SendKeys("sanoficonecta");
				Senha.SendKeys("previewconecta");

				Enviar.Click();
			}
		}
	}
}

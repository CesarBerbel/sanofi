using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sanofi___Selenium.framework.Pages;
using System;
using System.Threading;

namespace Sanofi___Selenium.framework.core
{

	public class App
	{
		IWebElement _meliante;
		public WebDriverWait _espera;

		public void Initalize()
		{
          BrowserFactory.InitBrowser("BrowserStack");

         //  BrowserFactory.InitBrowser("Chrome");
          _espera = new WebDriverWait(BrowserFactory.Driver, TimeSpan.FromSeconds(60));	
		}

		public void GoTo(string url, bool preLogin = true)
		{
			BrowserFactory.LoadApplication(url);
			BasePage.PreLoginPage.DoPreLogin(preLogin);			
		}

		public void Click(By by)
		{

			_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
			_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
			_meliante.Click();
		}

		public void JClick(By by, bool esperar = true)
		{
			Thread.Sleep(TimeSpan.FromSeconds(3));
			if (esperar)
			{
				_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
				_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
			}
            else
            {
                _meliante = BrowserFactory.Driver.FindElement(by);
            }

			Thread.Sleep(TimeSpan.FromSeconds(2));
			IJavaScriptExecutor executor = (IJavaScriptExecutor)BrowserFactory.Driver;
			executor.ExecuteScript("arguments[0].click();", _meliante);		
		}

		public void EnterTextInto(By by, string text, bool esperar = true)
		{
			_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
			_meliante.SendKeys(text);
		}

		public void Select(By by)
		{
			//_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
			//_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
			BrowserFactory.Driver.FindElement(by).Click();
		}

		public void SelecionarDropDown(By by, string selecao)
		{
			_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
			_meliante = _espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
			SelectElement dropdown = new SelectElement(BrowserFactory.Driver.FindElement(by));
			dropdown.SelectByValue(selecao);
		}

		public void Dispose()
		{
			BrowserFactory.CloseAllDrivers();
		}

		public void CheckAtualPage(string url)
		{
			Assert.IsTrue(BrowserFactory.Driver.Url == url);
		}

		public void SetWaitTimeOut(int tempo)
		{
			_espera.Timeout = TimeSpan.FromSeconds(tempo);
		}

		public string GetTextBy(By element, string texto = "")
		{
			if (texto != "")
			{
				_espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(element, texto));
			}
			_meliante = _espera.Until(e => e.FindElement(element));
			return _meliante.Text;
		}

		

		public string WaitText(string by, string text)
		{
			_espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementLocated(By.XPath(by), text));
			return GetTextBy(By.XPath(by));
		}
	}
}
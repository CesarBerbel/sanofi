using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Sanofi___Selenium.framework.core
{
	public static class Asserts
	{
		public static void VerificarUrl(string url)
		{
			Assert.IsTrue(BrowserFactory.Driver.Url == url, "Era pra ser: {0} mas está no componente: {1}", url, BrowserFactory.Driver.Url);
		}

		public static void VerificarString(string s1, string s2, bool real = false)
		{
			string s1Trim = "";
			string s2Trim = "";
			if (real)
			{
				s1Trim = s1.Trim();
				s2Trim = s2.Trim();
				Assert.AreEqual(s1Trim, s2Trim, "Era pra ser: {0} mas está no componente: {1}", s2, s1);
			} else
			{
				Assert.AreEqual(s1, s2, "Era pra ser: {0} mas está no componente: {1}", s2, s1);
			}

		}

		//public static void VerificarMensagens(IList<IWebElement> elementos, string mensagens)
		//{
		//	string[] msgs = mensagens.Split(',');
		//	Assert.AreEqual(msgs.Length, elementos.Size);
		//	for (int i = 0; i < msgs.Length; i++)
		//	{
		//		Assert.AreEqual(msgs[i], elementos.);
		//	}			
		//}
	}
}

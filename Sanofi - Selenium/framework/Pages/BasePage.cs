using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.pages;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.framework.Pages
{
	public static class BasePage
	{
		public static T GetPage<T>() where T : new()
		{
			var page = new T();
			PageFactory.InitElements(BrowserFactory.Driver, page);
			return page;
		}

		public static PreLoginPage PreLoginPage
		{
			get { return GetPage<PreLoginPage>(); }
		}
		public static HomePage Home
		{
			get { return GetPage<HomePage>(); }
		}
		public static LoginModal LoginModal
		{
			get { return GetPage<LoginModal>(); }
		}
		public static ArtigoPage ArtigoPage
		{
			get { return GetPage<ArtigoPage>(); }
		}

		public static EventoPage EventoPage
		{
			get { return GetPage<EventoPage>(); }
		}

		public static ProdutosPage ProdutosPage
		{
			get { return GetPage<ProdutosPage>(); }
		}

		public static CampanhasPage CampanhasPage
		{
			get { return GetPage<CampanhasPage>(); }
		}
		public static PersonalizarContaPage PersonalizarConta
		{
			get { return GetPage<PersonalizarContaPage>(); }
		}

		public static ConfigurarCookiesPage ConfigurarCookies
		{
			get { return GetPage<ConfigurarCookiesPage>(); }
		}

		public static PesquisaModalPage PesquisaModal
		{
			get { return GetPage<PesquisaModalPage>(); }
		}
	}
}

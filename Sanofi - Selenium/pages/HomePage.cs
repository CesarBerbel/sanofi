using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class HomePage
	{
		public By ProfileMenu = By.XPath("//div[@class='menu-profile menu-profile--avatar']");

		public By ProfileMenuLogged = By.XPath("//div[@class='menu-profile menu-profile--logged']");

        public By ProfileMenuSoftLogin = By.XPath("//div[@class='grid-lg-5 c-pb-0 c-navbar__area-after c-navbar__area-logged c-text--text-right']/div");

        public By Entrar = By.Id("btnLogin");

		public By PorRegistro = By.Id("sf-is-hcp");

		public By PorEmail = By.Id("sf-is-not-hcp");

		public By BotaoLogar = By.Id("sf-continue-validation");

        public By BtnCriarConta = By.XPath("//div[@class='menu-profile menu-profile--open menu-profile--verified menu-profile--avatar']//a[1]");

        
    }
}

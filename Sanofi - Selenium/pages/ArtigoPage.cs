using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class ArtigoPage
	{

		public By Favoritos = By.XPath("//div[@class='c-hero__icons']//i");

		public By Compartilhar = By.XPath("//div[@class='c-hero__icons']//i[2]");

		public By Mensagem = By.XPath("//*[@id='vue - app']/div/div[6]/div/div/div/span[1]");

		public By ItensSalvoLink = By.XPath("//a[@class='c-text menu-profile__panel-item menu-profile__panel-item--link menu-profile__panel-item--text-left']");

		public By RemoverItem = By.XPath("//div[@class='c-favorites__list-item']//i");

		public By VoltarHomeBotao = By.Id("btnHome");

		//public By Entrar = By.Id("btnLogin");

		//public By PorRegistro = By.Id("sf-is-hcp");

		//public By PorEmail = By.Id("sf-is-not-hcp");

		//public By BotaoLogar = By.Id("sf-continue-validation");
	}
}

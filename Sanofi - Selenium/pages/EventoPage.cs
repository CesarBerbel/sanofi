using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class EventoPage
	{
		public By Compartilhar = By.XPath("//div[@class='c-hero__icons  c-hero-events__fix-black-icons  c-hero-events__fix-white-icons']//i[2]");
		public By Salvar = By.XPath("//div[@class='c-hero__icons  c-hero-events__fix-black-icons  c-hero-events__fix-white-icons']/i");
		//public By Mensagem = By.XPath("//div[@id='modal-login']//div[@class='c-text c-text--bold']");
		public By Mensagem = By.XPath("//div[@id='modal-soft-login']//h2[@class='c-text c-text--h2']");
		public By BotaoCalendario = By.XPath("//button[@class='c-button-schedule c-button-schedule--white']");
		public By LinkCalendario = By.XPath("//button[@class='c-button-schedule--basic']");
		public By BotaoAdicionado = By.XPath("//div[@class='c-button-schedule c-button-schedule--white']");
		public By BotaoAppleHero = By.XPath("//button[@class='c-button-schedule c-button-schedule--white']/parent::div//ul//li");
		public By BotaoApple = By.XPath("//button[@class='c-button-schedule--basic']/parent::div//ul//li");
        public By BtnAoVivo = By.XPath("//div[@class='c-button-schedule c-button-schedule--live']/span");

    }
}

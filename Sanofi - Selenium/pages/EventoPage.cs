using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class EventoPage
	{
        public By Mensagem = By.XPath("//div[@id='modal-soft-login']//h2[@class='c-text c-text--h2']");
		public By BotaoCalendario = By.XPath("//button[contains(text(),'Adicionar a meu calendário')]");
		public By LinkCalendario = By.XPath("//button[@class='c-button-schedule--basic']");
        public By BotaoAdicionado = By.XPath("//span[normalize-space()='Adicionado']");     
        public By BotaoAppleHero = By.XPath("//button[@class='c-button-schedule c-button-schedule--white']/parent::div//ul//li");
		public By BotaoApple = By.XPath("//button[@class='c-button-schedule--basic']/parent::div//ul//li");
        public By BtnAoVivo = By.XPath("//div[@class='c-button-schedule c-button-schedule--live']/span");

    }
}

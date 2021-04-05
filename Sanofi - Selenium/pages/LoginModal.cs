using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class LoginModal
	{
		public By Entrar = By.Id("btnLogin");

		public By PorEmail = By.Id("sf-is-not-hcp");

		public By ProfileMeBotaoLogarnu = By.Id("sf-continue-validation");

		public By CampoEmail = By.Id("lf-email");

		public By CampoSenha = By.Id("sf-password");

		public By UF = By.Id("uf");

		public By NumRegistro = By.Id("lf-registro");

		public By EsqueciSenha = By.Id("forgot-pass");

		public By Prosseguir = By.Id("sf-email-different");

		public By Reenviar = By.Id("lf-resend-mail");

		public By EmailSemAcesso = By.XPath("//div[@id='modal-login']//div[@class='c-text c-text--link']");

		public By TipoHCP = By.Id("hcp-type");

		public By Telefone = By.Id("Telefone");

		public By CriarConta = By.Id("btnSignUp");

		public By Termos = By.Id("opt-in");

		public By Nome = By.Id("sf-name");

		public By Sobrenome = By.Id("sf-lastname");

		public By CampoCelular = By.Id("sf-cellphone");

		public By Senha = By.Id("sf-password");

		public By RepetirSenha = By.Id("sf-password-confirm");

		public By ConfirmcaoEmail = By.Id("sf-diff-email");

		public By NumeroRegistro = By.Id("sf-register-2");

		public By EmailCriar = By.Id("sf-email");

		public By ProfileLog = By.XPath("//div[@class='menu-profile menu-profile--logged']");

		public By EncerrarSessao = By.XPath("//a[@class='c-text menu-profile__panel-item menu-profile__panel-item--link menu-profile__panel-item--danger menu-profile__panel-item--text-left']");

		public By ProSim = By.Id("sf-is-hcp");

		public By ProNao = By.XPath("//input[@id='sf-is-not-hcp']/following-sibling::span[@class='radiobtn']");

		public By BotaoLogar = By.Id("sf-continue-validation");

		public By ConfirmaTelefone = By.Id("sf-phone"); 

		public By CadastroDepois = By.Id("sf-create-account-after");

		public By IconeFechar = By.XPath("//span[@class='icon icon-close icon--hover-fade c-base-modal-content__icon']");		                                                 
	}
}

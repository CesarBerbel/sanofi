using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
    [Binding]
    public class RecuprerSenhaSteps : BaseSteps
    {
        [Given(@"que eu clique em Não recebeu\? Reenviar email")]
        public void DadoQueEuCliqueEmNaoRecebeuReenviarEmail()
        {
			App.Click(BasePage.LoginModal.Reenviar);
        }
        
        [Given(@"que eu clique em Não tenho mais acesso a este email")]
        public void DadoQueEuCliqueEmNaoTenhoMaisAcessoAEsteEmail()
        {
			App.Click(BasePage.LoginModal.EmailSemAcesso);
		}
        
        [Given(@"seja exibido o final do numero do telefone ""(.*)""")]
        public void DadoSejaExibidoOFinalDoNumeroDoTelefone(string tel)
        {

			string telefone = App.GetTextBy(By.XPath("//div[@class='c-text c-base-modal__text-success ']"));
			telefone = telefone.Substring(telefone.Length - 4, 4);
			Asserts.VerificarString(telefone, tel);
        }
        
        [When(@"clico em Esqueceu sua senha\?")]
        public void QuandoClicoEmEsqueceuSuaSenha()
        {
			App.Click(BasePage.LoginModal.EsqueciSenha);
        }
        
        [When(@"clico em Prosseguir")]
        public void QuandoClicoEmProsseguir()
        {
			App.Click(BasePage.LoginModal.Prosseguir);
		}

        [When(@"escolho tipo de HCP ""(.*)""")]
        public void QuandoEscolhoTipoDeHCP(string HCP)
        {
			string tipo = HCP.Substring((HCP.Length - 4), 3);
			App.SelecionarDropDown(BasePage.LoginModal.TipoHCP, tipo);
        }
        
        [When(@"eu preencho o campo Celular com ""(.*)""")]
        public void QuandoEuPreenchoOCampoCelularCom(string tel)
        {
			BrowserFactory.Driver.FindElement(BasePage.LoginModal.ConfirmaTelefone).Clear();
			App.EnterTextInto(BasePage.LoginModal.ConfirmaTelefone, tel);
			BrowserFactory.Driver.FindElement(BasePage.LoginModal.ConfirmaTelefone).SendKeys(Keys.Tab);
			BrowserFactory.Driver.FindElement(BasePage.LoginModal.ConfirmaTelefone).SendKeys(Keys.Tab);
			BrowserFactory.Driver.FindElement(BasePage.LoginModal.ConfirmaTelefone).SendKeys(Keys.Tab);
		}

		[When(@"eu preencho o campo Novo email com ""(.*)""")]
        public void QuandoEuPreenchoOCampoNovoEmailCom(string email)
        {
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(BasePage.LoginModal.CampoEmail));
			App.EnterTextInto(BasePage.LoginModal.CampoEmail, email);
        }
        
        [When(@"clico em Habilitar novo email")]
        public void QuandoClicoEmHabilitarNovoEmail()
        {
			App.Click(BasePage.LoginModal.BotaoLogar);
        }

		[Then(@"eu devo ver a tela de envio de senha")]
		public void EntaoEuDevoVerATelaDeEnvioDeSenha()
		{
			string texto = App.WaitText("//div[@id='modal-login']//*[@class='c-text--h2']", "Esqueci minha senha");
			Asserts.VerificarString(texto, "Esqueci minha senha");
		}
    }
}
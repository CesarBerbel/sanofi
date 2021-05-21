using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using System.Collections.Generic;
using System.Configuration;
using TechTalk.SpecFlow;


namespace Sanofi___Selenium.steps
{
    [Binding]
    public class LoginSteps : BaseSteps
    {            
        [When(@"escolho o Estado ""(.*)""")]
        public void QuandoEscolhoOEstado(string UF)
        {
			App.SelecionarDropDown(BasePage.LoginModal.UF, UF);
        }
        
        [When(@"preencho o campo Número do registro com ""(.*)""")]
        public void QuandoPreenchoOCampoNumeroDoRegistroCom(string numRegistro)
        {
			App.EnterTextInto(BasePage.LoginModal.NumRegistro, numRegistro);
		}
        
        [When(@"preencho o campo Senha com ""(.*)""")]
        public void QuandoPreenchoOCampoSenhaCom(string senha)
        {
			App.EnterTextInto(BasePage.LoginModal.CampoSenha, senha);
        }
        
        [When(@"clico em Logar")]
        public void QuandoClicoEmLogar()
        {
			App.Click(BasePage.LoginModal.BotaoLogar);
		}
        
        [When(@"Eu escolho o login por email")]
        public void QuandoEuEscolhoOLoginPorEmail()
        {
			App.Select(BasePage.LoginModal.PorEmail);
		}
        
        [When(@"preencho o campo Email com ""(.*)""")]
        public void QuandoPreenchoOCampoEmailCom(string email)
        {
			App.EnterTextInto(BasePage.LoginModal.CampoEmail, email);
		}
        
        [Then(@"eu devo ser direcionado para página de boas vindas")]
        public void EntaoEuDevoSerDirecionadoParaPaginaDeBoasVindas()
        {
			Asserts.VerificarUrl(ConfigurationManager.AppSettings["URL"]);
		}
        
        [Then(@"devo ver meu nome ""(.*)"" no menu profile")]
        public void EntaoDevoVerMeuNomeNoMenuProfile(string nome)
        {
			string texto = App.GetTextBy(By.XPath("//h3"), nome);
			//Asserts.VerificarString(texto, nome, true);
			Assert.IsTrue(texto.Contains(nome));
		}
        
        [Then(@"devo ver as mensagens de erro do Login ""(.*)""")]
        public void EntaoDevoVerAsMensagensDeErro(string msgs)
        {
			string[] mensagens = msgs.Split(',');
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='c-base-modal__text-error']")));

            IList <IWebElement> ErrorMsgs = BrowserFactory.Driver.FindElements(By.XPath("//div[@class='c-base-modal__text-error']"));

			string palavra1, palavra2;
			
			Assert.AreEqual(mensagens.Length, ErrorMsgs.Count);
			for (int i = 0; i < mensagens.Length; i++)
			{
				palavra1 = mensagens[i];
				palavra2 = ErrorMsgs[i].Text;
				Assert.AreEqual(palavra1, palavra2);
			}
			//Asserts.VerificarMensagens(BasePage.LoginModal.ErrorMsgs, msgs);
		}

		[Given(@"eu clico no menu profile logado para expandir")]
		public void DadoEuClicoNoMenuProfileLogadoParaExpandir()
		{
			App.Click(BasePage.LoginModal.ProfileLog);
		}

		[When(@"eu clico em Encerrar Sessao")]
		public void QuandoEuClicoEmEncerrarSessao()
		{
			App.Click(BasePage.LoginModal.EncerrarSessao);
		}

		[Then(@"eu devo ser direcionado para Home deslogada")]
		public void EntaoEuDevoSerDirecionadoParaHomeDeslogada()
		{
			
		}

	}
}
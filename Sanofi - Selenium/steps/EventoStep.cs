using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
	[Binding]
	public sealed class EventoStep : BaseSteps
	{
		[When(@"eu acesso o evento ""(.*)""")]
		public void QuandoEuAcessoOEvento(string url)
		{
			App.GoTo(url, false);
		}

		[Then(@"eu visualizo o evento ""(.*)""")]
		public void EntaoEuVisualizoOEvento(string url)
		{
			App.CheckAtualPage(url);
		}

		[When(@"eu acesso a campanha ""(.*)""")]
		public void QuandoEuAcessoACampanha(string url)
		{
			App.GoTo(url, false);
		}
		
		[Then(@"devo ver a mensagem do evento ""(.*)""")]
		public void EntaoDevoVerAMensagemDoEvento(string msg)
		{
			string mensagem = App.GetTextBy(By.XPath("//div[@class='c-text c-text--text-left c-text--wraped']"));
			mensagem = mensagem.Replace("\r\n", " ");
			Asserts.VerificarString(msg, mensagem, true);
			//string texto = App.GetTextBy(By.XPath("//div[@class='c-text c-text--text-left c-text--wraped']"));
			//Asserts.VerificarString(texto, msg);
		}

		[Then(@"devo ver a mensagem do evento exclusivo ""(.*)""")]
		public void EntaoDevoVerAMensagemDoEventoExclusivo(string msg)
		{
			string texto = App.GetTextBy(BasePage.EventoPage.Mensagem);
			Asserts.VerificarString(texto, msg);
		}


		[When(@"eu clico em Compartilhar Evento")]
		public void QuandoEuClicoEmCompartilharEvento()
		{
			App.JClick(BasePage.EventoPage.Compartilhar);
		}

		[When(@"eu clico em Favoritos Eventos")]
		public void QuandoEuClicoEmFavoritosEventos()
		{
			App.JClick(BasePage.EventoPage.Salvar);
		}

		[When(@"Eu clico em fechar")]
		public void QuandoEuClicoEmFechar()
		{
			App.Click(BasePage.LoginModal.IconeFechar);
		}

		[Then(@"devo ver o botão de ""(.*)""")]
		public void EntaoDevoVerOBotaoDe(string label)
		{
            //implementada Thread por causa da lentidão do login
           Thread.Sleep(TimeSpan.FromSeconds(3));

            string texto = App.GetTextBy(BasePage.EventoPage.BotaoCalendario);
			Asserts.VerificarString(texto, label);
		}

		[When(@"clico em Adicionar a meu calendário")]
		public void QuandoClicoEmAdicionarAMeuCalendario()
		{            
            App.JClick(BasePage.EventoPage.BotaoCalendario);
		}

		[When(@"escolho Apple")]
		public void QuandoEscolhoApple()
		{
			App.JClick(BasePage.EventoPage.BotaoAppleHero);
		}

		[Then(@"o botão deve ter o texto ""(.*)""")]
		public void EntaoOBotaoDeveTerOTexto(string label)
		{
			string texto = App.GetTextBy(BasePage.EventoPage.BotaoAdicionado);
			Asserts.VerificarString(texto, label);
		}

		[When(@"clico em Salvar no calendário dentro da palestra")]
		public void QuandoClicoEmSalvarNoCalendarioDentroDaPalestra()
		{
			App.JClick(BasePage.EventoPage.LinkCalendario);
		}

		[When(@"escolho Apple dentro da palestra")]
		public void QuandoEscolhoAppleDentroDaPalestra()
		{
			App.JClick(BasePage.EventoPage.BotaoApple);
		}

        [Then(@"não devo ver o botão de Adicionar a meu calendário")]
        public void EntaoNaoDevoVerOBotaoDeAdicionarAMeuCalendario()
        {
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//button[@class='c-button-schedule c-button-schedule--white']")).Count == 0, "Botão visível na página");
        }

        [When(@"eu clico em ""(.*)""")]
        public void QuandoEuClicoEm(string p0)
        {
            App.JClick(BasePage.EventoPage.BotaoCalendario);
        }

        [Then(@"eu devo ver o botão ""(.*)""")]
        public void EntaoEuDevoVerOBotao(string label)
        {

        string texto = App.GetTextBy(BasePage.EventoPage.BotaoAdicionado);
        Asserts.VerificarString(texto, label);
        
        }

        [When(@"seleciono a opcao ""(.*)""")]
        public void QuandoSelecionoAOpcao(string calendar)
        {
            App.JClick(By.XPath("//div[contains(@class,'c-dropdown')]//li[contains(text(),'"+ calendar + "')]"));
        }

        [Then(@"devo ver o botão ""(.*)""")]
        public void EntaoDevoVerOBotao(string label)
        {
            string texto = App.GetTextBy(BasePage.EventoPage.BtnAoVivo);
            Asserts.VerificarString(texto, label);
        }


    }
}

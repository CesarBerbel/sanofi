using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
    [Binding]
    public class ArtigoSteps : BaseSteps
    {
        [When(@"eu clico no artigo ""(.*)""")]
        public void QuandoEuClicoNoArtigo(string artigo)
        {
			App.GetTextBy(By.XPath("//h2[contains(text(),'" + artigo + "')]/ancestor::a"));
			BrowserFactory.Driver.FindElement(By.XPath("//h2[contains(text(),'" + artigo + "')]/ancestor::a")).Click();
		}

		[When(@"eu clico em SIM")]
        public void QuandoEuClicoEmSIM()
        {
			App.Select(BasePage.LoginModal.ProSim);
		}

		[When(@"eu clico em Prosseguir")]
        public void QuandoEuClicoEmProsseguir()
        {
			App.Click(BasePage.LoginModal.BotaoLogar);
        }

		[When(@"clico em Finalizar Validacao")]
		public void QuandoClicoEmFinalizarValidacao()
		{
			App.Click(BasePage.LoginModal.BotaoLogar);
		}

		[Then(@"devo ver a mensagem ""(.*)""")]
		public void EntaoDevoVerAMensagem(string msg)
		{
			string mensagem = App.GetTextBy(By.XPath("//div[@id='modal-soft-login']//h2"));
			Asserts.VerificarString(msg, mensagem);
		}

		[Then(@"devo ver a mensagem do artigo ""(.*)""")]
		public void EntaoDevoVerAMensagemDoArtigo(string msg)
		{
			string mensagem = App.GetTextBy(By.XPath("//div[@class='c-text c-text--text-left c-text--wraped']"));
            mensagem = mensagem.Remove(4, 2);
			Asserts.VerificarString(msg, mensagem, true);

		}
        
        [Then(@"eu devo ser direcionado para página de validacao")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeValidacao()
		{			
			string mensagem = App.WaitText("//div[@id='modal-soft-login']//div[@class='c-text c-text--h2']", "Validação");
			Asserts.VerificarString("Validação", mensagem);
		}

		[Then(@"devo ver a mensagem de sucesso ""(.*)""")]
		public void EntaoDevoVerAMensagemDeSucesso(string msg)
		{			
			string mensagem = App.WaitText("//div[@class='c-text c-text--h3 c-modal-sf-hcp__title']", msg);
			Asserts.VerificarString(msg, mensagem);
		}

		[Then(@"eu visualizo o artigo ""(.*)""")]
		public void EntaoEuVisualizoOArtigo(string url)
		{
			Asserts.VerificarUrl(url);
		}

		[Then(@"devo ver as mensagens de erro de acesso Oops!,Olá Dentista,,Esse conteúdo é exclusivo para ""(.*)""")]
		public void EntaoDevoVerAsMensagensDeErroDeAcessoOopsOlaDentistaEsseConteudoEExclusivoPara(string especialidades)
		{
			string mensagem = App.GetTextBy(By.XPath("//div[@class='c-text c-text--text-left c-text--wraped']/p/span[2]"));
			Asserts.VerificarString(mensagem, especialidades);
		}

		[When(@"clico em Deixar para depois")]
		public void QuandoClicoEmDeixarParaDepois()
		{
			App.Click(BasePage.LoginModal.CadastroDepois);
		}

		[Given(@"que eu retorne para home")]
		public void DadoQueEuRetorneParaHome()
		{
			App.GoTo(ConfigurationManager.AppSettings["URL"], false);
		}

		[Given(@"que eu acesse o artigo ""(.*)""")]
		public void DadoQueEuAcesseOArtigo(string url)
		{
			App.GoTo(url, false);
		}

		[When(@"eu acesso o artigo ""(.*)""")]
		public void QuandoEuAcessoOArtigo(string url)
		{
			App.GoTo(url, false);
		}

		[Given(@"que eu acesso artigo ""(.*)""")]
		public void DadoQueEuAcessoArtigo(string url)
		{
			App.GoTo(url);
		}

		[When(@"eu clico em Favoritos")]
		public void QuandoEuClicoEmFavoritos()
		{
			App.JClick(BasePage.ArtigoPage.Favoritos);
			Thread.Sleep(TimeSpan.FromSeconds(8));
		}

		[Then(@"devo ver essa mensagem ""(.*)""")]
		public void EntaoDevoVerEssaMensagem(string p0)
		{
			string mensagem = App.GetTextBy(BasePage.ArtigoPage.Mensagem);
		}


		[When(@"eu clico em Itens Salvos")]
		public void QuandoEuClicoEmItensSalvos()
		{
			App.Click(BasePage.ArtigoPage.ItensSalvoLink);
		}

		[Then(@"eu devo ser direcionado para página de Favoritos")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeFavoritos()
		{
			App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/favoritos");
		}

		[When(@"eu clico em Remover item dos favoritos")]
		public void QuandoEuClicoEmRemoverItemDosFavoritos()
		{
            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='c-favorites__list-item']//i")));

            App.JClick(BasePage.ArtigoPage.RemoverItem);
		}

		[When(@"eu clico em Compartilhar")]
		public void QuandoEuClicoEmCompartilhar()
		{
			App.JClick(BasePage.ArtigoPage.Compartilhar);
		}

		[Then(@"devo ver os links ""(.*)""")]
		public void EntaoDevoVerOsLinks(string links)
		{
			string[] mensagens = links.Split(',');
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//li[@class='c-text c-text--h2']")));
			IList<IWebElement> ErrorMsgs = BrowserFactory.Driver.FindElements(By.XPath("//li[@class='c-text c-text--h2']"));

			string palavra1, palavra2;

			Assert.AreEqual(mensagens.Length, ErrorMsgs.Count);
			for (int i = 0; i < mensagens.Length; i++)
			{
				palavra1 = mensagens[i];
				palavra2 = ErrorMsgs[i].Text;
				Assert.AreEqual(palavra1, palavra2);
			}

		}

		[When(@"Eu clico para voltar pra Home")]
		public void QuandoEuClicoParaVoltarPraHome()
		{
			App.Click(BasePage.ArtigoPage.VoltarHomeBotao);
		}

	}
}
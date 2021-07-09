using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
	[Binding]
    public class CampanhaSteps : BaseSteps
    {
		[Given(@"que eu acesse a campanha ""(.*)""")]
		public void DadoQueEuAcesseACampanha(string url)
		{
			App.GoTo(url);
		}

		[Then(@"eu visualizo a campanha ""(.*)""")]
		public void EntaoEuVisualizoACampanha(string url)
		{
			App.CheckAtualPage(url);
		}

		[When(@"eu acesso a campanha ""(.*)""""")]
		public void QuandoEuAcessoACampanha(string url)
		{
			App.GoTo(url);
		}

		[Then(@"devo ver a mensagem da campanha ""(.*)""")]
		public void EntaoDevoVerAMensagemDaCampanha(string msg)
		{
			string mensagem = App.GetTextBy(By.XPath("//div[@class='c-text c-text--text-left c-text--wraped']"));
			mensagem = mensagem.Remove(4, 2);
			Asserts.VerificarString(msg, mensagem, true);
		}
        		
		[Given(@"eu clico no menu profile para expandir em Campanha")]
		public void DadoEuClicoNoMenuProfileParaExpandirEmCampanha()
		{
			App.JClick(BasePage.CampanhasPage.ProfileMenuLogged);
		}

		[Then(@"devo ver a mensagem de salvamento ""(.*)""")]
		public void EntaoDevoVerAMensagemDeSalvamento(string msg)
		{
			//App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='c-drawer c-drawer--hidden']")));
            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//span[@class='c-text c-text--branco']")));

        }

    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
    [Binding]
    public class TreinamentosSteps : BaseSteps
    {
        [When(@"eu clico em Treinamentos")]
        public void QuandoEuClicoEmTreinamentos()
        {
            App.Click(BasePage.TreinamentosPage.menuTreinamento);

        }

        [When(@"eu clico em Compartilhar treinamento")]
        public void QuandoEuClicoEmCompartilharTreinamento()
        {
            App.JClick(BasePage.TreinamentosPage.compartilhar);
        }

        [Then(@"eu devo ser direcionado para página de treinamentos")]
        public void EntaoEuDevoSerDirecionadoParaPaginaDeTreinamentos()
        {
            App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/treinamentos/crm");
        }

        [When(@"eu acesso o Treinamento ""(.*)""")]
        public void QuandoEuAcessoOTreinamento(string url)
        {
            App.GoTo(url, false);
            BrowserFactory.Driver.Navigate().Refresh();
        }

        [When(@"clico em Fazer download do Certificado")]
        public void QuandoClicoEmFazerDownloadDoCertificado()
        {
            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//a[@target='_black']")));

            App.JClick(BasePage.TreinamentosPage.certificado);
        }

        [When(@"respondo ""(.*)"" na questao ""(.*)""")]
        public void QuandoRespondoNaQuestao(string resposta, string questao)
        {
            App.JClick(By.XPath("//div[contains(@class,'c-survey__questions')]//div[" + questao + "]//input[@value='" + resposta + "']"));
        }                         

        [When(@"clico em Proximo")]
        public void QuandoClicoEmProximo()
        {
            App.JClick(BasePage.TreinamentosPage.btnProximo);

        }

        [When(@"clico em Enviar")]
        public void QuandoClicoEmEnviar()
        {
            App.JClick(BasePage.TreinamentosPage.btnProximo);
        }

        [Then(@"eu devo ver a mensagem: ""(.*)""")]
        public void EntaoEuDevoVerAMensagem(string msg)
        {
            string mensagem = App.WaitText("//h1[@class='c-text c-text--h1 c-text--h1-event-desk c-text--bold']", msg);
            
            Asserts.VerificarString(msg, mensagem);
        }

        [Then(@"devo ver a mensagem: ""(.*)""")]
        public void EntaoDevoVerAMensagem(string msg)
        {
            string mensagem = App.WaitText("//h3[@class='c-text--h3']/span", msg);

            Asserts.VerificarString(msg, mensagem);
        }

        [Then(@"eu devo ver a mensagem de sucesso ""(.*)""")]
        public void EntaoEuDevoVerAMensagemDeSucesso(string msg)
        {
            string mensagem = App.WaitText("//span[@class='c-quizz-form-container-vert__right']", msg);
        }


        [When(@"respondo ""(.*)"" na pergunta ""(.*)""")]
        public void QuandoRespondoNaPergunta(string resposta, string pergunta)
        {
            App.JClick(By.XPath("//ul[@class='c-quizz-form-container-vert__options']//li["+ resposta +"]/span"));

                      
        }

        [When(@"clico em Abrir Módulo ""(.*)""")]
        public void QuandoClicoEmAbrirModulo(string comunEfic)
        {
            App.JClick(BasePage.TreinamentosPage.btnAbrirModulo);


            // App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[contains(@class,'courses--container-no-padding')]")));

            // IList<IWebElement> modulos = BrowserFactory.Driver.FindElements(By.XPath("//div[contains(@class,'courses--container-no-padding')]"));

            // IList<IWebElement> botoes = BrowserFactory.Driver.FindElements(By.XPath("//button"));

            //   App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button")));

            //  botoes[2].Click();
        }

        [When(@"Clico em Enviar resposta")]
        public void QuandoClicoEmEnviarResposta()
        {
            App.Click(BasePage.TreinamentosPage.btnEnviarResposta);
        }

        [When(@"eu clico em Proxima pergunta")]
        public void QuandoEuClicoEmProximaPergunta()
        {
            App.Click(BasePage.TreinamentosPage.btnProximaPergunta);
        }

        [Then(@"eu devo visualizar o certificado em outra janela")]
        public void EntaoEuDevoVisualizarOCertificadoEmOutraJanela()
        {
            BrowserFactory.Driver.SwitchTo().Window(BrowserFactory.Driver.WindowHandles[1]);


            Assert.IsTrue(BrowserFactory.Driver.Url.Contains(".pdf"));
        }

       

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
    [Binding]
    public class ConfigurarCookiesSteps : BaseSteps
    {
        [When(@"eu clico em Rejeitar Todos")]
        public void QuandoEuClicoEmRejeitarTodos()
        {
            App.JClick(BasePage.ConfigurarCookies.RejeitarTodos);
        }
        
        [Then(@"eu devo ver as configurações de cookies")]
        public void EntaoEuDevoVerAsConfiguracoesDeCookies()
        {
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//h3[@id='onetrust-policy-title']")).Count == 1, "Configuracoes de Cookies não visível na página");
        }

        [Then(@"o modal desaparece")]
        public void EntaoOModalDesaparece()
        {
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//h3[@id='onetrust-policy-title']")).Count == 0, "Configuracoes de Cookies Visível na página");
        }
    }
}

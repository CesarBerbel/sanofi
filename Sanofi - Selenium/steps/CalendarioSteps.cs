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
    public class CalendarioSteps : BaseSteps
    {
        [When(@"eu clico no evento ""(.*)""")]
        public void QuandoEuClicoNoEvento(string evento)
        {
            App.JClick(By.XPath("//a[@href='/eventos/"+ evento +"']"));
        }

        [When(@"eu clico no botão Ao vivo")]
        public void QuandoEuClicoNoBotaoAoVivo()
        {
            App.JClick(BasePage.CalendarioPage.btnAoVivo);
        }

        [When(@"eu clico no botão Adicionar ao meu calendário")]
        public void QuandoEuClicoNoBotaoAdicionarAoMeuCalendario()
        {
            App.JClick(BasePage.CalendarioPage.btnAdicCal);
        }

    }
}

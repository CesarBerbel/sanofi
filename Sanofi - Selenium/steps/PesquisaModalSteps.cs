using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
    [Binding]
    public class PesquisaModalSteps : BaseSteps
    {
        [When(@"eu Fecho a pesquisa")]
        public void QuandoEuFechoAPesquisal()
        {
            App.Click(BasePage.PesquisaModal.Fechar);
        }
        
        [Then(@"eu devo ver o modal de Pesquisa")]
        public void EntaoEuDevoVerOModalDePesquisa()
        {
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//button[@class='QSIWebResponsiveDialog-Layout1-SI_9Y38635TFejr5PL_close-btn']/img")).Count == 0, "Não exibiu a pesquisa de Satisfação");

        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
	[Binding]
    public class BuscaSteps : BaseSteps
    {
        [When(@"eu clico em Busca")]
        public void QuandoEuClicoEmBusca()
        {
            App.JClick(BasePage.BuscaPage.menuBusca);
        }

        [When(@"preencho o campo Buscar com ""(.*)""")]
        public void QuandoPreenchoOCampoBuscarCom(string item)
        {
            BrowserFactory.Driver.FindElement(BasePage.BuscaPage.buscar).Clear();

            App.EnterTextInto(BasePage.BuscaPage.buscar, item);
        }

        [When(@"clico em Pesquisar")]
        public void QuandoClicoEmPesquisar()
        {
            App.JClick(BasePage.BuscaPage.lupaBuscar);
        }


        [Then(@"eu devo visualizar os registros ""(.*)""")]
        public void EntaoEuDevoVisualizarOsRegistros(string reg)
        {

            string[] registros = reg.Split(',');

            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'modal-search__result-area')]//a")));

            IList<IWebElement> TitleReg = BrowserFactory.Driver.FindElements(By.XPath("//div[contains(@class,'modal-search__result-area')]//a"));

            string palavra1, palavra2;

            Assert.AreEqual(registros.Length, TitleReg.Count);
            for (int i = 0; i < registros.Length; i++)
            {
                palavra1 = registros[i];
                palavra2 = TitleReg[i].Text;
                Assert.AreEqual(palavra1, palavra2);
            }
        }

        [Then(@"eu não devo visualizar o registro ""(.*)""")]
        public void EntaoEuNaoDevoVisualizarORegistro(string result)
        {
            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[text()='Nenhum resultado para \""+ result +"\"']")));
        }
                              

        [Then(@"eu não devo visualizar as páginas de ""(.*)""")]
        public void EntaoEuNaoDevoVisualizarAsPaginasDe(string prod)
        {
          Thread.Sleep(1000);
          int qtd = BrowserFactory.Driver.FindElements(By.XPath("//div[contains(@class,'modal-search__category')]/div[text()='" + prod + "']")).Count;
          Assert.IsTrue(qtd == 0, "Produtos ou Eventos retornaram na busca");
        }
                                                                                                                  
        
        [Then(@"eu devo visualizar o registro ""(.*)""")]
        public void EntaoEuDevoVisualizarORegistro(string prod)
        {
            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//a[contains(@href,'" + prod + "')]")));
        }

        [When(@"eu clico no registro ""(.*)""")]
        public void QuandoEuClicoNoRegistro(string prod)
        {
            App.Click(By.XPath("//a[contains(@href,'" + prod + "')]"));
        }

        [When(@"eu clico em Busca no footer")]
        public void QuandoEuClicoEmBuscaNoFooter()
        {
            App.JClick(BasePage.BuscaPage.footerBusca);
        }

        [Then(@"eu devo visualizar a lista de A a Z com os Produtos ""(.*)""")]
        public void EntaoEuDevoVisualizarAListaDeAAZComOsProdutos(string list)
        {
            string[] lista = list.Split(',');

            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'modal-search__category modal-search--no-padding')]/div[text()='" + list + "']")));

            IList<IWebElement> Titlelist = BrowserFactory.Driver.FindElements(By.XPath("//div[contains(@class,'modal-search__category modal-search--no-padding')]/div[text()='" + list + "']"));

            string palavra1, palavra2;

            Assert.AreEqual(lista.Length, Titlelist.Count);
            for (int i = 0; i < lista.Length; i++)
            {
                palavra1 = lista[i];
                palavra2 = Titlelist[i].Text;
                Assert.AreEqual(palavra1, palavra2);
            }
        }

        [Then(@"eu devo ser direcionado para página de ""(.*)""")]
        public void EntaoEuDevoSerDirecionadoParaPaginaDe(string pag)
        {
            Assert.IsTrue(BrowserFactory.Driver.Url.Contains( pag ));
        }



    }
}
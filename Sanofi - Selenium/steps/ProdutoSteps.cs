using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;


namespace Sanofi___Selenium.steps
{
	[Binding]
	public class ProdutosSteps : BaseSteps
	{
        [When(@"eu clico no Menu ""(.*)""")]
        public void QuandoEuClicoNoMenu(string prod)
        {
            App.Click(By.XPath("//p[text()='" + prod + "']"));

        }

        [Then(@"eu não devo visualizar o menu Produtos")]
        public void EntaoEuNaoDevoVisualizarOMenuProdutos()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//p[text()='Produtos']")).Count == 0, "Menu Produtos, visível na página");
        }
        

		[When(@"eu clico no produto ""(.*)""")]
		public void QuandoEuClicoNoProduto(string prod)
		{
			//App.ScrolltoElement(BrowserFactory.Driver.FindElement(By.XPath("//a[contains(@href,'" + prod + "')]")));
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//a[contains(@href,'" + prod + "')]")));
			App.Click(By.XPath("//a[contains(@href,'" + prod + "')]"));
		}

		[When(@"eu clico na categoria ""(.*)""")]
		public void QuandoEuClicoNaCategoria(string cat)
		{
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//p[@class='c-hero__category--value']//a[contains(@href,'" + cat + "')]")));
			App.Click(By.XPath("//p[@class='c-hero__category--value']//a[contains(@href,'" + cat + "')]"));

		}

        [When(@"eu clico em Categorias ""(.*)""")]
        public void QuandoEuClicoEmCategorias(string categ)
        {            
            App.JClick(By.XPath("//h2[@class='c-text--h3 c-list-mestre-detail__subtitulo-left']//a[normalize-space()='" + categ + "']"));
        }


        [When(@"eu clico na Substância ""(.*)""")]
		public void QuandoEuClicoNaSubstancia(string subst)
		{
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//a[contains(@href,'" + subst + "')]")));
			App.Click(By.XPath("//a[contains(@href,'" + subst + "')]"));

		}
		[When(@"eu clico no produto dentro da substancia ""(.*)""")]
		public void QuandoEuClicoNoProdutoDentroDaSubstancia(string prod)
		{
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='c-p-16 tag-detail__result-area']//a[contains(@href,'" + prod + "')]")));
			App.Click(By.XPath("//div[@class='c-p-16 tag-detail__result-area']//a[contains(@href,'" + prod + "')]"));

		}

		[Then(@"eu devo ser direcionado para página de Produtos")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeProdutos()
		{

			App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/produtos");

		}

        [Then(@"eu devo ser direcionado para página de Tags Substancias ""(.*)""")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeTagsSubstancias(string subst)
		{
			App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/Tags?tag=" + subst + "&type=substance");
		}

		[When(@"eu clico em Nao")]
		public void QuandoEuClicoEmNao()
		{
			App.Select(BasePage.LoginModal.ProNao);
		}

		[Then(@"eu devo ser direcionado para página de acesso exclusivo")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeAcessoExclusivo()
		{
			string mensagem = App.WaitText("//div[@id='modal-soft-login']//h2[@class='c-text c-text--h2']", "Conteúdo exclusivo");
			Asserts.VerificarString("Conteúdo exclusivo", mensagem);
		}

		[When(@"eu clico em Filtro")]
		public void QuandoEuClicoEmFiltro()
		{
			App.JClick(BasePage.ProdutosPage.Filtro, false);
		}

		[Then(@"o modal Filtrar se expande")]
		public void EntaoOModalFiltrarSeExpande()
		{
			string ModalFiltrar = App.WaitText("//h4[normalize-space()='Filtrar']", "Filtrar");
			Asserts.VerificarString("Filtrar", ModalFiltrar);
		}

		[When(@"eu clico em Aplicar filtros")]
		public void QuandoEuClicoEmAplicarFiltros()
		{
			App.Click(BasePage.ProdutosPage.BtnAplicarFiltro);
		}
        [When(@"eu clico no filtro ""(.*)""")]
        public void QuandoEuClicoNoFiltro(string filtro)
        {
            App.JClick(By.XPath("//label[text()='" + filtro + "']/following-sibling::div"));
        }

       
        [Then(@"eu devo visualizar os Produtos ""(.*)""")]
        public void EntaoEuDevoVisualizarOsProdutos(string prod)
        {
            string[] lista = prod.Split(',');

            // App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'modal-search__category modal-search--no-padding')]/div[text()='" + list + "']")));

            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='card-packing__bottom']")));
            IList<IWebElement> Titlelist = BrowserFactory.Driver.FindElements(By.XPath("//div[@class='card-packing__bottom']"));

            string palavra1, palavra2;

            Assert.AreEqual(lista.Length, Titlelist.Count);
            for (int i = 0; i < lista.Length; i++)
            {
                palavra1 = lista[i];
                palavra2 = Titlelist[i].Text;
                Assert.AreEqual(palavra1, palavra2);
                Thread.Sleep(1000);
            }
        }

        [Then(@"eu devo visualizar a lista de todos os Produtos de A-Z")]
		public void EntaoEuDevoVisualizarAListaDeTodosOsProdutosDeA_Z()
		{
			string lista = App.WaitText("//h4[@class='c-text c-text--h5 c-text--bold c-text--cinza-leve packing-list-a-z']", "DE A-Z");
			Asserts.VerificarString("DE A-Z", lista);
		}

        [When(@"eu clico em baixar ""(.*)""")]
        public void QuandoEuClicoEmBaixar(string bula)
        {
            App.JClick(By.XPath("//a[contains(text(),'" + bula + "')]"));
        }
        [When(@"eu clico no ícone da bula")]
        public void QuandoEuClicoNoIconeDaBula()
        {
            App.JClick(BasePage.ProdutosPage.bulaIcone, false);
        }
        [When(@"eu clico em fazer download da ""(.*)""")]
        public void QuandoEuClicoEmFazerDownloadDa(string bula)
        {
            App.JClick(By.XPath("//span[contains(text(),'" + bula + "')]/following-sibling::i"));
            
        }



    }
}

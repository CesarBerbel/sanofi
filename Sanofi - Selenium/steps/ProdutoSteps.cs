using OpenQA.Selenium;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using TechTalk.SpecFlow;


namespace Sanofi___Selenium.steps
{
	[Binding]
	public class ProdutosSteps : BaseSteps
	{
		[When(@"eu clico em Produtos")]
		public void QuandoEuClicoEmProdutos()
		{
			App.Click(BasePage.ProdutosPage.MenuProduto);
		}

		[When(@"eu clico em Produtos deslogado")]
		public void QuandoEuClicoEmProdutosDeslogado()
		{
			App.Click(BasePage.ProdutosPage.MenuProdutoDeslogado);
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

		[Then(@"eu devo ser direcionado para página de Contraceptivos")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeContraceptivos()
		{
			App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/produtos/vacinas");

		}

		[Then(@"eu devo ser direcionado para página de detalhes do produto ""(.*)""")]
		public void EntaoEuDevoSerDirecionadoParaPaginaDeDetalhesDoProduto(string prod)
		{
			App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/produtos/contraceptivos/" + prod);
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
			App.JClick(BasePage.ProdutosPage.Filtro);
		}

		[Then(@"o modal Filtrar se expande")]
		public void EntaoOModalFiltrarSeExpande()
		{
			string ModalFiltrar = App.WaitText("//h4[@class='c-text--h4 c-text--bold c-text--text-left']", "Filtrar");
			Asserts.VerificarString("Filtrar", ModalFiltrar);
		}

		[When(@"eu clico em Aplicar filtros")]
		public void QuandoEuClicoEmAplicarFiltros()
		{
			App.Click(BasePage.ProdutosPage.BtnAplicarFiltro);
		}

		[Then(@"eu devo visualizar a lista de todos os Produtos de A-Z")]
		public void EntaoEuDevoVisualizarAListaDeTodosOsProdutosDeA_Z()
		{
			string lista = App.WaitText("//h4[@class='c-text c-text--h5 c-text--bold c-text--cinza-leve packing-list-a-z']", "DE A-Z");
			Asserts.VerificarString("DE A-Z", lista);
		}

		[When(@"eu clico em Compartilhar Produtos")]
		public void QuandoEuClicoEmCompartilharProdutos()
		{
			App.Click(BasePage.ProdutosPage.Compartilhar);
		}

		[When(@"eu clico em Favoritos do Produto")]
		public void QuandoEuClicoEmFavoritosDoProduto()
		{
			App.Click(BasePage.ProdutosPage.Salvar);
		}

	}
}

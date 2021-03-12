using OpenQA.Selenium;

namespace Sanofi___Selenium.pages
{
	public class ProdutosPage
	{
		public By MenuProduto = By.XPath("//a[@class='c-navbar__item c-text c-text--underline c-ml-40 c-text--underline-dark']");

		public By MenuProdutoDeslogado = By.XPath("//a[@class='c-navbar__item c-text c-text--underline c-ml-40']");

		//public By Filtro = By.XPath("//div[@class='sitecore-fix-top modal-aside-products-filter']");

		public By Filtro = By.XPath("//div[@class='grid-lg-1 grid-md-1 c-pl-0 c-pb-96 c-pt-96 packing-list-button-filter']");


		public By ModalFiltrar = By.XPath("//h4[@class='c-text--h4 c-text--bold c-text--text-left']");

		public By BtnAplicarFiltro = By.XPath("//button[@class='c-modal__footer--filter c-text c-text--h3']");

		public By VerTodos = By.XPath("//input[@id='packing-all']");

		public By ListaProdutos = By.XPath("//h4[@class='c-text c-text--h5 c-text--bold c-text--cinza-leve packing-list-a-z']");

		public By ApenasGenerico = By.XPath("//*[@id='packing-generic']/following-sibling::div");

		public By ApenasPediatrico = By.XPath("//*[@id='packing - pediatric']/following-sibling::div");

		public By IsentoPrescricao = By.XPath("//*[@id='packing-none']//following-sibling::div");

		public By TarjaVermelha = By.XPath("//*[@id='packing-red']//following-sibling::div");

		public By TarjaPreta = By.XPath("//*[@id='packing-black']//following-sibling::div");

		public By BulaProfissional = By.LinkText("Bula do profissional");

		public By BulaPaciente = By.LinkText("Bula do paciente");

		public By Compartilhar = By.XPath("//i[@class='icon icon-share']");

		public By Salvar = By.XPath("//div[@class='c-hero__icons']//i");

		
	}


}
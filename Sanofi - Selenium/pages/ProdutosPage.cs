using OpenQA.Selenium;

namespace Sanofi___Selenium.pages
{
	public class ProdutosPage
	{

		//public By Filtro = By.XPath("//div[@class='sitecore-fix-top modal-aside-products-filter']");

		public By Filtro = By.XPath("//i[@class='icon icon-filter']");


		public By ModalFiltrar = By.XPath("//h4[@class='c-text--h4 c-text--bold c-text--text-left']");

		public By BtnAplicarFiltro = By.XPath("//button[@class='c-modal__footer--filter c-text c-text--h3']");

		public By VerTodos = By.XPath("//input[@id='packing-all']");

		public By ListaProdutos = By.XPath("//h4[@class='c-text c-text--h5 c-text--bold c-text--cinza-leve packing-list-a-z']");

        //	public By ApenasGenerico = By.XPath("//*[@id='packing-generic']/following-sibling::div");

        //  public By ApenasPediatrico = By.XPath("//*[@id='packing-pediatric']/following-sibling::div");

        public By IsentoPrescricao = By.XPath("//*[@id='packing-none']//following-sibling::div");

		public By TarjaVermelha = By.XPath("//*[@id='packing-red']//following-sibling::div");

		public By TarjaPreta = By.XPath("//*[@id='packing-black']//following-sibling::div");

		public By bulaIcone = By.XPath("//i[@class='icon icon-bula']");

		
	}


}
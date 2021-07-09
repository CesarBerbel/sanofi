using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class BuscaPage
    {

        public By menuBusca = By.XPath("//p[contains(@class,'c-navbar__item c-text c-text--underline c-ml-40')]");

        public By footerBusca = By.XPath("//button[text()='Busca']");
                       
        public By buscar = By.Name("search-text");

        public By lupaBuscar = By.XPath("//input[@name='search-text']/following-sibling::i");



       // public By itemAixa = By.XPath("//a[text()='Aixa®']");


    }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class Treinamentos
	{
		
		public By menuTreinamento = By.XPath("//i[@class='icon menu-profile__indicator icon-chevron-aberto']//following-sibling::div//a[text()='Treinamentos']");

        public By certificado = By.XPath("//a[@target='_black']");

        public By btnProximo = By.XPath("//button[@class='c-survey__button c-survey__button--active']");
        
      //  public By btnEnviar = By.XPath("//button[@class='c-survey__button']");

        public By btnAbrirModulo = By.XPath("//*[@class='body-container']/div[3]/div[3]/div[2]/div/div[3]/div/footer/button");
        public By btnAbrirMod = By.XPath("//div[@class='courses__card']/footer/button");

        public By pdf = By.XPath("//a[@class='c-icon--pdf']");

        public By fecharModulo = By.XPath("//div[@class='classes']//div[@class='c-modal__close icon icon-close']");

        public By btnEnviarResposta = By.XPath("//button[@class='c-quizz-form-container-vert__button']");

        public By btnProximaPergunta = By.XPath("//button[@class='c-quizz-form-container-vert__button']");

      //  public By bula = By.XPath("//a[text()='Clique aqui!']");

    }
}

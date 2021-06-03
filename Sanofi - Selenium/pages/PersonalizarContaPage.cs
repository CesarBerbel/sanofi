using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class PersonalizarContaPage
	{
       
        public By MeuPerfil = By.PartialLinkText("Meu Perfil");

        public By MinhaConta = By.XPath("/html/body/div/div/div[10]/div[1]/div[1]/div/div/div/div[2]/div[1]/div[1]/h2/div");

        public By Celular = By.Name("cell_phone");

        public By BtnSalvar = By.XPath("//button[@class='c-my-profile__save-container--btn']/span");

        public By EmailAlterar = By.Name("email");

        public By AlterarSenha = By.XPath("//button[@class='c-my-profile__button']");

        public By NovaSenha = By.Name("new_password");

        public By RepetirNovaSenha = By.Name("new_password_confirmation");

        public By Cadastrar = By.XPath("//div[@class='modal-change-password__form-buttons']//button");

        public By EspecialidadesInteresses = By.XPath("//div[@class='c-my-profile__section'][2]");

        public By EspecialidadePrimaria = By.Id("expertiseprimary");

        public By EspecialidadeSecundaria = By.Id("expertisesecondary");

        public By BtnPersonalizar = By.XPath("//button[@class='c-base-modal-content__button']");




    }
}

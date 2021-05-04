using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sanofi___Selenium.framework.core;
using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.steps
{
    [Binding]
    public class CriarContaSteps : BaseSteps
    {
        public static string time = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();

        public string emailAleatorio = time + "@server.com";


        [Given(@"clico em Criar Conta")]
        public void DadoClicoEmCriarConta()
        {
			App.Click(BasePage.LoginModal.CriarConta);
        }
               
        [When(@"preencho o Email com email aleatório")]
        public void QuandoPreenchoOEmailComEmailAleatorio()
        {
            App.EnterTextInto(BasePage.LoginModal.EmailCriar, emailAleatorio);
        }

        [When(@"insiro o email aleatório")]
        public void QuandoInsiroOEmailAleatorio()
        {
            App.EnterTextInto(BasePage.CriarContaPage.ConfirmEmail, emailAleatorio);
        }


        [When(@"preencho o campo Número do registro com registro aleatório")]
        public void QuandoPreenchoOCampoNumeroDoRegistroComRegistroAleatorio()
        {

            Random rdm = new Random();
            string numReg = rdm.Next(9999).ToString();
            App.EnterTextInto(BasePage.LoginModal.NumeroRegistro, numReg);

        }

        [When(@"marco a opcao Li e concordo com os Termos e Condições\.")]
        public void QuandoMarcoAOpcaoLiEConcordoComOsTermosECondicoes_()
        {
			App.Select(BasePage.LoginModal.Termos);
        }

		[When(@"eu preencho o Celular com ""(.*)""")]
		public void QuandoEuPreenchoOCelularCom(string cel)
		{
			App.EnterTextInto(BasePage.LoginModal.CampoCelular, cel);
		}

		[When(@"Eu preencho o campo Nome com ""(.*)""")]
        public void QuandoEuPreenchoOCampoNomeCom(string nome)
        {
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("sf-name")));
			App.EnterTextInto(BasePage.LoginModal.Nome, nome);
        }
        
        [When(@"preencho o campo Sobrenome com ""(.*)""")]
        public void QuandoPreenchoOCampoSobrenomeCom(string sobreNome)
        {
			App.EnterTextInto(BasePage.LoginModal.Sobrenome, sobreNome);
		}

		[When(@"preencho o campo Adicionar Senha com ""(.*)""")]
        public void QuandoPreenchoOCampoAdicionarSenhaCom(string senha)
        {
			App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("sf-password")));
			App.EnterTextInto(BasePage.LoginModal.Senha, senha);
		}

		[When(@"preencho o campo Repetir Senha com ""(.*)""")]
        public void QuandoPreenchoOCampoRepetirSenhaCom(string senha)
        {
			App.EnterTextInto(BasePage.LoginModal.RepetirSenha, senha);
		}
        
        [When(@"clico em Finalizar")]
        public void QuandoClicoEmFinalizar()
        {
			App.Click(BasePage.LoginModal.BotaoLogar);
        }
        
        [When(@"eu clico em Continuar")]
        public void QuandoEuClicoEmContinuar()
        {
			App.Click(BasePage.LoginModal.BotaoLogar);
		}


        [When(@"preencho o campo do registro com ""(.*)""")]
		public void QuandoPreenchoOCampoDoRegistroCom(string numRegistro)
		{
			App.EnterTextInto(BasePage.LoginModal.NumeroRegistro, numRegistro);
		}


        [When(@"preencho o campo de validação de Email com ""(.*)""")]
        public void QuandoPreenchoOCampoDeValidacaoDeEmailCom(string email)
        {
            App.EnterTextInto(BasePage.LoginModal.ConfirmcaoEmail, email);
        }

        [When(@"preencho o Email com ""(.*)""")]
        public void QuandoPreenchoOEmailCom(string email)
        {
            App.EnterTextInto(BasePage.LoginModal.EmailCriar, email);
        }

        [When(@"clico em Fechar")]
        public void QuandoClicoEmFechar()
        {
            App.Click(BasePage.LoginModal.IconeFechar);
        }

        [When(@"eu clico no menu profile validado para expandir")]
        public void QuandoEuClicoNoMenuProfileValidadoParaExpandir()
        {
            App.Click(BasePage.Home.ProfileMenuSoftLogin);
        }

        [When(@"clico em Criar conta")]
        public void QuandoClicoEmCriarConta()
        {
            App.Click(BasePage.Home.BtnCriarConta);
        }


        [Then(@"devo ver a mensagem de conta criada com sucesso ""(.*)""")]
		public void EntaoDevoVerAMensagemDeContaCriadaComSucesso(string msg)
		{
			string mensagem = App.WaitText("//div[@class='c-text c-text--h4 c-modal-sf-hcp__subtitle']", msg);
			Asserts.VerificarString(msg, mensagem);
		}


		[Then(@"eu devo ser direcionado para página para validar o email")]
		public void EntaoEuDevoSerDirecionadoParaPaginaParaValidarOEmail()
		{
			string msg = App.GetTextBy(By.XPath("//div[@class='c-text c-text--h3 c-modal-sf-hcp__title']"));
			Asserts.VerificarString("Olá, identificamos que você já tem uma conta", msg);
		}


        [Then(@"eu devo ser direcionado para página de finalizacao de cadastro")]
        public void EntaoEuDevoSerDirecionadoParaPaginaDeFinalizacaoDeCadastro()
        {
            string msg = App.GetTextBy(By.XPath("//div[@class='c-base-modal-content__body']/div/div[@class='c-text']"));
            Asserts.VerificarString("Aproveitando seus dados precisamos apenas de quatro informações:", msg);
        }
    }
}
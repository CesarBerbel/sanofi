using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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

    public class PersonalizarContaSteps : BaseSteps
    {

        [When(@"clico em Personalizar")]
        public void QuandoClicoEmPersonalizar()
        {
            App.JClick(BasePage.PersonalizarConta.BtnPersonalizar);
        }
        
        
        [When(@"eu clico em Especialidades e Interesses")]
        public void QuandoEuClicoEmEspecialidadesEInteresses()
        {
            App.Click(BasePage.PersonalizarConta.EspecialidadesInteresses);
        }
               
        
        [When(@"eu escolho a Especialidade primária ""(.*)""")]
        public void QuandoEuEscolhoAEspecialidadePrimaria(string especialidade)
        {
            App.SelecionarDropDown(BasePage.PersonalizarConta.EspecialidadePrimaria, especialidade);
        }
        
        [When(@"eu escolho a Especialidade secundária ""(.*)""")]
        public void QuandoEuEscolhoAEspecialidadeSecundaria(string especialidade)
        {
            App.SelecionarDropDown(BasePage.PersonalizarConta.EspecialidadeSecundaria, especialidade);
        }

        [When(@"eu clico Interesses")]
        public void QuandoEuClicoInteresses()
        {
            App.Click(BasePage.PersonalizarConta.EspecialidadesInteresses);
        }


        [When(@"seleciono em interesses ""(.*)""")]
        public void QuandoSelecionoEmInteresses(string espec)
        {
            App.JClick(By.XPath("//div[contains(@class,'c-select-list__container')]//li[contains(text(),'"+ espec +"')]"));                 
        }
                
        [When(@"eu clico em Salvar")]
        public void QuandoEuClicoEmSalvar()
        {
            App.Click(BasePage.PersonalizarConta.BtnSalvar);
        }
        
        [Then(@"devo ser direcionado para pagina de Perfil")]
        public void EntaoDevoSerDirecionadoParaPaginaDePerfil()
        {
            App.CheckAtualPage("https://stg-cd.sanoficonecta.com.br/perfil");
        }

        [Given(@"eu clico em Meu Perfil")]
        public void DadoEuClicoEmMeuPerfil()
        {
            App.Click(BasePage.PersonalizarConta.MeuPerfil);
        }

        [When(@"eu clico em Minha conta")]
        public void QuandoEuClicoEmMinhaConta()
        {
            App.Click(BasePage.PersonalizarConta.MinhaConta);
        }

        [When(@"eu altero o Celular para um numero valido")]
        public void QuandoEuAlteroOCelularParaUmNumeroValido()
        {
            String javascript = "window.scrollBy(0,500)";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)BrowserFactory.Driver;
            jsExecutor.ExecuteScript(javascript);

            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name("cell_phone")));

            BrowserFactory.Driver.FindElement(BasePage.PersonalizarConta.Celular).Clear();

            Random rdm = new Random();
            string numcel = rdm.Next(999).ToString();
            App.EnterTextInto(BasePage.PersonalizarConta.Celular, "719871655" + numcel);

        }

        [When(@"eu altero o Celular para ""(.*)""")]
        public void QuandoEuAlteroOCelularPara(string cel)
        {
            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name("cell_phone")));
            
            BrowserFactory.Driver.FindElement(BasePage.PersonalizarConta.Celular).Clear();

            App.EnterTextInto(BasePage.PersonalizarConta.Celular, cel);
        }


        [Then(@"devo visualizar a mensagem ""(.*)""")]
        public void EntaoDevoVisualizarAMensagem(string msg)
        {
            string mensagem = App.WaitText("//span[@class='c-text c-text--branco']", msg);
            Asserts.VerificarString(msg, mensagem);
        }


        [Then(@"devo ver a mensagem Celular inválido")]
        public void EntaoDevoVerAMensagemCelularInvalido()
        {
            string mensagem = App.WaitText("//span[@class='form-element__error-message c-text form-element__error-message--show']", "Celular inválido");
            Asserts.VerificarString("Celular inválido", mensagem);
        }

        [When(@"altero o Email com email válido")]
        public void QuandoAlteroOEmailComEmailValido()
        {
            String javascript = "window.scrollBy(0,500)";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)BrowserFactory.Driver;
            jsExecutor.ExecuteScript(javascript);

            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name("email")));
            BrowserFactory.Driver.FindElement(BasePage.PersonalizarConta.EmailAlterar).Clear();

            string time = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
            App.EnterTextInto(BasePage.PersonalizarConta.EmailAlterar, time + "@server.com");
        }

        [When(@"altero o Email para ""(.*)""")]
        public void QuandoAlteroOEmailPara(string email)
        {
            String javascript = "window.scrollBy(0,500)";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)BrowserFactory.Driver;
            jsExecutor.ExecuteScript(javascript);

            App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name("email")));

            BrowserFactory.Driver.FindElement(BasePage.PersonalizarConta.EmailAlterar).Clear();

            App.EnterTextInto(BasePage.PersonalizarConta.EmailAlterar, email);
        }

        [Then(@"devo ver a mensagem Email já cadastrado")]
        public void EntaoDevoVerAMensagemEmailJaCadastrado()
        {
            string mensagem = App.WaitText("//div[@class='c-my-profile__section-form-field grid-lg-12']//p", "Email já cadastrado");
            Asserts.VerificarString("Email já cadastrado", mensagem);
        }

        [Then(@"devo ver a mensagem E-mail inválido")]
        public void EntaoDevoVerAMensagemE_MailInvalido()
        {
            string mensagem = App.WaitText("//div[@class='c-my-profile__section-form-field grid-lg-12']//span[@class='form-element__error-message c-text form-element__error-message--show']", "E-mail inválido");
            Asserts.VerificarString("E-mail inválido", mensagem);
        }

        [When(@"eu clico em Alterar senha")]
        public void QuandoEuClicoEmAlterarSenha()
        {
            App.JClick(BasePage.PersonalizarConta.AlterarSenha);
        }


        [When(@"preencho o campo senha com a nova senha ""(.*)""")]
        public void QuandoPreenchoOCampoSenhaComANovaSenha(string senha)
        {
            App.EnterTextInto(BasePage.PersonalizarConta.NovaSenha, senha);
        }


        [When(@"preencho o campo Repetir Senha com a nova senha ""(.*)""")]
        public void QuandoPreenchoOCampoRepetirSenhaComANovaSenha(string ConfirmarSenha)
        {
            App.EnterTextInto(BasePage.PersonalizarConta.RepetirNovaSenha, ConfirmarSenha);
        }

        [When(@"eu clico em Cadastrar")]
        public void QuandoEuClicoEmCadastrar()
        {
            App.Click(BasePage.PersonalizarConta.Cadastrar);
        }

        [Then(@"devo ver a mensagem Senha inválida")]
        public void EntaoDevoVerAMensagemSenhaInvalida()
        {
            string mensagem = App.WaitText("//div[@class='modal-change-password']//span[@class='form-element__error-message c-text form-element__error-message--show']", "Senha inválida");
            Asserts.VerificarString("Senha inválida", mensagem);
        }


        [Then(@"devo ver a mensagem de erro ""(.*)""")]
        public void EntaoDevoVerAMensagemDeErro(string confirmPasswords)
        {
            string mensagem = App.GetTextBy(By.XPath("//div[@class='modal-change-password__form-field']//span[@class='form-element__error-message c-text form-element__error-message--show']"));
            Asserts.VerificarString(mensagem, confirmPasswords);
        }

        [Then(@"devo ver a Mensagem ""(.*)""")]
        public void EntaoDevoVerAMensagem(string finalizarPersonalizacao)
        {
            string mensagem = App.WaitText("//p[@class='c-my-profile__section-title--error']", finalizarPersonalizacao);
            Asserts.VerificarString(finalizarPersonalizacao, mensagem);
        }


        [Then(@"eu nao devo ver o botao Salvar")]
        public void EntaoEuNaoDevoVerOBotaoSalvar()
        {
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//button[@class='c-my-profile__save-container--btn']/span")).Count == 0, "Botão visível na página");

        }

        [When(@"seleciono ""(.*)"" em Empresa onde trabalha")]
        public void QuandoSelecionoEmEmpresaOndeTrabalha(string empresa)
        {
            App.SelecionarDropDown(BasePage.PersonalizarConta.empresaOndeTrabalha, empresa);

        }

        [When(@"preencho o campo Nome do local onde trabalha com ""(.*)""")]
        public void QuandoPreenchoOCampoNomeDoLocalOndeTrabalhaCom(string local)
        {
            App.EnterTextInto(BasePage.PersonalizarConta.localOndeTrabalha, local);
        }

        [When(@"seleciono a cidade ""(.*)""")]
        public void QuandoSelecionoACidade(string cid)
        {
                       
                Thread.Sleep(TimeSpan.FromMilliseconds(5000));
                Actions act = new Actions(BrowserFactory.Driver);
                act.MoveToElement(BrowserFactory.Driver.FindElement(BasePage.PersonalizarConta.cidade));
                act.Click(BrowserFactory.Driver.FindElement(BasePage.PersonalizarConta.cidade));
                act.Perform();
                BrowserFactory.Driver.FindElement(By.XPath("//div[@class='dropdown-content']/div[contains(text(),'" + cid + "')]")).Click();
        }

        [Then(@"eu não devo ver o campo Cidade")]
        public void EntaoEuNaoDevoVerOCampoCidade()
        {
            Assert.IsTrue(BrowserFactory.Driver.FindElements(By.XPath("//span[text()='Cidade']")).Count == 0, "Campo Cidade visível na tela");
        }

        [Then(@"devo ver a mensagem de campo obrigatorio ""(.*)""")]
        public void EntaoDevoVerAMensagemDeCampoObrigatorio(string msgErro)
        {
            string mensagem = App.WaitText("//span[@class='c-my-profile__save-container--error']", msgErro);
            Asserts.VerificarString(msgErro, mensagem);
        }

        [Then(@"devo ver a mensagem de cidade obrigatória ""(.*)""")]
        public void EntaoDevoVerAMensagemDeCidadeObrigatoria(string msg)
        {
            string mensagem = App.WaitText("//span[text()='Cidade inválida']", msg);
            Asserts.VerificarString(msg, mensagem);
        }

        [Then(@"devo ver a mensagem de Local obrigatório ""(.*)""")]
        public void EntaoDevoVerAMensagemDeLocalObrigatorio(string msg)
        {
            string mensagem = App.WaitText("//span[text()='Local inválido']", msg);
            Asserts.VerificarString(msg, mensagem);


            //string[] mensagens = msgs.Split(',');

            //App._espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'grid-md-10 grid-sm-4 c-pb-0 c-pl-0 c-pr-0 c-pt-0')]")));

            //IList<IWebElement> ErrorMsgs = BrowserFactory.Driver.FindElements(By.XPath("//div[contains(@class,'grid-md-10 grid-sm-4 c-pb-0 c-pl-0 c-pr-0 c-pt-0')]"));

            //string palavra1, palavra2;

            //Assert.AreEqual(mensagens.Length, ErrorMsgs.Count);
            //for (int i = 0; i < mensagens.Length; i++)
            //{
            //    palavra1 = mensagens[i];
            //    palavra2 = ErrorMsgs[i].Text;
            //    Assert.AreEqual(palavra1, palavra2);
            //}
        }

    }
    
}

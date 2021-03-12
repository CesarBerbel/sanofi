using Sanofi___Selenium.framework.Pages;
using Sanofi___Selenium.framework.steps;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Sanofi___Selenium.features
{
    [Binding]
    public class HomePageSteps : BaseSteps
    {
        [Given(@"que eu acesse o sistema")]
        public void DadoQueEuAcesseOSistema()
        {
			App.GoTo(ConfigurationManager.AppSettings["URL"]);
		}
        
        [Given(@"eu clico no menu profile para expandir")]
        public void DadoEuClicoNoMenuProfileParaExpandir()
        {
			App.Click(BasePage.Home.ProfileMenu);
		}
        
        [Given(@"clico em Entrar")]
        public void DadoClicoEmEntrar()
        {
			App.Click(BasePage.Home.Entrar);
		}

		[Given(@"eu clico no menu profile Logado para expandir")]
		public void DadoEuClicoNoMenuProfileLogadoParaExpandir()
		{
			App.JClick(BasePage.Home.ProfileMenuLogged);
		}

	}
}
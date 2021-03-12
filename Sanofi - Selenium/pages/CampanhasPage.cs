using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class CampanhasPage
	{
		public By Compartilhar = By.XPath("//div[@class='c-hero__icons c-hero-campaign-v4__icon grid-lg-2 grid-md-2 grid-sm-4']//i");

		public By Salvar = By.XPath("//div[@class='c-hero__icons c-hero-campaign-v4__icon grid-lg-2 grid-md-2 grid-sm-4']//i[2]");

		public By ProfileMenuLogged = By.XPath("//div[@class='menu-profile__panel menu-profile__panel--logged']");
	}
}

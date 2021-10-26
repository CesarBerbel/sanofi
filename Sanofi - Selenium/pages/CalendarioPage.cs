using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sanofi___Selenium.pages
{
	public class CalendarioPage
    {
		public By btnAoVivo = By.XPath("//div[@class='grid-lg-8 grid-md-6 grid-sm-4 c-p-0']//div[2]//div[1]//div[3]//div[1]//div[1]//div[1]//span[1]");

		public By btnAoMorto = By.XPath("//div[@class='grid-lg-8 grid-md-6 grid-sm-4 c-p-0']//div[2]//div[1]//div[3]//div[1]//div[1]//div[1]//span[1]");

		public By btnAoZumbi = By.XPath("//div[@class='grid-lg-8 grid-md-6 grid-sm-4 c-p-0']//div[2]//div[1]//div[3]//div[1]//div[1]//div[1]//span[1]");

		public By btnAdicCal = By.XPath("//div[@id='calendar-2022-janeiro']//div[@class='c-row c-pt-32 c-pb-0 c-calendar__row']//div[@class='grid-lg-8 grid-md-6 grid-sm-4 c-p-0']//div[@class='c-calendar-card c-container c-m-0 c-calendar__month--item']//div[@class='c-row c-calendar-card__row']//div[@class='grid-lg-8 grid-md-6 grid-lg-ml-4 grid-md-ml-4 grid-sm-4 c-p-0']//div//button[@class='c-button-schedule c-button-schedule--add'][normalize-space()='Adicionar a meu calendário']");

    }
}

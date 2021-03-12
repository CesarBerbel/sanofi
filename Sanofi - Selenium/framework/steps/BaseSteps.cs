using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Sanofi___Selenium.framework.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanofi___Selenium.framework.steps
{
	public abstract class BaseSteps
	{
		static BaseSteps()
		{
			App = new App();
		}

		protected static App App { get; }
	}
}

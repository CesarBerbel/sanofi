//using System.Collections;
//using System.Collections.Generic;
//using System.IO;

//namespace Sanofi___Selenium.framework.core
//{
//	public class Report
//	{
//		private readonly string location;
//		private StreamWriter arquivo;
//		public Report(string location)
//		{
//			this.location = location;
//			arquivo = new StreamWriter(location);
//		}

//		public void Escrever(string texto)
//		{
//			arquivo.WriteLine(texto);
//		}

//		public void GerarArquivo()
//		{
//			arquivo.Close();
//		}
//	}

//	class Suite
//	{
//		private readonly IDictionary<string, Teste> Testes = new Dictionary<string, Teste>();
//		private readonly string Title;

//		public Suite(string title)
//		{
//			this.Title = title;
//		}

//		public Teste AddTeste(string title)
//		{
//			if (Testes.TryGetValue(title, out Teste teste) == false)
//			{
//				teste = new Teste(title);
//				Testes.Add(title, teste);
//			}
//			return teste;
//		}
//	}

//	class Teste
//	{
//		private readonly IDictionary<string, Passos> PassoCenario = new Dictionary<string, Passos>();
//		readonly string title;
//		//public bool passou;

//		public Teste(string title)
//		{
//			this.title = title;
//		}

//		public Passos AddPasso(bool pass, string txtErro, string txtPasso)
//		{
//			if (PassoCenario.TryGetValue(title, out Passos passo) == false)
//			{
//				passo = new Passos();
//				PassoCenario.Add(title, passo);
//			}
			
//			passo.passou = pass;
//			passo.textoErro = txtErro;
//			passo.textoPasso = txtPasso;
//			return passo;
//		}
//	}

//	class Passos
//	{
//		public bool passou;
//		public string textoErro;
//		public string textoPasso;
//	}
//}
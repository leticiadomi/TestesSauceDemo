using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace TestesSauceDemo.Metodos
{
    [TestClass]
    public class Login
    {

        private InicializaDriver _inicializar = new InicializaDriver();
       // private  InicializaDriver _inicializar; //Cria uma variável privada do tipo InicializaDriver.
       // public Login(InicializaDriver inicializar) //Chama a classe Login, criando a variável inicializaDriver, que é do tipo InicializaDriver.
       // {
       //     _inicializar = inicializar; //Atribui a variável _inicializar o valor da variável inicializar, criada no public Login().
       // }

        [TestMethod]
        public void RealizaLogin()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            IWebDriver driver = _inicializar.ObterDriver();
            IWebElement campoEmail = _inicializar.driver.FindElement(By.CssSelector("input#user-name"));
            campoEmail.SendKeys(configuration.GetValue<string>("Logar:Usuario"));

            IWebElement campoSenha = _inicializar.driver.FindElement(By.CssSelector("input#password"));
            campoSenha.SendKeys(configuration.GetValue<string>("Logar:Senha"));
        }
    }
}
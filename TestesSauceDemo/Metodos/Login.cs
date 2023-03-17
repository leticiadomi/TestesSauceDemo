using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace TestesSauceDemo.Metodos
{
    [TestClass]
    public class Login
    {

        private InicializaDriver _inicializar = new InicializaDriver();
       // private  InicializaDriver _inicializar; //Cria uma vari�vel privada do tipo InicializaDriver.
       // public Login(InicializaDriver inicializar) //Chama a classe Login, criando a vari�vel inicializaDriver, que � do tipo InicializaDriver.
       // {
       //     _inicializar = inicializar; //Atribui a vari�vel _inicializar o valor da vari�vel inicializar, criada no public Login().
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
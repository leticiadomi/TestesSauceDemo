using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestesSauceDemo.Metodos
{
    [TestClass]
    public class InicializaDriver
    {
        public IWebDriver driver;
        public WebDriverWait espera;

        [TestInitialize]
        public IWebDriver ObterDriver()
        {
            if(driver == null)
            {
                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                driver = new ChromeDriver(configuration.GetValue<string>("Inicializar:DriverChrome"));
                espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(configuration.GetValue<string>("Inicializar:URL"));
            }
            return driver;
        }
       // [TestMethod]
       // public void Inicializar()
       // {
       //     var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
       //     driver = new ChromeDriver(configuration.GetValue<string>("Inicializar:DriverChrome"));
       //     espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
       //
       //     driver.Manage().Window.Maximize();
       //     driver.Navigate().GoToUrl(configuration.GetValue<string>("Inicializar:URL"));
       // }
    }
}
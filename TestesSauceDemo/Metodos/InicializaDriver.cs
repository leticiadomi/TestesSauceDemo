using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace TestesSauceDemo.Metodos
{
    [TestClass]

    public class InicializaDriver
    {
        

        IWebDriver driver;
        WebDriverWait espera;

        [TestMethod]
        public void Inicializar()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //driver = new ChromeDriver(@"C:\chromedriver_win32");
            driver = new ChromeDriver(configuration.GetValue<string>("DriverChrome"));
            espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
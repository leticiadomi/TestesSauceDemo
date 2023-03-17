using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            driver = new ChromeDriver(configuration.GetValue<string>("DriverChrome"));
            espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
    }
}
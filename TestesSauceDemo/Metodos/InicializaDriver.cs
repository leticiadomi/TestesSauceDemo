
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

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
            driver = new ChromeDriver(@"C:\chromedriver_win32");
            espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SwagLabProject.Selenium.Drivers
{
    [TestClass]
    public class WebDriverSetup
    {
        protected IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
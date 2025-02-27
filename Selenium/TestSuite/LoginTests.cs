using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwagLabProject.Selenium.Actions;
using SwagLabProject.Selenium.Drivers;

namespace SwagLabProject.Selenium.TestSuite
{
    [TestClass]
    public class LoginTests : WebDriverSetup
    {
        [TestMethod]
        public void Login_WithValidCredentials_ShouldBeSuccessful()
        {
            var loginActions = new LoginActions(driver);
            loginActions.Login("standard_user", "secret_sauce");

            var loginPage = new SwagLabProject.Selenium.Pages.LoginPage(driver);
            Assert.IsTrue(driver.Url.Contains("inventory"), "Login failed!");
        }
    }
}
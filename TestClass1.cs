using NUnit.Framework;
using System.Globalization;
using TestProject1.Driver;
using TestProject1.Page;

namespace TestProject1
{
    public class Tests
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();
        }

        [TearDown]
        public void AfterScenario() => WebDriver.CleanUp();

        [Test]
        public void Tc01()
        {
            Login("standard_user", "secret_sauce");
            _homePage.Username.SendKeys("standard_user");
            _homePage.Password.SendKeys("secret_sauce");
            _homePage.Login.Submit();
        }

        public void Login(string name, string password)
        {
            _loginPage.LoginOnPage(name, password);
        }
    }
}
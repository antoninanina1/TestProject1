using NUnit.Framework;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using TestProject1.Driver;
using TestProject1.Page;
using WebDriver = TestProject1.Driver.WebDriver;

namespace TestProject1
{
    public class Tests
    {
        private LoginPage loginPage;
        private HomePage homePage;

        

        [SetUp]
        public void BeforeScenario()
        {
            WebDriver.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();  
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDriver.CleanUp();
        }
  

        [Test]
        public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
        {
            
            loginPage.Username.SendKeys("standard_user");
            loginPage.Password.SendKeys("secret_sauce");
            loginPage.Login.Submit();
        }

        [Test]
        public void TC02()
        {
            loginPage.Username.SendKeys("standard_user");
            loginPage.Password.SendKeys("secret_sauce");
            loginPage.Login.Submit();

            homePage.Photo.Click();
            homePage.BackPack.Click();
            homePage.BackToProduct.Click();
        }

        public void Login(string name, string password)
        {
            loginPage.LoginOnPage(name, password);
        }
        
    }
}
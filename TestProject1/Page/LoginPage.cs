using OpenQA.Selenium;
using WebDriver = TestProject1.Driver.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Page
{
   public class LoginPage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Username => driver.FindElement(By.Id("user-name"));

        public IWebElement Password => driver.FindElement(By.Id("password"));

        public IWebElement Login => driver.FindElement(By.Id("login-button"));

        

        public void LoginOnPage(string name, string password)
        {
            Username.SendKeys(name);
            Password.SendKeys(password);
            Login.Submit(); 
        }
    }

}

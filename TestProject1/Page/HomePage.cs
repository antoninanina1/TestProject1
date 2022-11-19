using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDriver.Instance(); 
       
        
        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("Password"));

        public IWebElement Login => driver.FindElement(By.Id("login-button"));
    }
}

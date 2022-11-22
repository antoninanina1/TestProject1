using OpenQA.Selenium;
using WebDriver = TestProject1.Driver.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDriver.Instance;

        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement Login => driver.FindElement(By.Id("login-button"));

        public IWebElement Photo => driver.FindElement(By.ClassName("inventory_item_img"));

        public IWebElement BackPack => driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));
        public IWebElement BackToProduct => driver.FindElement(By.Id("back-to-products"));

    }

   
}

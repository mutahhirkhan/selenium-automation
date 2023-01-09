using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSubmission
{
    public class Login
    {
        public void LoginWithValidUser(bool shouldClose)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demo.nopcommerce.com";
            driver.FindElement(By.ClassName("ico-login")).Click();
            driver.FindElement(By.Id("Email")).SendKeys("test2@gmail.com");
            driver.FindElement(By.Name("Password")).SendKeys("pass123456789");
            driver.FindElement(By.ClassName("login-button")).Click();
            string actualText1 = driver.FindElement(By.ClassName("topic-block-title")).Text;
            Assert.AreEqual("Welcome to our store", actualText1, "Assert Failed and Login not performed");
            if (shouldClose)
             driver.Close();
        }
    }
}

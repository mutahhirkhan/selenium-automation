using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TOCI_III_Project;

namespace ProjectSubmission
{
    public class Login : BaseClass
    {
        By Email = By.ClassName("singinEmail");
        By Password = By.ClassName("singinPassword");
        By loginIn = By.CssSelector("#formsInnerid > div.signinFormArea.flex > form > div:nth-child(5) > button");
        By checkBox = By.Name("policyAgreement");
        By signOutBtn = By.ClassName("signoutBtn");
        public void LoginWithValidUser()
        {
            driver.FindElement(Email).SendKeys("sher@gmail.com");
            driver.FindElement(Password).SendKeys("pass1234");
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            string actualtext1 = WaitForElement(signOutBtn).Text;
            Assert.AreEqual("Sign Out", actualtext1, "assert failed and login not performed");

        }
    }
}

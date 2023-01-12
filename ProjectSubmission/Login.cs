using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
using TOCI_III_Project;
using System.Threading;

namespace ProjectSubmission
{
    public class Login : BaseClass
    {
        By SignUpBt = By.Name("signupBtn");
        By RegisterUserName = By.ClassName("signupName");
        By RegisterEmail = By.ClassName("signupEmail");
        By RegisterPassword = By.ClassName("signupPassword");
        By Email = By.ClassName("singinEmail");
        By Password = By.ClassName("singinPassword");
        By loginIn = By.CssSelector("#formsInnerid > div.signinFormArea.flex > form > div:nth-child(5) > button");
        By checkBox = By.Name("policyAgreement");
        By signOutBtn = By.ClassName("signoutBtn");
        public void LoginWithValidUser()
        {
            driver.FindElement(Email).SendKeys("daniyal@gmail.com");
            driver.FindElement(Password).SendKeys("abcde1234");
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            string actualtext1 = WaitForElement(signOutBtn).Text;
            Assert.AreEqual("Sign Out", actualtext1, "assert failed and login not performed");
        }
        public void InvalidUserWithEmailAndPassword()
        {
            driver.FindElement(Email).SendKeys("shair@gmail.com");
            driver.FindElement(Password).SendKeys("random1232");
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("There is no user record corresponding to this identifier. The user may have been deleted.", actualtext1, "assert failed and login not performed");
        }
        public void InvalidUserWithPassword()
        {
            driver.FindElement(Email).SendKeys("ali99shair@gmail.com");
            driver.FindElement(Password).SendKeys("random1232");
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("The password is invalid or the user does not have a password.", actualtext1, "assert failed and login not performed");
        }

        public void InvalidEmailFormatted()
        {
            driver.FindElement(Email).SendKeys("sssss");
            driver.FindElement(Password).SendKeys("pass123456789");
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("The email address is badly formatted.", actualtext1, "assert failed and login not performed");
        }
        public void TermsAndConditions()
        {
            driver.FindElement(Email).SendKeys("daniyal@gmail.com");
            driver.FindElement(Password).SendKeys("abcde1234");
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("Please make sure that you agree to the Terms and Conditions", actualtext1, "assert failed and login not performed");
        }
        public void RegisterUser()
        {
            driver.FindElement(SignUpBt).Click();
        }
    }
}

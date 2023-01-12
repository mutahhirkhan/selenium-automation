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
using System.Web;
using OpenQA.Selenium.DevTools.V106.Target;

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
        By loginUp = By.CssSelector("#formsInnerid > div.signupFormArea.flex > form > div:nth-child(5) > button");
        By checkBox = By.Name("policyAgreement");
        By signOutBtn = By.ClassName("signoutBtn");
        public void LoginWithValidUser(string validUserEmail,string validPassword)
        {
            driver.FindElement(Email).SendKeys(validUserEmail);
            driver.FindElement(Password).SendKeys(validPassword);
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            string actualtext1 = WaitForElement(signOutBtn).Text;
            Assert.AreEqual("Sign Out", actualtext1, "assert failed and login not performed");
        }
        public void InvalidUserWithEmailAndPassword(string invalidUserEmail,string invalidUserPassword)
        {
            driver.FindElement(Email).SendKeys(invalidUserEmail);
            driver.FindElement(Password).SendKeys(invalidUserPassword);
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("There is no user record corresponding to this identifier. The user may have been deleted.", actualtext1, "assert failed and login not performed");
        }
        public void InvalidUserWithPassword(string validEmail,string invalidPassword)
        {
            driver.FindElement(Email).SendKeys(validEmail);
            driver.FindElement(Password).SendKeys(invalidPassword);
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("The password is invalid or the user does not have a password.", actualtext1, "assert failed and login not performed");
        }

        public void InvalidEmailFormatted(string emailformatBadly, string validPassword)
        {
            driver.FindElement(Email).SendKeys(emailformatBadly);
            driver.FindElement(Password).SendKeys(validPassword);
            driver.FindElement(checkBox).Click();
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("The email address is badly formatted.", actualtext1, "assert failed and login not performed");
        }
        public void TermsAndConditions(string validUserEmail, string validPassword)
        {
            driver.FindElement(Email).SendKeys(validUserEmail);
            driver.FindElement(Password).SendKeys(validPassword);
            driver.FindElement(loginIn).Click();
            Thread.Sleep(3000);
            string actualtext1 = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            Assert.AreEqual("Please make sure that you agree to the Terms and Conditions", actualtext1, "assert failed and login not performed");
        }
        public void RegisterUser(string createUserName,string createUserEmail,string createUserPassword)
        {
            Thread.Sleep(3000);
            driver.FindElement(SignUpBt).Click();
            driver.FindElement(RegisterUserName).SendKeys(createUserName);
            driver.FindElement(RegisterEmail).SendKeys(createUserEmail);
            driver.FindElement(RegisterPassword).SendKeys(createUserPassword);
            driver.FindElement(loginUp).Click();
            string actualtext1 = WaitForElement(signOutBtn).Text;
            Assert.AreEqual("Sign Out", actualtext1, "assert failed and login not performed");
        }
    }
}

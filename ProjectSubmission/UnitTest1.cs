using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectSubmission
{
    [TestClass]
    public class UnitTest1
    {
        Login Login = new Login();
        [TestMethod]
        public void TestMethod1()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Login.CloseIt();
        }

    }
}

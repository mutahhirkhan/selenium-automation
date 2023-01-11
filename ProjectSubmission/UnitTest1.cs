using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

namespace ProjectSubmission
{
    [TestClass]
    public class UnitTest1
    {
        Login Login = new Login();
        //ExpenseManagement em = new ExpenseManagement();
        FilterTestCase Filter = new FilterTestCase();
        AddTransaction transaction = new AddTransaction();
        [TestMethod]
        public void TestMethod1()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Login.CloseIt();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Login.SeleniumInit();
            Login.InvalidUserWithEmailAndPassword();
            Login.CloseIt();
        }
        [TestMethod]
        public void TestMetod3()
        {
            Login.SeleniumInit();
            Login.InvalidUserWithPassword();
            Login.CloseIt();
        }
        [TestMethod]
        public void TestMethod4()
        {
            Login.SeleniumInit();
            Login.InvalidEmailFormatted();
            Login.CloseIt();
        }
        [TestMethod]
        public void TestMethod5()
        {
            Login.SeleniumInit();
            Login.TermsAndConditions();
            Login.CloseIt();
        }
        [TestMethod]

        public void TestMethod6()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Filter.SelectOpen();
            Filter.CostMaxiToMin();
            //Login.CloseIt();
        }
        [TestMethod]
        public void TestMethod7()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            transaction.AddTransactions();
        }
    }
}

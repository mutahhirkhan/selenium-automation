using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

namespace ProjectSubmission
{
    [TestClass]
    public class UnitTest1
    {
        Login Login = new Login();
        FilterTestCase Filter = new FilterTestCase();
        AddTransaction Transactions = new AddTransaction();
        AmountTime AmountTimeInstance = new AmountTime();

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
            Login.RegisterUser();
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMethod7()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Filter.SelectOpen();
            Filter.CostMaxiToMin(); //For maximum to minimum cost
        }

        [TestMethod]
        public void TestMethod8()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Filter.SelectOpen();
            Filter.CostMinToMaxi(); // Form minimum to maximum cost
        }

        [TestMethod]
        public void TestMethod9()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Filter.SelectOpen();
            Filter.OldToNewDate(); //For old to new date filter
        }

        [TestMethod]
        public void TestMethod10()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Filter.SelectOpen();
            Filter.NewToOldDate(); // for new to old date filter 
        }

        [TestMethod]
        public void TestMethod11()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            Transactions.AddTransactions();
        }
        [TestMethod]
        public void TestMethod12()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser();
            AmountTimeInstance.TransactionsCountCheck();
        }

    }
}

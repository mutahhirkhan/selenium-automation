using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

namespace ProjectSubmission
{
    [TestClass]
    public class UnitTest1
    {
        Login Login = new Login();
        FilterTestCase Filter = new FilterTestCase();
        TransactionsDashboard Transactions = new TransactionsDashboard();
        AmountTime AmountTimeInstance = new AmountTime();

        [TestMethod]
        public void TestMethod1()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMethod2()
        {
            Login.SeleniumInit();
            Login.InvalidUserWithEmailAndPassword("shair@gmail.com", "random1232");
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMetod3()
        {
            Login.SeleniumInit();
            Login.InvalidUserWithPassword("ali99shair@gmail.com", "random1232");
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMethod4()
        {
            Login.SeleniumInit();
            Login.InvalidEmailFormatted("ssss","pass12345");
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMethod5()
        {
            Login.SeleniumInit();
            Login.TermsAndConditions("daniyal@gmail.com", "abcde1234");
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMethod6()
        {
            Login.SeleniumInit();
            Login.RegisterUser("saif","saif@gmail.com","saif123456");
            Login.CloseIt();
        }

        [TestMethod]
        public void TestMethod7()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            Filter.SelectOpen();
            Filter.CostMaxiToMin(); //For maximum to minimum cost
        }

        [TestMethod]
        public void TestMethod8()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            Filter.SelectOpen();
            Filter.CostMinToMaxi(); // Form minimum to maximum cost
        }

        [TestMethod]
        public void TestMethod9()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            Filter.SelectOpen();
            Filter.OldToNewDate(); //For old to new date filter
        }

        [TestMethod]
        public void TestMethod10()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            Filter.SelectOpen();
            Filter.NewToOldDate(); // for new to old date filter 
        }

        [TestMethod]
        public void TestMethod11()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("omer@gmail.com", "pass12345");
            Transactions.AddTransactions("opp","2600","expanse", "05122023");
        }
        [TestMethod]
        public void TestMethod12()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            AmountTimeInstance.TransactionsCountCheck();
        }
        [TestMethod]
        public void TestMethod13()
        {
            Login.SeleniumInit();
            Login.LoginWithValidUser("daniyal@gmail.com", "abcde1234");
            Transactions.TransactionDelete();
            Login.CloseIt();
        }

    }
}

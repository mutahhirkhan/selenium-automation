using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Profiler;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TOCI_III_Project;
namespace ProjectSubmission
{
    internal class AmountTime : BaseClass
    {
        By totalAmount = By.XPath("/html/body/div/div[2]/div[1]/h2");
        By TransactionsList = By.ClassName("transactionList");

        public int GetTransactionsCount()
        {
            try
            {
                By TransactionsList = By.ClassName("transactionList");
                int count = WaitForElement(TransactionsList).FindElements(By.ClassName("transactionListItems")).Count;
                return count;
            }
            catch (NoSuchElementException)
            {

            }
            catch (WebDriverTimeoutException) { }
            return 0;
        }

        public void TransactionsCountCheck()
        {
            int qty = GetTransactionsCount();
            int[] arr = new int[qty];
            for (int i = 0; i < qty; i++)
            {
                //Console.WriteLine(driver.FindElement(By.CssSelector(".transactionList > div:nth-child(" + (i + 1) + ") > div.renderCost.renderItems > p")));
                ///html/body/div/div[4]/div[1]/div[3]/p
                ////html/body/div/div[4]/div[2]/div[3]/p
                Thread.Sleep(500);
                arr[i] = (int)long.Parse(driver.FindElement(By.XPath("html/body/div/div[4]/div[" + (i + 1)+ "]/div[3]/p")).GetAttribute("value"));
                Console.WriteLine("item "+i+" "+arr[i]);
            }
            int calculatedTotal = arr.Sum();
            Thread.Sleep(3000);
            string actualTotal = driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/h2")).GetAttribute("title");


            //Console.WriteLine("totalAmount" + totalAmount);
            //Console.WriteLine("totalAmount1" + totalAmount1);

            //int actualTotal = (int)long.Parse(driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/h2")).GetAttribute("aria-valuetext"));
            Console.WriteLine("calculated " + calculatedTotal);
            Console.WriteLine("actual " + actualTotal);

            Assert.AreEqual(calculatedTotal, actualTotal, "Assert Failed, both amounts are not same");

        }
    }
}

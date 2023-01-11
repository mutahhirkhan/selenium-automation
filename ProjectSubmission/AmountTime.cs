using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Profiler;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOCI_III_Project;
namespace ProjectSubmission
{
    internal class AmountTime : BaseClass
    {
        By totalAmount = By.CssSelector(".amount > h2");
        By TransactionsList = By.ClassName("transactionList");

        public int getTransactionsCount()
        {
            try
            {
                WaitForElement(By.CssSelector("#tbodyid .success"));
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
            int qty = getTransactionsCount();
            int[] arr = new int[qty];

            for (int i = 0; i < qty; i++)
            {
                //Console.WriteLine(driver.FindElement(By.CssSelector(".transactionList > div:nth-child(" + (i + 1) + ") > div.renderCost.renderItems > p")));
                arr[i] = Convert.ToInt32(driver.FindElement(By.CssSelector(".transactionList > div:nth-child(" + (i + 1) + ") > div.renderCost.renderItems > p")).GetAttribute("value"));
            }
            int calculatedTotal = arr.Sum();
            Console.WriteLine(arr[0]); 
            Console.WriteLine(calculatedTotal);
            Console.WriteLine(driver.FindElement(totalAmount));
            int actualTotal = Convert.ToInt32(driver.FindElement(totalAmount).Text);
            Console.WriteLine(calculatedTotal);
            Console.WriteLine(actualTotal);

            Assert.AreEqual(calculatedTotal, actualTotal, "Assert Failed, both amounts are not same");

        }
    }
}

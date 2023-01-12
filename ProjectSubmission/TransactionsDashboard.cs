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
    public class TransactionsDashboard : BaseClass {
        By Title = By.ClassName("title");
        By Cost = By.ClassName("cost");
        SelectElement dropDown;
        By DateCalendar = By.ClassName("transactionAt");
        By DeleteButton = By.XPath("/html/body/div/div[4]/div[1]/div[5]/button/span/span[2]/div/span");

        public void AddTransactions(string productTitle, string productCost, string transctionType, string dateSelect)
        {
            driver.FindElement(Title).SendKeys(productTitle);
            driver.FindElement(Cost).SendKeys(productCost);
            driver.FindElement(By.ClassName("transactionType")).Click();
            dropDown = new SelectElement(driver.FindElement(By.XPath("/html/body/div/div[3]/form/select")));
            dropDown.SelectByValue(transctionType);
            driver.FindElement(By.ClassName("transactionType")).Click();
            driver.FindElement(DateCalendar).SendKeys(dateSelect);
            Thread.Sleep(2000);
            int beforeCount = getCount();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("addBtn")).Click();
            Thread.Sleep(2000);
            int afterCount = getCount();
            if (afterCount>beforeCount)
            {
                Console.WriteLine("Item is added");
            }
            else
            {
                Console.WriteLine("Item is not added");
            }
        }

        public void TransactionDelete()
        {
            Thread.Sleep(2000);
            int beforeDelete = getCount();
            Thread.Sleep(2000);
            driver.FindElement(DeleteButton).Click();
            Thread.Sleep(2000);
            int afterDelete = getCount();
            if (afterDelete < beforeDelete)
            {
                Console.WriteLine("Item is deleted succefully");
            }
            else
            {
                Console.WriteLine("Item is not deleted");
            }
        }

        int getCount()
        {
            int count = WaitForElement(By.ClassName("transactionList")).FindElements(By.ClassName("transactionListItems")).Count();
            return count;
        }
    }

}

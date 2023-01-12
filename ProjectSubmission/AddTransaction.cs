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
    public class AddTransaction : BaseClass {
        By Title = By.ClassName("title");
        By Cost = By.ClassName("cost");
        SelectElement dropDown;
        By DateCalendar = By.ClassName("transactionAt");

        public void AddTransactions()
        {
            driver.FindElement(Title).SendKeys("joopp");
            driver.FindElement(Cost).SendKeys("10000");
            driver.FindElement(By.ClassName("transactionType")).Click();
            dropDown = new SelectElement(driver.FindElement(By.XPath("/html/body/div/div[3]/form/select")));
            dropDown.SelectByValue("income");
            driver.FindElement(By.ClassName("transactionType")).Click();
            driver.FindElement(DateCalendar).SendKeys("09112023");
            int beforeCount = getCount();
            driver.FindElement(By.ClassName("addBtn")).Click();
            int afterCount = getCount();
            if (afterCount>=beforeCount)
            {
                Console.WriteLine("Item is added");
            }
            else
            {
                Console.WriteLine("Item is not added");
            }
        }

        int getCount()
        {
            int count = WaitForElement(By.ClassName("transactionList")).FindElements(By.ClassName("transactionListItems")).Count();
            return count;
        }
    }

}

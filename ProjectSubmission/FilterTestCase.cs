using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Remote;
using TOCI_III_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectSubmission
{

    public class FilterTestCase:BaseClass
    {

        By FilterElement = By.ClassName("sortBy");
        SelectElement dropDown;

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

        //public bool ValidateCostOrder(bool isMaxToMin)
        //{
        //    int count = getTransactionsCount();
        //    int[] arr = new int[count];
        //    for (int i = 0; i < count; i++)
        //    {
        //        arr[i] = (int)long.Parse(driver.FindElement(By.XPath("/html/body/div/div[4]/div["+(i+1)+"]/div[3]/p")).GetAttribute("value"));
        //    }
        //    Assert.AreEqual(arr.Length, 3, "length mistached");
        //    if(isMaxToMin)
        //    {
        //        for (int i = 1; i < arr.Length; i++)
        //            if (arr[i - 1] > arr[i]) return true;
        //        return false;
        //    }
        //    else
        //    {
        //        for (int i = 1; i < arr.Length; i++)
        //            if (arr[i - 1] < arr[i]) return true;
        //        return false;

        //    }
        //}

        public bool ValidateCostAndDateOrder(bool isMaxToMin, bool isCost)
        {
            int count = GetTransactionsCount();
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                ///html/body/div/div[4]/div[3]/div[4]/p
                ///html/body/div/div[4]/div[4]/div[4]/p
                arr[i] = (int)long.Parse(driver.FindElement(By.XPath("/html/body/div/div[4]/div[" + (i + 1) + "]/div["+ (isCost ? 3 : 4) + "]/p")).GetAttribute("value"));
                Console.WriteLine("time "+i+" "+arr[i]);
            }    
            Assert.AreEqual(arr.Length, 3, "length mistached");
            if (isMaxToMin)
            {
                for (int i = 1; i < arr.Length; i++)
                    if (arr[i - 1] > arr[i]) return true;
                return false;
            }
            else
            {
                for (int i = 1; i < arr.Length; i++)
                    if (arr[i - 1] < arr[i]) return true;
                return false;

            }
        }

        public void SelectOpen()
        {
            driver.FindElement(FilterElement).Click();
            dropDown = new SelectElement(driver.FindElement(By.Name("sorting")));
        }
        public void CostMaxiToMin()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("costDowngrade");
            driver.FindElement(FilterElement).Click();
            
            bool isMaxToMin = ValidateCostAndDateOrder(isMaxToMin:true, isCost:true);
            Assert.IsTrue(isMaxToMin);
        }
        public void CostMinToMaxi()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("costUpgrade");
            driver.FindElement(FilterElement).Click();
            
            bool isMinToMax = ValidateCostAndDateOrder(isMaxToMin: false, isCost:true);
            Assert.IsTrue(isMinToMax);
        }
        public void NewToOldDate()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("dateDowngrade");
            driver.FindElement(FilterElement).Click();
            
            bool isMaxToMin = ValidateCostAndDateOrder(isMaxToMin: true, isCost: false);
            Console.WriteLine("isMaxToMin"+ isMaxToMin);
            Assert.IsTrue(isMaxToMin);
    }
        public void OldToNewDate()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("dateUpgrade");
            driver.FindElement(FilterElement).Click();

            bool isMinToMax = ValidateCostAndDateOrder(isMaxToMin: false, isCost: false);
            Console.WriteLine("isMinToMax" + isMinToMax);
            Assert.IsTrue(isMinToMax);
        }
    }
}

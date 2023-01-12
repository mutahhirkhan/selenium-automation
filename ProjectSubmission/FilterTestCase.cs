using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Remote;
using TOCI_III_Project;



namespace ProjectSubmission
{
    public class FilterTestCase:BaseClass
    {
        By FilterElement = By.ClassName("sortBy");
        SelectElement dropDown;

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
        }
        public void CostMinToMaxi()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("costUpgrade");
            driver.FindElement(FilterElement).Click();
        }
        public void NewToOldDate()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("dateDowngrade");
            driver.FindElement(FilterElement).Click();
        }
        public void OldToNewdate()
        {
            Thread.Sleep(3000);
            dropDown.SelectByValue("dateUpgrade");
            driver.FindElement(FilterElement).Click();
        }
    }
}

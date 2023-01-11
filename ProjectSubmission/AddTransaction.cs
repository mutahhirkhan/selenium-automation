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
        SelectElement dropDown = new SelectElement(driver.FindElement(By.ClassName("transactionType")));
        By DateCalendar = By.ClassName("transactionAt");

        public void AddTransactions()
        {
            driver.FindElement(Title).SendKeys("cap");
            driver.FindElement(Cost).SendKeys("20");
            dropDown.SelectByValue("expanse");
            driver.FindElement(DateCalendar).Click();
        }
    }

}

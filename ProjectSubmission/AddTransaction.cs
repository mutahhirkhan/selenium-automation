﻿using OpenQA.Selenium;
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
        //By DateCalendar = By.ClassName("transactionAt");

        public void AddTransactions()
        {
            driver.FindElement(Title).SendKeys("cap");
            driver.FindElement(Cost).SendKeys("20");
            driver.FindElement(By.ClassName("transactionType")).Click();
            dropDown = new SelectElement(driver.FindElement(By.XPath("/html/body/div/div[3]/form/select")));
            dropDown.SelectByValue("income");
            //driver.FindElement(By.ClassName("transactionType")).Click();
            //driver.FindElement(DateCalendar).Click();
        }
    }

}

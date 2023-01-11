using OpenQA.Selenium;
using System.Threading;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
///using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Remote;

using TOCI_III_Project;



namespace ProjectSubmission
{
    public class FilterTestCase:BaseClass
    {
        By FilterElement = By.ClassName("sortBy");
        By CostMaxToMin = By.CssSelector("body > div > div.details > div.sortingDiv > select > option:nth-child(2)");
        By CostMinToMax = By.CssSelector("body > div > div.details > div.sortingDiv > select > option:nth-child(3)");
        By DateNewToOld = By.CssSelector("body > div > div.details > div.sortingDiv > select > option:nth-child(4)");
        By DateOldToNew = By.CssSelector("body > div > div.details > div.sortingDiv > select > option:nth-child(5)");


        // Create object of the Select class
        //SelectElement dropDown = new SelectElement(driver.findElement(By.xpath("//*[@id='oldSelectMenu']")));
        //dropDown.SelectByValue(dayOfTheWeek);

        // Select the option with value "6"
        //se.selectByValue("6");
        SelectElement dropDown;

        public void SelectOpen()
        {
            driver.FindElement(FilterElement).Click();
            dropDown = new SelectElement(driver.FindElement(By.Name("sorting")));

        }
        public void CostMaxiToMin()
        {
            //WaitForElement(CostMaxToMin).Click();
            Thread.Sleep(3000);
            dropDown.SelectByValue("costDowngrade");

        }
        public void CostMinToMaxi()
        {
            //driver.FindElement(CostMinToMax).Click();
            dropDown.SelectByValue("costUpgrade");

        }
        public void NewToOld()
        {
            driver.FindElement(DateNewToOld).Click();

        }
        public void OldToNew()
        {
            driver.FindElement(DateOldToNew).Click();

        }
    }
}

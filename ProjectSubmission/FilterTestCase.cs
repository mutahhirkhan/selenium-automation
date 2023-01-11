using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOCI_III_Project;

namespace ProjectSubmission
{
    public class FilterTestCase:BaseClass
    {
        By FilterElement = By.ClassName("sortBy");
        public void SelectOption()
        {
            driver.FindElement(FilterElement).Click();
        }
    }
}

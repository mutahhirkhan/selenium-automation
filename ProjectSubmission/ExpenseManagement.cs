using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOCI_III_Project;

namespace ProjectSubmission
{
    public class ExpenseManagement : BaseClass
    {
        By deleteHOver = By.CssSelector("body > div > div.transactionList > div:nth-child(1) > div.renderTransactionEdit.renderItems > button > span");
        By deleteBtn = By.CssSelector(".body > div > div.transactionList > div:nth-child(1) > div.renderTransactionEdit.renderItems > button > div > div span");
        public void deleteItem()
        {
            Actions action = new Actions(driver);
            //action.MoveToElement(WaitForElement(deleteHOver)).Perform();
            WaitForElement(deleteHOver).Click();
            WaitForElement(deleteBtn).Click();
        }
    }
}

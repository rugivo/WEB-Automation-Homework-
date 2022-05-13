using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class CartAdressPage:WebDriver
    {
        IWebElement proceedAddress_btn = Driver.FindElement(By.CssSelector("#center_column > form > p > button"));

        public void ProceedAddress()
        {
            proceedAddress_btn.Click();
        }
    }
}

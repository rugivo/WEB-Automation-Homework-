using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class CartShippingPage:WebDriver
    {
        IWebElement proceedShipping_btn = Driver.FindElement(By.CssSelector("#form > p > button"));
        IWebElement aggree_tick = Driver.FindElement(By.CssSelector("#uniform-cgv"));
        public void ProceedShipping()
        {
            proceedShipping_btn.Click();
        }
        public void checkAgreeTickBox()
        {
            aggree_tick.Click();
        }
    }
}

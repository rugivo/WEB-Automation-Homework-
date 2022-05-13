using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class CartPaymentPage:WebDriver
    {
        IWebElement bankwire_btn = Driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(1) > div > p > a"));
       
        public void SelectPayment()
        {
            bankwire_btn.Click();
        }

    }
}

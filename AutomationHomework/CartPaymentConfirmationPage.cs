using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class CartPaymentConfirmationPage:WebDriver
    {
        IWebElement confirm_btn = Driver.FindElement(By.CssSelector("#cart_navigation > button"));

        public void ConfirmPayment()
        {
            confirm_btn.Click();
        }
    }
}

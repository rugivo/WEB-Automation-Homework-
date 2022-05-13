using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class CartPage:WebDriver
    {
        IWebElement proceedCheckout_btn = Driver.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium"));

        public void Proceed()
        {
            proceedCheckout_btn.Click();
        }

    }
}

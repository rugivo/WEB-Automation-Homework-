using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class ItemPage:WebDriver
    {
        IWebElement addtoCart_btn = Driver.FindElement(By.CssSelector("#add_to_cart > button"));
        IWebElement proceedCheckout_btn = Driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a"));
        public void AddToCart()
        {
            addtoCart_btn.Click();
        }
        public void ProceedToCheckOut()
        {
            proceedCheckout_btn.Click();
        }
    }
}

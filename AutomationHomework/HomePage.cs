using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class HomePage:WebDriver
    {
        IWebElement signin_btn = Driver.FindElement(By.ClassName("login"));
        IWebElement item = Driver.FindElement(By.CssSelector("#homefeatured > li:nth-child(2)"));
      
        public void GoToSignInPage()
        {
            signin_btn.Click();
        }
        public void SelectItem()
        {
            item.Click();
        }


    }
}

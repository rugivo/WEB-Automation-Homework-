using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationHomework
{
    public class LoginPage:WebDriver
    {
        IWebElement createAccount_btn = Driver.FindElement(By.CssSelector("#SubmitCreate"));
        IWebElement registration_txt = Driver.FindElement(By.CssSelector("#email_create"));
        IWebElement loginEmail_txt = Driver.FindElement(By.CssSelector("#email"));
        IWebElement loginPassword_txt = Driver.FindElement(By.CssSelector("#passwd"));
        IWebElement login_btn = Driver.FindElement(By.CssSelector("#SubmitLogin"));
        public void CreateAccount()
        {
            createAccount_btn.Click();
        }

        public void EnterRegistrationEmail(string email)
        {
            registration_txt.SendKeys(email);
            createAccount_btn.Click();
        }

        public void EnterLoginDetails(string email, string password)
        {
            loginEmail_txt.SendKeys(email);
            loginPassword_txt.SendKeys(password);
            login_btn.Click();
        }


    }
}

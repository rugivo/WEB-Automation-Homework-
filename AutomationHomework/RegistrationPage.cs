using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using OpenQA.Selenium;

namespace AutomationHomework
{
    public class RegistrationPage: WebDriver
    {
        IWebElement firstName_txt = Driver.FindElement(By.CssSelector("#customer_firstname"));
        IWebElement lastName_txt = Driver.FindElement(By.CssSelector("#customer_lastname"));
        IWebElement password_txt = Driver.FindElement(By.CssSelector("#passwd"));
        IWebElement address_txt = Driver.FindElement(By.CssSelector("#address1"));
        IWebElement city_txt = Driver.FindElement(By.CssSelector("#city"));
        IWebElement state_txt = Driver.FindElement(By.CssSelector("#id_state > option:nth-child(17)"));
        IWebElement zipCode_txt = Driver.FindElement(By.CssSelector("#postcode"));
        IWebElement mobilePhone_txt = Driver.FindElement(By.CssSelector("#phone_mobile"));
        IWebElement register_btn = Driver.FindElement(By.CssSelector("#submitAccount"));

        public void EnterCredentialsAndRegister(string firstname, string lastname,string password,string address,string city,string zipCode, string mobilePhone)
        {

            firstName_txt.SendKeys(firstname);
            lastName_txt.SendKeys(lastname);
            password_txt.SendKeys(password);
            address_txt.SendKeys(address);
            city_txt.SendKeys(city);
            zipCode_txt.SendKeys(zipCode);
            mobilePhone_txt.SendKeys(mobilePhone);
            state_txt.Click();
            register_btn.Click();
        }


    }
}

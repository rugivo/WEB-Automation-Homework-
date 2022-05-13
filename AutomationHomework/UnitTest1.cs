using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AutomationHomework
{
    public class Tests : WebDriver
    {
        public string URL = "http://automationpractice.com/index.php";
        public string email = "emailium745@email.com";
        public string firstName = "Claudia";
        public string lastName = "Claudision";
        public string password = "naujas123";
        public string address = "Karaliaus Mindaugo pr. 50, Kaunas 44333";
        public string city = "Kaunas";
        public string zipcode = "44333";
        public string mobilePhone = "45782658";

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(URL);
        }

        [Test]
        public void Register()
        {
            NavigateToLoginPage();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterRegistrationEmail(email);
            Thread.Sleep(6000);
            RegistrationPage registrationPage = new RegistrationPage();
            registrationPage.EnterCredentialsAndRegister(firstName, lastName, password, address, city, zipcode, mobilePhone);

        }
        [Test]
        public void SignIn()
        {
            NavigateToLoginPage();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterLoginDetails(email, password);
            IWebElement logout_btn = Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(2) > a"));
            Assert.AreEqual(logout_btn.Text, "Sign out", "Error message");
        }

        [Test]
        public void FindItem()
        {
            HomePage homePage = new HomePage();
            homePage.SelectItem();
            IWebElement itemName = Driver.FindElement(By.CssSelector("#center_column > div > div > div.pb-center-column.col-xs-12.col-sm-4 > h1"));
            Assert.AreEqual(itemName.Text, "Blouse");
        }

        [Test]
        public void BuyItem()
        {
            FindItem();
            ItemPage itemPage = new ItemPage();
            itemPage.AddToCart();
            Thread.Sleep(6000);
            itemPage.ProceedToCheckOut();
            CartPage cartPage = new CartPage();
            cartPage.Proceed();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterLoginDetails(email, password);
            CartAdressPage cartAdress = new CartAdressPage();
            cartAdress.ProceedAddress(); 
            CartShippingPage cartShipping = new CartShippingPage();
            cartShipping.checkAgreeTickBox();
            cartShipping.ProceedShipping();
            CartPaymentPage cartPaymentPage = new CartPaymentPage();
            cartPaymentPage.SelectPayment();
            CartPaymentConfirmationPage cartPaymentConfirmationPage = new CartPaymentConfirmationPage();
            cartPaymentConfirmationPage.ConfirmPayment();
            IWebElement backToOrders_btn = Driver.FindElement(By.CssSelector("#center_column > p > a"));
            Assert.AreEqual(backToOrders_btn.Text, "Back to orders");
        }

        public void NavigateToLoginPage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToSignInPage();
        }
        [TearDown]
        public void Close()
        {
            Driver.Close();
        }
    }
}
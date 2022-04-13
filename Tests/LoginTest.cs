using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Pages;
using System;

namespace SeleniumCSharp.Tests
{
    class LoginTest
    {
        IWebDriver webDriver = new ChromeDriver();
        

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("https://www.post.at/");
            //webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void Login()
        {

            HomePage homePage = new(webDriver);
            
            LoginPage loginPage = new(webDriver);
            loginPage.Login("email", "password");
                                   
        }

        //[TearDown]
        //public void TearDown() => webDriver.Quit();

    }
}

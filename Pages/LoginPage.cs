using OpenQA.Selenium;

namespace SeleniumCSharp.Pages
{
    class LoginPage
    {

        
        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        IWebElement TxtUserName => Driver.FindElement(By.Id("signInName"));

        IWebElement TxtPassword => Driver.FindElement(By.Id("password"));

        IWebElement BtnLogin => Driver.FindElement(By.Id("next"));

        public void Login(string userName, string password)
        {
            TxtUserName.SendKeys(userName);
            TxtPassword.SendKeys(password);
            BtnLogin.Submit();
        }
                
    }
}

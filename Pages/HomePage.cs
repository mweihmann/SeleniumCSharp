using OpenQA.Selenium;

namespace SeleniumCSharp.Pages
{
    public class HomePage
    {
        
        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            RejectCookies();
            SignIn();
            
        }

        private IWebDriver WebDriver { get; }

        public IWebElement rejectCookies => WebDriver.FindElement(By.Id("onetrust-reject-all-handler"));
        public IWebElement signInBtn => WebDriver.FindElement(By.XPath("//button[@class ='headerbar__loginBtn logged-out']"));

        public void RejectCookies() => rejectCookies.Click();

        public void SignIn()
        {
            signInBtn.Click();
        }
    }
}

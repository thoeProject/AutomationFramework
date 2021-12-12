using BuildFrameworkCraft.Browser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildFrameworkCraft.Page
{
    public class LoginPage : BasePage
    {
        public LoginPage(Browsers Browser) : base(Browser)
        {
        }

        IWebElement LoginOnDashboard=> Browser.FindElement("//a[text() = 'Log In']");
        IWebElement TextBoxEmail => Browser.FindElement("//input[@name = 'email']");
        IWebElement TextBoxPassword => Browser.FindElement("//input[@name = 'password']");
        IWebElement ButtonLogin => Browser.FindElement("//span[text() = 'Login']");

        public void LoginAccount(string userName, string password)
        {
            LoginOnDashboard.Click();
            TextBoxEmail.SendKeys(userName);
            TextBoxPassword.SendKeys(password);
            ButtonLogin.Click();
        }
    }

  
}

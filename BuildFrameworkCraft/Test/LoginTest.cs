using BuildFrameworkCraft;
using BuildFrameworkCraft.Page;
using BuildFrameworkCraft.Service;
using BuildFrameworkCraft.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using Xunit;

namespace BuildFrameworkCraft
{
    public class LoginTest : BaseTest
    {
        public LoginPage loginPage;

        public LoginTest()
        {
            loginPage = new LoginPage(browser);
        }

        [Fact]
        public void DoLogin()
        {
            string userName = ConfigService.GetValueInConfig(@"username");
            string password = ConfigService.GetValueInConfig(@"password");  
            loginPage.LoginAccount(userName,password);
        }
    }
}
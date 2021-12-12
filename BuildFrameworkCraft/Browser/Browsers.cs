using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;


namespace BuildFrameworkCraft.Browser
{
    public class Browsers
    {
        public IWebDriver Driver;
        public Browsers(BrowserType type = BrowserType.Chrome)
        {
            Driver = BrowserFactory.GetWebDriver(type);
        }

        public Browsers(string browser = "Chrome")
        {
            Enum.TryParse(browser, out BrowserType browserType);
            Driver = BrowserFactory.GetWebDriver(browserType);
        }

        public enum BrowserType
        {
            Chrome, Firefox
        }

        public IWebElement FindElement(string xpath)
        {
            return Driver.FindElement(By.XPath(xpath));
        }

        public void Go(string url)
        {
            Driver.Url = url;
        }

        public void Quit()
        {
            Driver.Quit();
        }

        public class BrowserFactory
        {
            public static IWebDriver GetWebDriver(BrowserType type = BrowserType.Chrome)
            {
                string driverFolder = string.Empty;
                IWebDriver Driver = null;

                switch (type)
                {
                    case BrowserType.Chrome:
                        driverFolder = Directory.GetCurrentDirectory() + @"\WebDriver\" + $"{type}";
                        Driver = new ChromeDriver();
                        Driver.Manage().Window.Maximize();
                        break;
                    case BrowserType.Firefox:
                        driverFolder = Directory.GetCurrentDirectory() + @"\WebDriver\" + $"{type}";
                        Driver = new FirefoxDriver();
                        break;
                }
                return Driver;
            }
        }
    }
}

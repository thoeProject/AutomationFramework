using BuildFrameworkCraft.Browser;
using BuildFrameworkCraft.Service;
using System;
using System.Configuration;

namespace BuildFrameworkCraft.Test
{
    public class BaseTest : IDisposable
    {
        public Browsers browser;

        public BaseTest()
        {
            browser = new Browsers(ConfigService.GetValueInConfig("browser"));
            browser.Go(ConfigService.GetValueInConfig("url"));
        }

        public void Dispose()
        {
            if(browser != null)
            {
               browser.Quit();
            }
        }
    }
}

using System;
using OpenQA.Selenium;

namespace TaskDemo.Services;

public class BrowserService
{
    public BrowserService()
    {
        Driver = Configurator.BrowserType.ToLower() switch
        {
            "chrome" => new DriverFactory().GetChromeDriver(),
            _ => Driver
        };

        Driver.Manage().Window.Maximize();
        Driver.Manage().Cookies.DeleteAllCookies();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(0);
    }

    public IWebDriver? Driver { get; set; }
}

using NUnit.Framework;
using OpenQA.Selenium;
using TaskDemo.Services;

namespace TaskDemo.Tests;

public class BaseTest
{
    protected IWebDriver? Driver;

    [OneTimeSetUp]
    protected void OneTimeSetup()
    {
        Driver = new BrowserService().Driver;
    }

    [OneTimeTearDown]
    protected void OneTimeTearDown()
    {
        Driver!.Quit();
    }
}

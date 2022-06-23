using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TaskDemo.Pages;

namespace TaskDemo.Tests;

[TestFixture]
public class DropDownListTest : BaseTest
{
    [Test]
    public void CountDropDownOptionsTest()
    {
        var dropDownPage = new DropDownPage(Driver, true);

        dropDownPage.IsPageOpened();

        var selectList = new SelectElement(Driver.FindElement(By.TagName("select")));
        IList<IWebElement> elementCount = selectList.Options;
        var expectedValue = 249;
        var countOptions = elementCount.Count;

        countOptions.Should().Be(expectedValue);

        Console.Out.WriteAsync("quantity of select options is " + countOptions);
    }
}

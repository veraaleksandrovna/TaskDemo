using NUnit.Framework;
using TaskDemo.Pages;

namespace TaskDemo.Tests;

[TestFixture]
public class DropDownTest: BaseTest
{
    [Test]
    public void DropDownCountTest()
    {
        var dropDownPage = new DropDownPage(Driver, true);

        Assert.IsTrue(dropDownPage.Logo.Displayed);
    }
}

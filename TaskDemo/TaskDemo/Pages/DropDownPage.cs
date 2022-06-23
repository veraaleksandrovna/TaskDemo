using OpenQA.Selenium;
using TaskDemo.Services;

namespace TaskDemo.Pages;

public class DropDownPage : BasePage
{
    private static readonly By LogoBy = By.Id("logo");

    public DropDownPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public IWebElement Logo => WaitService.WaitElementExist(LogoBy);

    protected override void OpenPage()
    {
        Driver.Navigate().GoToUrl(Configurator.BaseUrl);
    }

    public override bool IsPageOpened()
    {
        try
        {
            return Logo.Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }
}

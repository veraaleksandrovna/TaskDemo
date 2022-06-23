using OpenQA.Selenium;
using TaskDemo.Services;

namespace TaskDemo.Pages;

public class MainPage: BasePage
{
    private static readonly string PageName = "elements";
    
    private static readonly By ElementButtonBy = By.LinkText("Elements");//("//h5[normalize-space()='Elements'");
    private static readonly By LogoBy = By.XPath("//img[@src='/images/Toolsqa.jpg']");


    public IWebElement Logo = WaitService.WaitElementExist(LogoBy);
    public IWebElement ElementButton = Driver.FindElement(ElementButtonBy);
    
    public MainPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override void OpenPage()
    {
        Driver.Navigate().GoToUrl(Configurator.BaseUrl+PageName);
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

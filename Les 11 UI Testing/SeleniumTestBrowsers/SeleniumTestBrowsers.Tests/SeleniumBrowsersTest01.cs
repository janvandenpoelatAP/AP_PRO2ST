using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestBrowsers.Tests;

public class BrowserOperations
{
    private IWebDriver webDriver;

    public BrowserOperations(IWebDriver webDriver)
    {
        this.webDriver = webDriver;
    }
    public void InitBrowser()
    {
        webDriver.Manage().Window.Maximize();
    }
    public string Title
    {
        get { return webDriver.Title; }
    }
    public IWebDriver WebDriver
    {
        get { return webDriver; }
    }
    public void Goto(string url)
    {
        webDriver.Url = url;
    }
    public void Close()
    {
        webDriver.Quit();
    }
}
[TestFixture(Description = "Test Case 01: Chrome")]
public class TestCase01

{
    BrowserOperations brow;

    [SetUp]
    public void Setup()
    {
        // brow = new BrowserOperations(new ChromeDriver());
        brow = new BrowserOperations(new ChromeDriver(@"c:\Webdrivers"));
        brow.InitBrowser();
    }

    [Test(Description = "Test search")]
    public void TestSearch()
    {
        brow.Goto("https://www.duckduckGo.com");

        System.Threading.Thread.Sleep(4000);

        IWebElement element = brow.WebDriver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));

        element.SendKeys("LambdaTest");

        element.Submit();

        System.Threading.Thread.Sleep(4000);

        Assert.Pass();
    }

    [TearDown]
    public void CloseBrowser()
    {
        brow.Close();
    }
}

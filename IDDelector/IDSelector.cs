using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class IDSelector
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";
        string cssPath = "#post-108 > div > figure > img";
        string className = "testClass";


        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        if (cssPathElement.Displayed)
        {
            GreenMessage("cssPath");
        }
        else
        {
            RedMessage("No cssPath");
        }
        if (xPathElement.Displayed)
        {
            GreenMessage("xPath");
        }
        else
        {
            RedMessage("No xPath");
        }

        //IWebElement element = driver.FindElement(By.ClassName(className));

        //Console.WriteLine(value: element.Text);

        Thread.Sleep(7000);
        driver.Quit();
    }


    private static void RedMessage(string v)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string v)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(v);
        Console.ForegroundColor = ConsoleColor.White;

    }
}


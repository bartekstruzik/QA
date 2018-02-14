using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class IDSelector
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/class-name/";
        string className = "testClass";


        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.ClassName(className));

        Console.WriteLine(value: element.Text);

        Thread.Sleep(6000);
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


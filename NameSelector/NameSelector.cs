using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class NameSelector
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("Yes, we can see it");
        }
        else
        {
            RedMessage("We cannot see it");
        }

        Thread.Sleep(4000);

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


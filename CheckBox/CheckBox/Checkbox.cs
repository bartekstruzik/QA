using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Checkbox
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkbox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";

        driver.Navigate().GoToUrl(url);

        checkbox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(1)"));
        checkbox.Click();
        if (checkbox.GetAttribute("checked") == "true")
        {
            Console.Write("Checked");
        }
        else
        {
            Console.WriteLine("Not checked");
        }


        Thread.Sleep(4000);
        driver.Quit();
    }
}

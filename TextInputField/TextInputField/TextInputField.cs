﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


class TextInputField
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";

        driver.Navigate().GoToUrl(url);
        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("First test");

        Thread.Sleep(4000);

        Console.WriteLine(textBox.GetAttribute("value"));

        textBox.Clear();

        Thread.Sleep(3000);
        driver.Quit();

    }
}


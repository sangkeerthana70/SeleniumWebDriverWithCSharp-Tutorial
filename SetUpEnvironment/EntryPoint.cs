﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/");

        Thread.Sleep(5000);

        driver.Quit();
    }
}
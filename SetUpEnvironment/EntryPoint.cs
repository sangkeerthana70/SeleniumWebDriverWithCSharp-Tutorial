using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class EntryPoint
{
    static void Main()
    {
        /*
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/");

        Thread.Sleep(5000);

        driver.Quit();
        */

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todvachev.com/selectors/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        driver.Manage().Window.Maximize();

        //displays a boolean if element is visible or not
        if (element.Displayed)
        {
            GreenMessage("Element is visible");
        }
        else
        {
            RedMessage("Element not visible, something went wrong");
        }
        Thread.Sleep(5000);
        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
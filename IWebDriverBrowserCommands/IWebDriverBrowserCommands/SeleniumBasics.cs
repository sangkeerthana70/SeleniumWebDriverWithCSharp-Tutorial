using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DriverCommands
{
    class SeleniumBasics
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demoqa.com/frames-and-windows");

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            driver.Close();
        }
    }
}

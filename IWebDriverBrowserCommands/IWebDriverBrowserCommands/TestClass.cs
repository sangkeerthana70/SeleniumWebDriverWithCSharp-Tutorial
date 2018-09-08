using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWebDriverBrowserCommands
{
    class TestClass
    {
        [Test]
        public void TestExercise1()
        {
            IWebDriver driver = new ChromeDriver();

            //launch the website
            driver.Url = "http://www.demoqa.com";

            //store title in a string
            String Title = driver.Title;

            //store title length in an int variable
            int TitleLength = driver.Title.Length;

            // Printing Title name on Console
            Console.WriteLine("The title of the page is : " + Title);

            //Printing length  of the title
            Console.WriteLine("The length of the title is : " + TitleLength);

            // Storing URL in String variable
            String PageURL = driver.Url;

            //Storing Url Length in a int variable
            int URLLength = PageURL.Length;

            //Print Url on the console
            Console.WriteLine("The URL of the page is :" + PageURL);

            //Print Url length on the console
            Console.WriteLine("Length of URl is :" + URLLength);

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = PageSource.Length;

            //printing PageSource to a console
            Console.WriteLine("Page source of the page is :" + PageSource);

            //Printing page source length to a console
            Console.WriteLine("The length of the page source is : " + PageSourceLength);

            //closing browser
            //driver.Quit();
        }
    }
}

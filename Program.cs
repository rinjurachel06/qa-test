using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Create a Chrome WebDriver instance
        using (var driver = new ChromeDriver())
        {
            // Open the frontend service URL - change this to correct URL
            driver.Navigate().GoToUrl("http://127.0.0.1:62188/");

            // Wait for page to load
            System.Threading.Thread.Sleep(2000);

            // Find an element on the page and assert its text
            IWebElement greetingElement = driver.FindElement(By.TagName("h1"));
            string greetingText = greetingElement.Text;

            // Assert that the greeting message contains "Hello from the Backend!"
            if (greetingText.Contains("Hello from the Backend!"))
            {
                Console.WriteLine("Integration test passed! Frontend and Backend are integrated.");
            }
            else
            {
                Console.WriteLine("Integration test failed! Frontend and Backend are not properly integrated.");
            }
        }
    }
}

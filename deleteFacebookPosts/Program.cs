using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace deleteFacebookPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var webDriver = LaunchBrowser();
            try
            {
                var facebookAutomation = new FacebookAutomation(webDriver);
                facebookAutomation.Login("my username", "my pass");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while executing automation");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                webDriver.Quit();
            }
        }
        static IWebDriver LaunchBrowser()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");

            var driver = new ChromeDriver(options);
            return driver;
        }
    }
}

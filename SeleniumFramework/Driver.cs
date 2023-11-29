using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void InitializeDriver()
        {
            driver.Value = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static string TakeScreenshot(string method)
        {
            string screenshotFolder = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{method}-{DateTime.Now.ToString("yyyy-MM-dd    (H-mm-ss)")}";
            string screenshotPath = $"{screenshotFolder}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotFolder);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotPath);
            return screenshotPath;
        }

        public static string GetPageTitle()
        {
            return driver.Value.Title;
        }

        public static void QuitDriver()
        {
            driver.Value.Quit();
        }
    }
}

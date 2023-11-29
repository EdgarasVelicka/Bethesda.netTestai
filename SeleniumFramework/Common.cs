using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework
{
    internal class Common
    {
        internal static void OpenPage(string url)
        {
            Driver.driver.Value.Url = url;
        }

        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            IWebElement element = GetElement(locator);
            return element.GetCssValue(propertyName);
        }

        internal static string GetElementHtmlAttributeValue(string locator, string attributeName)
        {
            IWebElement element = GetElement(locator);
            return element.GetAttribute(attributeName);
        }

        internal static List<bool> GetSelectedStatusForElements(string locator)
        {
            List<bool> statusList = new List<bool>();

            List<IWebElement> elements = GetElements(locator);
            foreach (IWebElement element in elements)
            {
                statusList.Add(element.Selected);
            }

            return statusList;
        }

        internal static bool ElementExists(string locator)
        {
            try
            {
                IWebElement element = GetElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static string GetCurrentWindowHandle()
        {
            return Driver.GetDriver().CurrentWindowHandle;
        }

        internal static List<string> GetWindowHandles()
        {
            return Driver.GetDriver().WindowHandles.ToList();
        }

        internal static void SwitchToWindowByHandle(string handle)
        {
            Driver.GetDriver().SwitchTo().Window(handle);
        }

        internal static void SwitchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            List<string> handles = GetWindowHandles();
            foreach (string handle in handles)
            {
                if (handle != parentWindowHandle)
                {
                    SwitchToWindowByHandle(handle);
                    break;
                }
            }
        }

        internal static void WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static void WaitForPageToFullyLoad(int maxTimeout = 1000)
        {
            string pastPageSource = Driver.GetDriver().PageSource;
            int timer = 0;

            while (timer < maxTimeout)
            {
                string currentPageSource = Driver.GetDriver().PageSource;

                if (pastPageSource != currentPageSource)
                {
                    timer = 0;
                } 
                else
                {
                    System.Threading.Thread.Sleep(50);
                    timer += 50;
                }

                pastPageSource = currentPageSource;
            }
        }

        internal static void WaitForElementToFinishTransitionToPosition(string locator, int expectedX, int expectedY)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d =>
            {
                IWebElement element = d.FindElement(By.XPath(locator));
                return element.Location.X == expectedX && element.Location.Y == expectedY;
            });
        }
    }
}

using OpenQA.Selenium;
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
            System.Threading.Thread.Sleep(2000);
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            System.Threading.Thread.Sleep(2000);
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            System.Threading.Thread.Sleep(2000);
            return GetElement(locator).Text;
        }

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            System.Threading.Thread.Sleep(2000);
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
    }
}

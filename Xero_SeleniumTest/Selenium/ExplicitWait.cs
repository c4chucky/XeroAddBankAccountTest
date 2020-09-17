using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xero_SeleniumTest
{
    public class ExplicitWait
    {
        public static IWebElement WaitforElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(DriverProperties.driver, TimeSpan.FromSeconds(30));
            return wait.Until(driver => driver.FindElement(by));
           
        }

    }
}

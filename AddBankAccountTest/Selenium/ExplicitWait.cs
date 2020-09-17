using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddBankAccountTest
{
    public class ExplicitWait
    {
        public static IWebElement WaitforElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(DriverProperties.driver, TimeSpan.FromSeconds(30));
            return wait.Until(driver => driver.FindElement(by));

        }

        public static void WaitForPageToLoad()
        {
            IWait<IWebDriver> wait = new OpenQA.Selenium.Support.UI.WebDriverWait(DriverProperties.driver, TimeSpan.FromSeconds(30.00));

            wait.Until(driver1 => ((IJavaScriptExecutor)DriverProperties.driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

    }
}

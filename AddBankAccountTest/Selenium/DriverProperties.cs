using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddBankAccountTest
{
    public class DriverProperties
    {
        public static IWebDriver driver { get; set; }

        public void CloseDriver()
        {
            DriverProperties.driver.Close();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xero_SeleniumTest
{
    public class ExplicitWait
    {
        [Obsolete]
        public IWebElement WaitforElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(DriverProperties.driver, new TimeSpan(0, 0, 15));
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
           
        }
        

        
        
    }
}

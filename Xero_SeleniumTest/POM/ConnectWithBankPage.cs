using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace Xero_SeleniumTest
{
    public class ConnectWithBankPage
    {
        public IWebElement btnIHaveAForm = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='connectbank-buttonIHaveAForm']"));
        public IWebElement btnIllDoItLater = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='uploadForm-uploadLaterButton']"));
        public IWebElement btnGoToDashboard = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='uploadFormLater-goToDashboardButton']"));
    }

}

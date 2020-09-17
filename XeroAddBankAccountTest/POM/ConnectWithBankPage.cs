using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroAddBankAccountTest
{
    public class ConnectWithBankPage
    {
        public IWebElement btnIHaveAForm = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='connectbank-buttonIHaveAForm']"));
        public IWebElement btnIllDoItLater = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='uploadForm-uploadLaterButton']"));
        public IWebElement btnGoToDashboard = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='uploadFormLater-goToDashboardButton']"));
    }
}

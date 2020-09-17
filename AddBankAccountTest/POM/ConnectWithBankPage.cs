using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddBankAccountTest
{
    public class ConnectWithBankPage
    {
        public IWebElement btnIHaveAForm = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='connectbank-buttonIHaveAForm']"));
        
    }
}

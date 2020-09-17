using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddBankAccountTest
{
    public class DashboardPage
    {
        public IWebElement linkNavigation = ExplicitWait.WaitforElement(By.Name("navigation-menu/accounting"));
        public IWebElement linkBankAccounts = ExplicitWait.WaitforElement(By.XPath("//a[@href='https://go.xero.com/Bank/BankAccounts.aspx']"));

        public IWebElement bankWidget(string accountName)
        {
            string xpath = "//header/a[@data-automationid='bankWidget']/h3[text()='" + accountName + "']";
            return ExplicitWait.WaitforElement(By.XPath(xpath));
        }
        public void NavigateToBankAccounts()
        {
            linkNavigation.Click();
            linkBankAccounts.Click();
        }

    }
}

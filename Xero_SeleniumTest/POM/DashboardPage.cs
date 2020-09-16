using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xero_SeleniumTest
{
    public class DashboardPage
    {
        public DashboardPage()
        {
            PageFactory.InitElements(DriverProperties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "navigation-menu/accounting")]
        public IWebElement btnAccounting { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://go.xero.com/Bank/BankAccounts.aspx']")]
        public IWebElement linkBankAccounts { get; set; }

        [Obsolete]
        public void NavigateToBankAccounts()
        {
            ExplicitWait wait = new ExplicitWait();
            wait.WaitforElement(btnAccounting).Click();
            wait.WaitforElement(linkBankAccounts).Click();
        }

    }
}

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace Xero_SeleniumTest
{
    public class BankAccountsPage
    {
        public BankAccountsPage()
        {
            PageFactory.InitElements(DriverProperties.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/Banking/Account/#find']")]
        public IWebElement btnAddBankAccount { get; set; }

}

}

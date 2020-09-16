using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace Xero_SeleniumTest
{
    public class AddBankAccountsPage
    {
        public AddBankAccountsPage()
        {
            PageFactory.InitElements(DriverProperties.driver, this);
        }

        [FindsBy(How = How.PartialLinkText, Using = "ANZ (NZ)")]
        public IWebElement btnAddBankAccount { get; set; }

    }

}

﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddBankAccountTest
{
    public class BankAccountsPage
    {
        public IWebElement btnAddBankAccount = ExplicitWait.WaitforElement(By.XPath("//a[@href='/Banking/Account/#find']"));
    }
}

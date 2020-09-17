using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroAddBankAccountTest
{
    public class EnterAccountDetailsPage
    {

        public void EnterAccountDetails(string accountName, string accountType, long accountNumber)
        {
            ExplicitWait.WaitforElement(By.Id("accountname-1037-inputEl")).SendKeys(accountName);
            ExplicitWait.WaitforElement(By.Id("accounttype-1039-inputEl")).Click();

            string xpath = "//*@id='boundlist - 1076']//ul/li[text() ='" + accountType + "']";

            SelectElement select = new SelectElement(ExplicitWait.WaitforElement(By.Id("boundlist - 1076")));
            select.SelectByValue(accountType);

            ExplicitWait.WaitforElement(By.Id("accountnumber-1129-inputEl")).SendKeys(accountNumber.ToString());
            ExplicitWait.WaitforElement(By.Id("common-button-submit-1015-btnInnerEl")).Click();
        }

    }
}

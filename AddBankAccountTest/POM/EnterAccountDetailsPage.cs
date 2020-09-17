using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddBankAccountTest
{
    public class EnterAccountDetailsPage
    {
        public void EnterAccountDetails(string accountName, string accountType, long accountNumber)
        {
            ExplicitWait.WaitforElement(By.Id("accountname-1037-inputEl")).SendKeys(accountName);
            ExplicitWait.WaitforElement(By.Id("accounttype-1039-inputEl")).Click();

            string xpath = "//*[@id='boundlist - 1076']//ul/li[text() ='" + accountType + "']";

            //ExplicitWait.WaitforElement(By.Id("accounttype-1039-inputEl")).Click();
            //ExplicitWait.WaitforElement(By.XPath(xpath)).Click();

            IWebElement bankList = ExplicitWait.WaitforElement(By.Id("boundlist-1076"));
            var accTypes = bankList.FindElements(By.TagName("li"));
            foreach (var type in accTypes)
            {
                if (type.GetProperty("innerText") == accountType)
                {
                    type.Click();
                }
            }

            //ExplicitWait.WaitforElement(By.XPath(xpath)).Click();
            //SelectElement select = new SelectElement();
            //select.SelectByValue(accountType);

            ExplicitWait.WaitforElement(By.Id("accountnumber-1068-inputEl")).SendKeys(accountNumber.ToString());
            ExplicitWait.WaitforElement(By.Id("common-button-submit-1015-btnInnerEl")).Click();
        }

    }
}

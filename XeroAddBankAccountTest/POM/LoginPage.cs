using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace XeroAddBankAccountTest
{
    public class LoginPage
    {
        ExplicitWait wait = new ExplicitWait();

        public IWebElement inputUsername = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='Username--input']"));
        public IWebElement inputPassword = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='PassWord--input']"));
        public IWebElement btnLogin = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='LoginSubmit--button']"));

        public void UserLogin()
        {
            inputUsername.SendKeys("charleseckertbrown@gmail.com");
            inputPassword.SendKeys("MyXeroPwrd!2020");
            btnLogin.Click();
        }
    }
}

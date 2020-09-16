using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xero_SeleniumTest
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(DriverProperties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "Username")]
        public IWebElement inputEmail { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement inputPassword { get; set; }

        [FindsBy(How = How.Name, Using = "button")]
        public IWebElement btnLogin { get; set; }

        [Obsolete]
        public void UserLogin()
        {
            ExplicitWait wait = new ExplicitWait();
            wait.WaitforElement(inputEmail).SendKeys("charleseckertbrown@gmail.com");
            wait.WaitforElement(inputPassword).SendKeys("MyXeroPwrd!2020");
            wait.WaitforElement(btnLogin).Click();
        }

    }
}

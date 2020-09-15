using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xero_SeleniumTest.POM
{
    class LoginPage
    {
        //https://login.xero.com/identity/user/login/
        public LoginPage()
        {
            PageFactory.InitElements(DriverProperties.driver, this); 
        }
        public IWebElement inputEmail { get; set; }
        public IWebElement inputPassword { get; set; }
        public IWebElement btnLogin { get; set; }
    }
}

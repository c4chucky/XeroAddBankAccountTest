using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace Xero_SeleniumTest.Steps
{
    [Binding]
    class XeroAddBankAccountSteps
    {
        ExplicitWait wait = new ExplicitWait();

        [Given(@"I login as a Xero User")]
        [Obsolete]
        public void GivenILoginAsAXeroUser()
        {
            //string startupPath = Directory.GetCurrentDirectory();
            //Console.WriteLine("*********************** Startup path is: " + startupPath + "******************************");
            //DriverProperties.driver = new FirefoxDriver(@"C:\Projects\SeleniumC\XeroSeleniumTest\XeroAddBankAccountTest\Xero_SeleniumTest\Drivers");

            DriverProperties.driver = new ChromeDriver(@"C:\Projects\SeleniumC\XeroSeleniumTest\XeroAddBankAccountTest\Xero_SeleniumTest\Drivers");
     
            DriverProperties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            DriverProperties.driver.Navigate().GoToUrl("https://login.xero.com/identity/user/login/");
            
            LoginPage loginPage = new LoginPage();

            loginPage.UserLogin();

            Console.WriteLine("Login as Xero User");
        }

        [Given(@"I navigate to the Accounting, Bank Accounts page")]
        [Obsolete]
        public void GivenINavigateToTheAccountingBankAccountsPage()
        {
            DashboardPage dashboard = new DashboardPage();
            dashboard.NavigateToBankAccounts();
        }

        [When(@"I click Add bank account button")]
        public void WhenIClickAddBankAccountButton()
        {
            Console.WriteLine("Click Add bank account button");

            BankAccountsPage bankAccPage = new BankAccountsPage();
            bankAccPage.btnAddBankAccount.Click();
        }

        [When(@"I select (.*) from the Banks list")]
        [Obsolete]
        public void WhenISelectANZFromTheBanksList(string bankName)
        {
            Console.WriteLine("Select Bank: " + bankName);
            
            IWebElement bank = DriverProperties.driver.FindElement(By.XPath(@"//ul/li[contains(text(),'" + bankName + "')]"));
            wait.WaitforElement(bank).Click();
            
        }

        [When(@"I add my Account Name as (.*)")]
        public void WhenIAddMyAccountNameAs(string p0)
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"Account type as (.*)")]
        public void WhenAccountTypeAs(string p0)
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"add my Credit Card Number as (.*)")]
        public void WhenAddMyCreditCardNumberAs(string p0)
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"I click the Continue button")]
        public void WhenIClickTheContinueButton()
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"I can Download a form for my Bank")]
        public void WhenICanDownloadAFormForMyBank()
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"I upload the form")]
        public void WhenIUploadTheForm()
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"Click return to Dashboard")]
        public void WhenClickReturnToDashboard()
        {
            Console.WriteLine("Click Add bank account button");
        }

        [Then(@"I can see my new bank account in my Xero Organisation")]
        public void ThenICanSeeMyNewBankAccountInMyXeroOrganisation()
        {
            Console.WriteLine("Click Add bank account button");
            DriverProperties.driver.Close();
        }

    }
}

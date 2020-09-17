using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TechTalk.SpecFlow;

namespace XeroAddBankAccountTest.Steps
{
    [Binding]
    class XeroAddBankAccountSteps
    {
        string accountName;

        [Given(@"I login as a Xero User")]
        public void GivenILoginAsAXeroUser()
        {
            string startupPath = Directory.GetCurrentDirectory();
            //Console.WriteLine("*********************** Startup path is: " + startupPath + "******************************");
            //DriverProperties.driver = new FirefoxDriver(@"C:\Projects\SeleniumC\XeroSeleniumTest\XeroAddBankAccountTest\Xero_SeleniumTest\Drivers");
            
            DriverProperties.driver = new ChromeDriver(startupPath);

            DriverProperties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            DriverProperties.driver.Navigate().GoToUrl("https://login.xero.com/identity/user/login/");

            LoginPage loginPage = new LoginPage();

            loginPage.UserLogin();

            Console.WriteLine("Login as Xero User");
        }

        [Given(@"I navigate to the Accounting, Bank Accounts page")]
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
        public void WhenISelectANZFromTheBanksList(string bankName)
        {
            Console.WriteLine("Select Bank: " + bankName);

            string xpath = "//ul/li[contains(text(),'" + bankName + "')]";
            ExplicitWait.WaitforElement(By.XPath(xpath)).Click();

        }

        [When(@"I add my Account Name as (.*) And Account type as (.*) And add my Credit Card Number as (.*)")]
        [Obsolete]
        public void WhenIAddMyAccountNameAs(string acctName, string accountType, long accountNumber)
        {
            Console.WriteLine("Click Add bank account Type");
            EnterAccountDetailsPage page = new EnterAccountDetailsPage();
            page.EnterAccountDetails(acctName, accountType, accountNumber);
            accountName = acctName;

        }

        [When(@"I can select to upload the form later")]
        public void WhenICanSelectToUploadTheFormLater()
        {
            ConnectWithBankPage page = new ConnectWithBankPage();
            page.btnIHaveAForm.Click();

            Console.WriteLine("Click Add bank account button");
        }

        [When(@"Click return to Dashboard")]
        public void WhenClickReturnToDashboard()
        {
            Console.WriteLine("Return to Dashboard");
            ConnectWithBankPage page = new ConnectWithBankPage();
            page.btnGoToDashboard.Click();
        }

        [Then(@"I can see my new bank account in my Xero Organisation")]
        public void ThenICanSeeMyNewBankAccountInMyXeroOrganisation(string expected)
        {
            Console.WriteLine("Assert my account " + expected + " is created");

            DashboardPage page = new DashboardPage();
            string actual = page.bankWidget(accountName).Text;
            Assert.AreEqual(expected, actual);

            DriverProperties.driver.Close();
        }

    }
}

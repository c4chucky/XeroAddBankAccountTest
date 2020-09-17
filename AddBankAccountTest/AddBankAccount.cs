using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;
using System.Threading;

namespace AddBankAccountTest
{
    public class Tests
    {
        string accountName;

        [SetUp]
        public void Setup()
        {
            string startupPath = Directory.GetCurrentDirectory();
            DriverProperties.driver = new ChromeDriver(startupPath);

            DriverProperties.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            DriverProperties.driver.Navigate().GoToUrl("https://login.xero.com/identity/user/login/");
        }

        [Test]
        public void Test1()
        {
            string bankName = "ANZ";
            string acctName = "MyAnzAcc"+randomNum();
            string accountType = "Everyday (day-to-day)";
            long accountNumber = 12340002525444;

            GivenILoginAsAXeroUser();

            GivenINavigateToTheAccountingBankAccountsPage();

            WhenIClickAddBankAccountButton();

            AndISelectBankFromList(bankName);
                       
            WhenIAddMyAccountNameAs(acctName, accountType, accountNumber);

            WhenICanSelectToUploadTheFormLater();

            WhenClickReturnToDashboard();

            ThenICanSeeMyNewBankAccountInMyXeroOrganisation(acctName);
        }

        [TearDown]
        public void Teardown()
        {
            DriverProperties.driver.Close();
        }

        public void GivenILoginAsAXeroUser()
        {
            LoginPage loginPage = new LoginPage();

            loginPage.UserLogin();
            ExplicitWait.WaitForPageToLoad();
        }

        public void GivenINavigateToTheAccountingBankAccountsPage()
        {
            DashboardPage dashboard = new DashboardPage();
            dashboard.NavigateToBankAccounts();
        }

        public void WhenIClickAddBankAccountButton()
        {
            BankAccountsPage bankAccPage = new BankAccountsPage();
            bankAccPage.btnAddBankAccount.Click();
        }

        public void AndISelectBankFromList(string bankName)
        {
            string xpath = "//ul/li[contains(text(),'" + bankName + "')]";
            ExplicitWait.WaitforElement(By.XPath(xpath)).Click();
        }

        public void WhenIAddMyAccountNameAs(string acctName, string accountType, long accountNumber)
        {
            Console.WriteLine("Click Add bank account Type");
            EnterAccountDetailsPage page = new EnterAccountDetailsPage();
            page.EnterAccountDetails(acctName, accountType, accountNumber);
            accountName = acctName;
        }

        public void WhenICanSelectToUploadTheFormLater()
        {
            ExplicitWait.WaitForPageToLoad();
            ConnectWithBankPage page = new ConnectWithBankPage();
            page.btnIHaveAForm.Click();
            IWebElement btnIllDoItLater = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='uploadForm-uploadLaterButton']"));
            btnIllDoItLater.Click();
            ExplicitWait.WaitForPageToLoad();
        }

        public void WhenClickReturnToDashboard()
        {
            ExplicitWait.WaitForPageToLoad();
            Thread.Sleep(3000);
            Actions actions = new Actions(DriverProperties.driver);
			IWebElement btnGoToDashboard = ExplicitWait.WaitforElement(By.XPath("//*[@data-automationid='uploadFormLater-goToDashboardButton']"));
            actions.MoveToElement(btnGoToDashboard);
            btnGoToDashboard.Click();
        }

        public void ThenICanSeeMyNewBankAccountInMyXeroOrganisation(string expected)
        {
            ExplicitWait.WaitForPageToLoad();
            Console.WriteLine("Assert my account " + expected + " is created");

            DashboardPage page = new DashboardPage();
            
            Actions actions = new Actions(DriverProperties.driver);
            actions.MoveToElement(page.bankWidget(accountName));

            string actual = page.bankWidget(accountName).Text;
            Assert.AreEqual(expected, actual);

        }

        public static string randomNum()
        {
            var rand = new Random();
            var bytes = new byte[5];
            string num = "";
            rand.NextBytes(bytes);
            Console.WriteLine("Five random byte values:");
            foreach (byte byteValue in bytes)
                num += (byteValue).ToString();
            return num;
        }
    }
}
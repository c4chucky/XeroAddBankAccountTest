using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Xero_SeleniumTest.Steps
{
    [Binding]
    class XeroAddBankAccountSteps
    {   
        [SetUp]
        [Given(@"I am logged in as a Xero User")]
        public void GivenIAmLoggedInAsAXeroUser()
        {

            Console.WriteLine("Login as Xero User");
        }

        [Test]
        [Given(@"I navigate to the Dashboard")]
        public void GivenINavigateToTheDashboard()
        {
            Console.WriteLine("Navigate to Accounts");
        }

        [When(@"I click Set up now in Get visibility over your cash flow")]
        public void WhenIClickSetUpNowInGetVisibilityOverYourCashFlow()
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"I click the button Connect your bank to import transactions automatically")]
        public void WhenIClickTheButtonConnectYourBankToImportTransactionsAutomatically()
        {
            Console.WriteLine("Click Add bank account button");
        }

        [When(@"I select ANZ from the Banks list")]
        public void WhenISelectANZFromTheBanksList()
        {
            Console.WriteLine("Click Add bank account button");
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
        }

    }
}

Feature: AddNewBankAccount
	As a Xero User,
	In order to manage my business successfully,
	I want to be able to add an “ANZ (NZ)” bank account inside any Xero Organisation.


@mytag
Scenario: Add an ANZ Bank account inside my Xero Organisation
	Given I login as a Xero User
	And I navigate to the Accounting, Bank Accounts page
	When I click Add bank account button
	When I select ANZ from the Banks list
	And I add my Account Name as <MyAnzAcc> 
	And Account type as <Credit Card>
	And add my Credit Card Number as <1234000011112222>
	When I click the Continue button
	And I can Download a form for my Bank
	When I upload the form
	And Click return to Dashboard
	Then I can see my new bank account in my Xero Organisation
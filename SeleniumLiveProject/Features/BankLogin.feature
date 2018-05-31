Feature: Bank Login
	As a user 
	I want to leverage my account credentials
	So that I can login

@BankLogin
Scenario: Verify Bank Login Credentials
	Given I am on the Bank Login Page 
	And I enter in valid credentials
	When I select Login
	Then I am logged in 

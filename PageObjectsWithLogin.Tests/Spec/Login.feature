Feature: Login
	#In order to avoid silly mistakes
	#As a math idiot
	#I want to be told the sum of two numbers

Scenario: Login Success
	Given I go to Login Page
	And I Enter my account "joeychen"
	And I Enter my password "1234"
	When I Login
	Then it should be redirect to Welcome Page
	And it should be displayed "welcome, joeychen" on the screen

	Scenario: Login Failed
	Given I go to Login Page
	And I Enter my account "joeychen"
	And I Enter my password "abc"
	When I Login
	Then it should show error message "wrong account or password" on the screen	
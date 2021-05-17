Feature: Login feature
	In order to access my account
    As a user of the website
    I want to log into the website

Scenario: Successful Login with Valid Credentials
	Given that I am at the NextGen's Login Page	
	When I enter UserName and Password
	And I click LogIn button
	Then Then I should be at the NextGen's portal page

Scenario: Logging in with valid username and blank password
	Given that I am at the NextGen's Login Page
	When I fill the username with "Q10011878"
	And I leave the password blank
	And I click LogIn button
	Then a text 'Password is required.' should appear in the validation errors region

Scenario: Logging in with blank username and valid password
	Given that I am at the NextGen's Login Page
	When I leave the username blank
	And I fill the password with "Ngahr_5678"
	And I click LogIn button
	Then a text 'Username is required.' should appear in the validation errors region

Scenario: Logging in with blank User Name and Password
	Given that I am at the NextGen's Login Page
	When I leave the username blank
	And I leave the password blank
	And I click LogIn button
	Then a text 'Username is required. Password is required.' should appear in the validation errors region

Scenario: Logging in with valid/invalid data
	Given that I am at the NextGen's Login Page
	When I enter following credentials and click login button
	| Username                | Password   |	
	| Q10011878               |            |
	|                         | Ngahr_5678 |
	|                         |            |	
	Then appropriate message or page should get displayed
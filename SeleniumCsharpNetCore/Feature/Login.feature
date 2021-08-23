Feature: Login
	check if login feature works

@mytag
Scenario: login user as administrator
	Given user navigate to application
	And i click the login link
	And user entered username and password
	     | Username | Password |
	     | admin    | password |
	And user click on login
	Then user should be able to login into the application
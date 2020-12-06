Feature: TheInternetTest
	

Scenario: Give wrong username in login.
	Given I am on the correct site
	Then I click on Form Authentication
	And I type my Wrong username
	And I type my correct password
	And I Press Login
	Then I should see unable to log in Username

Scenario: Give wrong password in login.
	Given I am on the correct site
	Then I click on Form Authentication
	And I type my correct username
	And I type my Wrong password
	And I Press Login
	Then I should see unable to log in Password

Scenario: Correctly login to the internet.
	Given I am on the correct site
	Then I click on Form Authentication
	And I type my correct username
	And I type my correct password
	And I Press Login
	Then I should see logged in
Feature: TestCaseThree


Scenario: KeyPresses Checker.
	Given I am on the correct site
	Then I click on Key Presses
	Then I type the a key
	Then I check the a key has been typed
	And I type the space key
	And I check the space key has been typed
	And I type the . key
	And I check the . key has been typed
	And I type the z key
	Then I check the z key has been typed
Feature: TestCaseTwo


Scenario: Scrolling Page Checker.
	Given I am on the correct site
	Then I click on Infinite Scroll
	And I Scroll to the bottem of the page
	And I Scroll to the bottem of the page
	And I Scroll to the Top of the page
	Then I should see Infinite Scroll Text
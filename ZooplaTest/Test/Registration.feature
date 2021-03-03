Feature: Registration
	As a new moneygaming.com player 
	I want to be able to register using my full details 
	So that I can play online casino games

Scenario: Age validation error is displayed when user doesn't input their date of birth
	Given I am on the account registration page
	When I select "Ms" in the title dropdown
	And I introduce my name as "Testy McTestFace"
	And I check the checkbox confirming that I accept the Terms and Conditions and am over 18
	And I click on the JOIN NOW button
	Then I can see "This field is required" under the Date of Birth box
@external
Feature: VerifyDashboardLogin

A short summary of the feature

@tag1
Scenario Outline: User Login to Dashboard
	#Given the user is on the loginpage
	#When the user enters "<Username>" and "<Password>" and clicks on the Login button
	Then the user should be successfully redirected to the select application page and the user selects "<Portal>" 

	And the user redirects to portal dashboard and the user select "<dealer>" from dealer's dropdown

	#When the user select "<dealer>" from dealer's dropdown
	Then the user should be able to see dealer details

	Examples:
	| Username          | Password     | Portal                      | dealer           |
	| AURPR.RESTAPI.CSS | 29^wOGU)F)5g | Customer Information Portal | John Doe Pvt Ltd |
	


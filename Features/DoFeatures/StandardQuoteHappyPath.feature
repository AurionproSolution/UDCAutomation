@External
Feature: StandardQuoteHappyPath

#@sanity
#Scenario Outline: Standard Quote Happy Path 
#
#	Then the user redirected to dashboard Page
#	When the user selects the dealer dropdown
#	And the user Selects the Create Standard Quote dropdown
#	And the user select program "<Program>" in the dropdown
#	And the user select product "<Product>" in the dropdown
#	And the user clicks the Asset type
#	And the user clicks the Asset, Insurance & Trade In Summary button
#	And the suer clicks the Asset & Insurance summary  edit button
#	And the user enter all mandatory fields in the Add Asset page
#	And the user selects the Sales Person in the dropdown
#	And the user enter the Originator reference in the field
#	And the user selects the Asset type
#	And user clicks the Asset&Insurance Summary button and clicks edit button then enter all mandatory fileds
#	And the user clicks the calculator button
#	And the user clicks the Key disclosure and clicks the next button
#	And the user is redirected to customer details page
#	When the user clicks the add borrowerAnd guarantor button
#	And the user selects "Search By"in the dropdown
#	And the user enters the Udc customer number in the field and clicks Search button
#	And the user redirected to browser results and clicks the Add button
#	Then the user navigated to Personal details page
#	When the user  selects "customer role" in  the dropdown
#	And the user enter all required fileds in the personal details page then clicks the Next button
#
#	Then the user is redirected to Address Details page
#	When the user enter the Search filed and select the value
#	And the user enters the Time at address fields
#	And the user clicks the Reuse for the postal Address button
#	And the user enter the Suburbs fields
#	Then the user navigated to Employment Details page
#	When the user clicks the Next button
#	Then the user redirected to Financial position page
#	When the user enter the all required fields in the Financial position page then user clicks the Next button
#	Then the user redirected to the Reference Details page
#	When the user clicks the Check box for conformation then user clicks the Next button
#	Then the user redirected to Customer Details page
#	When the user clicks the Next button
#	Then the user retrive the generated QuoteId
#	And the user Verify Appllication  "<BeforeContractStatus>" before submit
#	When the user clicks the Submit button
#	And the user clicks the check boxes in the Originator Declaration page then clicks the Proceed button
#	Then the user verify Appllication Status "<AfterContractStatus>"
#
#	Examples: 
#	| Program | Product |  BeforeContractStatus| AfterContractStatus |
#	| Program1 | Product1 |  BeforeContractStatus1| AfterContractStatus1 |


 Scenario Outline: Quick Quote and Standard Quote Happy Path
    Then the user is land on the Select Application page
	When the user clicks the Quotes & Application button
	Then the user is redirected to dashboard page
	When the user selects the Dealer dropdown in the dashboard page
	And the user clicks the Create Quick Quote button
	And the user selects product "<Product>" in the dropdown
	And the user selects program "<Program>" in the dropdown
	Then the user validate the cash price by default value
	And the user validate the cash price field error message
	And the user validate the Interest rate filed error message
	When the user enters the cash price in the field
	#And the user enters the Deposit in the field
	And the user enters Interest rate in the filed
	And the user selects the "Term" in the term dropdown
	And the user selects the "<Frequency>" in the dropdown
	And the user clicks the Calculate button
	Then User Navigate to Asset Details Pages and click on Asset, Insurance & Trade-in Summary  button
    And the suer clicks the Asset & Insurance summary  edit button  
    And the user enter all mandatory fields in the Add Asset page
	Then Asset & Insurance Summary popup should be display
    And User clicks Calculate
	And the user clicks the Key disclosure and clicks the next button
    And the user is redirected to customer details page 
    When  the user clicks the add borrower And guarantor button
	And the user enters the Trust in the field and clicks Search button
	And user click on Add New Customer Button
	Then User Navigate to Trust Details page and entre Mandatory details and click on Next Button
	Then User Navigate to Address Details page and entre Mandatory details and click on Next Button
	And  user navigate to Contract Details page and click on submit button
	And the user clicks the check boxes in the Originator Declaration page then clicks the Proceed button
	And Quote submission Message should display
	
	Examples:
	| Username          | Password       | Product            | Program                            |
	| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - MV Dealer           |


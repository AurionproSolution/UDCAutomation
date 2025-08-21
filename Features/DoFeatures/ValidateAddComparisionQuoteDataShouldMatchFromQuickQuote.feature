@External
Feature: ValidateAddComparisionQuoteDataShouldMatchFromQuickQuote

@sanity
Scenario Outline: Validate Add Comparision Quote Data Should Match From Quick Quote

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
	Then after the hit calculation button then AddcomparisonTwo is enabled
	And the Second Quote data should match the first quote
	When the user modifies the second quote's fields
	And the user enter the cash price in the field
	And the user enter Interest rate in the filed
	And the user click the Calculation button
	Then After the Clicking Calculation button then AddcomparisonThree is enabled
	And the third quote data should match the second quote
	


	
Examples:
	| Username          | Password       | Product            | Program                            |
	| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - Equipment Dealer    |
	| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - MV Dealer           |
	| deepak.paramanick | Happywork@1212 | CSA-C-Assigned     | CSA Personal - Equipment Dealer     |
	| deepak.paramanick | Happywork@1212 | CSA-C-Assigned     | CSA Personal - MV Dealer           |
   #| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - RA Dealer           |
	| deepak.paramanick | Happywork@1212 | CSA-B-Direct Fixed | Webform - CSA Business - RA Dealer |
	| deepak.paramanick | Happywork@1212 | CSA-B-Direct Fixed | Webform - CSA Business - Direct    |
	| deepak.paramanick | Happywork@1212 | CSA-B-Direct Fixed | Webform - CSA Business - EQ Dealer |
	| deepak.paramanick | Happywork@1212 | CSA-C-Direct Fixed | Webform - CSA Personal - EQ Dealer |
	| deepak.paramanick | Happywork@1212 | CSA-C-Direct Fixed | Webform - CSA Personal - MV Dealer |
	#| deepak.paramanick | Happywork@1212 | CSA-C-Direct-Fixed | Webform - CSA - Personal RA Dealer |


@sanity
Scenario Outline: Validate the Calculate For Dropdown
	Then the user is land on the Select Application page
	When the user clicks the Quotes & Application button
	Then the user is redirected to dashboard page
	When the user selects the Dealer dropdown in the dashboard page
	And the user clicks the Create Quick Quote button
	And the user selects product "<Product>" in the dropdown
	And the user selects program "<Program>" in the dropdown
	And the user enters the cash price in the field
	And the user enter the balloon percentage in the field
	And the user clicks the Calculate button

	Then after the hit calculation button then AddcomparisonTwo is enabled
	And the Second Quote data should match the first quote

	When the user modifies the second quote's fields
	And the user click the Calculation button
	And the user selects the Calculate For dropdown
	And the user enter the cash price in the field
	And the user enters the deposit in the field
	Then the user validate the balloon Amount is read only before clicking calculation
	#When the user click the Calculation button
	
	Then the user verify balloon Amount before and after calculation
	And After the Clicking Calculation button then AddcomparisonThree is enabled
	And the third quote data should match the second quote
	
	When the user selects the Calculate For dropdown in the Quote three
	#And the user enters the deposit in the field
	#And the user enter Interest rate in the filed
	Then the user validate the cash price is read only before clicking calculation
	When the user enter the balloon percentage in the field
	#And the user click the Calculation button
	Then the user verify cash price before and after calculation

Examples:
	| Username          | Password       | Product            | Program                            |
	| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - Equipment Dealer    |
	#| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - MV Dealer           |
	#| deepak.paramanick | Happywork@1212 | CSA-C-Assigned     | CSA Personal - Equipment Dealer    |
	#| deepak.paramanick | Happywork@1212 | CSA-C-Assigned     | CSA Personal - MV Dealer           |
 #  #| deepak.paramanick | Happywork@1212 | CSA-B-Assigned     | CSA Business - RA Dealer           |
	#| deepak.paramanick | Happywork@1212 | CSA-B-Direct Fixed | Webform - CSA Business - RA Dealer |
	#| deepak.paramanick | Happywork@1212 | CSA-B-Direct Fixed | Webform - CSA Business - Direct    |
	#| deepak.paramanick | Happywork@1212 | CSA-B-Direct Fixed | Webform - CSA Business - EQ Dealer |
	#| deepak.paramanick | Happywork@1212 | CSA-C-Direct Fixed | Webform - CSA Personal - EQ Dealer |
	#| deepak.paramanick | Happywork@1212 | CSA-C-Direct Fixed | Webform - CSA Personal - MV Dealer |
	##| deepak.paramanick | Happywork@1212 | CSA-C-Direct-Fixed | Webform - CSA - Personal RA Dealer |



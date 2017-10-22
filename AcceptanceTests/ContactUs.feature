Feature: ContactUs
	As a glasswall user 
	I want to contact Glasswall for a free trial from “How it works” page

Background: 
	Given I am on glasswall home page	

@mytag
Scenario: Contact to Glasswall for a free trial
	When I navigate to 'How it Works' page via 'Why Glasswall' tab
	Then I should see 'Try Glasswall For Free' on the page
	
Scenario: Email to Glasswall
    Given I navigate to 'How it Works' page via 'Why Glasswall' tab
	And I navigate to 'Request To Free Trial' page
	When I send requst to Glasswall for free trial with given details
	| YourName | YourCompany | YourEmail      | PhoneNumber |
	| Test     | TestCompany | test@gmail.com | 07382828999 |
	Then 'Thank you. Your details have been sent.' message should display
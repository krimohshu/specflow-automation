Feature: Team
	 As a glasswall user
	 I want to navigate to the Management Team page via the Company menu item.
     So I can see that the correct page is displayed

Background: 
	Given I am on glasswall home page	

@mytag
Scenario: Management Team verification
	When I navigate to 'Meet the Team' team page via 'Company' tab
	Then 'Management Team' tab on the 'Meet the Team' page should display correctly
	And The url of the first image should present

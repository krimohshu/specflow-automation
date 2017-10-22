Feature: News
	 As a glasswall user
	 I want to go to the In the News page via the News menu item.
     So I can see the latest news section

	 
Background: 
	Given I am on glasswall home page	

@mytag
Scenario: Verify the News page title and article
	When I navigate to 'In The News' news page via 'News' tab
	Then Page title 'In The News' should display correctly
	And the Article 'UPDATING YOUR PROPERTY’S CYBER SECURITY SYSTEMS AND EDUCATION STAFF ARE KEY TO AVOIDING DAMAGING CYBER-ATTACKS, SAYS GREG SIM OF GLASSWALL SOLUTIONS.' should display correctly
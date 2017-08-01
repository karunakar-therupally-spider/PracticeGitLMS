Feature: Login to LMS and verify 15 Aug is Independence day Holiday and Leave History Logout from LMS

#Background: Pre-condition
	#Given User is navigated to LMS page
	#And LMS page is visible
	#And Login link present on LMS page

Scenario: Login scnario of LMS
	Given User is navigated to LMS page
	When I click on Login link
	#And entered username and passwords 
	#And clicked on Signin button (Signin with Active Directory) 
	Then loggedin user page is displayed
	#And my username displayed at top right corner

#
#Scenario: Verify Independence day is Holiday
#	When I click on Login link
#	And entered username and passwords 
#	And clicked on Signin button (Signin with Active Directory) 
#	Then logged user page is displayed
#	And my username displayed at top right corner
#	And my Dashboard is displayed with Current Leave Balance, Annual Leaves (Applied), Annual Leaves (Approved) and Comp-Off Balance
#	And Upcoming Holidays list showing Indepedence Day as one of the holiday
#
#Scenario: Verify Leave History displayed recently applied 
#	Given Leave History link is displayed on LMS dashboard
#	When Leave History link clicked 
#	Then system display Leave History details with Year End Balance, Encashed, Lapsed and Opening Balance
#	
#	
#Scenario: Verify Logout feature
#	Given displayed on LMS dashboard
#	When User clicked on profile icon
#	Then system should display User details page
#	When user clicks on Signout page
#	Then System should display Back to Login page 



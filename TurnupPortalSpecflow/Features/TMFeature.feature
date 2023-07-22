Feature: This test suite contains test scenerios for time and material page.

Scenario: A. Create a new time and material record 
	Given I log into turnup portal
	When I navigate to the Time and material page
	And I create a new Time and material record 'ABCD'  'keyboard'  '20'
	Then the record should be saved 'ABCD'

	Scenario: B. Edit  time and material record 
	Given I log into turnup portal
	When I navigate to the Time and material page
	And I edit a new Time and material record 'ABCD'  'RENU' 
	Then the record should be updated 'RENU'

	Scenario: C. Delete an existing  time and material record 
	Given I log into turnup portal
	When I navigate to the Time and material page
     And  I delete Time and material record 'RENU' 
	Then the record should be deleted  'RENU'                                 
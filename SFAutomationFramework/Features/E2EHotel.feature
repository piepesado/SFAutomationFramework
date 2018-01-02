Feature: E2E Hotel Flow
	In order to fulfill my client expectations
	As a pinSight agent
	I want to be able to book an hotel rooom

@sniffTesting
Scenario: E2E Hotel Booking
	Given I have entered to pinSight application	
	When I enter NYC to search hotel
	And I have added to cart the selected hotel room
	And I have checked out
	Then room should be booked
	
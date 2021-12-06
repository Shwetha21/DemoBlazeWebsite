Feature: Laptop
	As a customer
	I want to buy a Laptop
	So that I can start working with it

@mytag
Scenario:Sony Vaio I7 is successfully added to the cart
	Given I go in Home page
	And I am in laptop section
	And choose sony Vaio I7
	When i add the laptop to the cart
	Then laptop should be successfully added
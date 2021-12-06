Feature: Monitor
	As a customer
	I want to buy a Monitor
	So that I can start working with it

@mytag
Scenario: Add two numbers
	Given i visit home page
	And I am in Monitor section
	And choose asus monitor
	When i add the monitor to the cart
	Then monitor should be successfully added
Feature: AddingToCart
	As a customer
	I want to add a product to the cart
	So that I can buy it later

@Laptop
Scenario: Adding sony Vaio I7 laptop to the Cart
	Given I go in Home page
	And I am in laptop section
	And choose sony Vaio I7
	When i add the laptop to the cart
	Then laptop should be successfully added

@Monitor
Scenario: Adding asus Monitor to the Cart
	Given i visit home page
	And I am in Monitor section
	And choose asus monitor
	When i add the monitor to the cart
	Then monitor should be successfully added

@Phone @ignore
Scenario: Adding Phone to the Cart
	Given I am in Home page
	And I click on phone I want to buy
	When I add the phone to the cart
	Then the phone should be succeffully added to the cart
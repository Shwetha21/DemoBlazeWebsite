Feature: Buy a Phone
	As a customer
	I want to buy a phone
	So that I can Talk to people

@AddToCart
Scenario: The product is successfully added to the cart
	Given I am in Home page
	And I click on phone I want to buy
	When I add the phone to the cart
	Then the phone should be succeffully added to the cart
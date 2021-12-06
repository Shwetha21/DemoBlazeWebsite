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

@PlaceOrder
Scenario: Successfully placed the order
	Given I am in Cart page
	And I click on place the order
	And I fill in all the details
	When I click on purchace
	Then the order should be placed

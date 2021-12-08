Feature: Place an Order
	As a customer
	I want to place an order for the items present in the cart
	So that I can buy it

@PlaceOrder
Scenario: Place order for items added to the cart
	Given I am in Cart page
	And I click on place the order
	And I fill in all the details
	When I click on purchace
	Then the order should be placed

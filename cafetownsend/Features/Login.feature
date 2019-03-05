Feature: Testing The login Functionality 

@Browser:Chrome
@Browser:firefox
@browser:IE
Scenario Outline: Verify the login finctionality in positive and negative cases
	Given I opened the Login Page
	And I Typed the <username> and <password>
	When I click login
	Then then i should see the home page

Examples: 
| username |  | password |
| Luke     |  |Skywalker |
| nouser   |  |nopassword|
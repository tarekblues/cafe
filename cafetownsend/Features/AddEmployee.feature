Feature: AddEmployee
	

@Browser:Chrome
@Browser:firefox
Scenario Outline: add emplyees
	Given that I loged in  
	And  the home page is opened 
	When I press create 
	Then i shoule be able to create <First Name > and <last Name > and <start Date > and <Email > 
Examples: 
	
| First Name | Last Name | Start Date | Email |
	| tarek     | osama      | 2019-10-10 | tarek@tarek.net |



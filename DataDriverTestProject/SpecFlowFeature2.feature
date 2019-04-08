Feature: w3schools scenario
	
#	1.	Go to page https://www.w3schools.com/ 
#2.	Click on learn html link
#3.	Click on try it yourself button
#4.	Click Run button
#5.	Verify the result
 

@mytag
Scenario: Validate w3schools learn html link
	Given I am on wschools webpage
	When I click on learn html link
	Then page should redirect to 'https://www.w3schools.com/html/default.asp'

@mytag
Scenario: Validate TryitYourself
	Given  I am on learn html webpage
	When click on try it yourself button
	Then Page should navigate to Url 'https://www.w3schools.com/html/tryit.asp?filename=tryhtml_default'


@mytag
Scenario: Validate run button in try it your self page
	Given I am at try it yourself work space
	When I click on Run button
	Then the output should have "This is a heading" and "this is paragragh" tags
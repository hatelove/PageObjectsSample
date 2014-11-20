Feature: GoogleSearch
	In order to help users to find what information they want quickly
	As a user without rich technical experience
	I want to deliver a simple and powerful search feature

Scenario: When I search "91, BDD", joey's blog link should be displayed on the first search result page
	Given I go to Google Search homepage	
	When I serach "91, BDD"
	Then the link "http://www.dotblogs.com.tw/hatelove/category/6261.aspx" should be displayed on the first search result page	
	 

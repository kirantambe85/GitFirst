Feature: Redirect to Company

Background:
    Given I am logged in Ingenta application and user is redirected to dashboard

Scenario: 1.Redirecting to company page from home page
	When I navigate to Companies from dashboard
	Then search company page details should be displayed

Scenario: 2.Redirecting to company landing page from menu option
	When I click Company link from menu option
	Then search company page details should be displayed
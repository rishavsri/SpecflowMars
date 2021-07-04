Feature: MarsQa Specflow Testing

Scenario: Validating whether Description is added successfully
	Given User is able to login Mars QA website successfully
	When User adds Description in the description tab
	Then User is able to successfully add the Description

Scenario: Validating whether User is able to add Availability,Hours and Earn Target successfully
	Given User is able to login Mars QA website successfully
	When User adds Availability,Hours and Earn Target
	Then User is able to successfully add the Availability,Hours and Earn Target

Scenario: Validating whether User is able to add Languages and Skills successfully
	Given User is able to login Mars QA website successfully
	When User adds Languages and Skills
	Then User is able to successfully add the Languages and Skills
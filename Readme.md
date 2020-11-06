# Case Study - Junior FSE MC

## MC: Building .NET core applications through TDD (Includes Patterns, SOLID Principles and Quality Code)

***Problem Statement***

BuddyInfotech was launched by 3 friends in the year 2016.

This company develops IT Solutions to promote digitization on different domains

The team of these 3 Buddies, has received a contract to develop an Online Application - FriendZone APP, for users to maintain the details of their friends, relatives and professional contacts

Going forward, more services can be added to the application like messaging, blogging and sharing documents.

To begin, the backend solution should be developed.

The solution should be available for use to either of the Console or Web Application

In it's first version, this application would serve the need to have a single point of contact for storing and retrieving the details of friends.

The development team should therefore plan and implement an approach to ensure that a quality product is developed with all the functional requirements met, within the given time frame

***Proposed Solution***

The solution developed would be based upon the test cases written for the provided requirements.
Hence, it can be ensured that the solution code generated meets all the criteria for Completeness, Correctness and Quality

***High Level Requirements***

The application design has to undergo frequent changes based on the client requirements. Hence, newer versions of the application should be developed and released in iterations in short sprints.

To ensure the iteration duration does not overshoot the budgeted duration and the product also confirms to the stated requirements, TDD approach should be followed.
The TDD Approach requires Testcases to be written first based upon the requirements and then the solution code should be developed that  complies with the test cases

The solution code should have loosely coupled code to handle business logic and data access logic separately to follow the principle on Separation of Concerns. This requires to have separate code layers for Data Access and Business Logic

Every unit of the solution code should be testable and therefore, a Unit Testing Framework should be used.

Testing should check for Data Validation, Functionality Validation, Model Validation, Error Handling and   Directory / File Existence

Testing should be done for Positive as well as Negative scenarios

The end user of FriendZone Application should be allowed to create, edit and delete friend's details. 

The application should provide search functionality to allow user to search for friend(s) by : ContactId, Firstname, Lastname, Full Name, Birthdate, BloodGroup

The application should have layered architecture for CRUD and Business Logic transactions and each layer should be independently testable

All successful as well as failed create, edit and delete transactions should be logged in text file


***Tech Stack***
- C#
- .NET Core 3.1
- NUnit 3

***Milestones***

* Milestone 1: Writing Test Cases (Approx. 3-4 hours)

    Step 1: Create Class Library Project

    Step 2: Add nuget package(s) for NUnit

    Step 3: Add Test classes for different code layers

    Step 4: Add Test cases in each test class based upon requirements

    Step 5: Configure the test runner 


* Milestone 2: Building .NET Core Application based on TDD

    Step 1: Create .NET Core Application

    Step 2: Add Code layer for CRUD operations

    Step 3: Test the execution of Test cases for unit testing the CRUD code

    Step 4: Add Code layer for Business logic

    Step 5: Test the execution of Test cases for unit testing the business logic
# Case Study - Junior FSE MC

## MC: Building .NET core applications through TDD (Includes Patterns, SOLID Principles and Quality Code)

## Objective

To develop .NET Core Solution for FriendZone Application based on TDD Approach using NUnit Framework

### The estimated effort to complete this assignment is 4-5 hours

### To Do :
    - Fork the boilerplate
    - Clone the repo in your local directory
    - Start coding in your local copy
    - Push the code in git
    - Submit the solution in Hobbes

### Boilerplate
[FriendZoneAPP Boilerplate](https://gitlab-cts.stackroute.in/stack_dotnet_jrfse_assessments_boilerplates/nunit_assessment_1_boilerplate)

### Expected Outcome:
 
Assessment Solution should contain:
- Test code developed using NUnit Framework
- .NET Core Class Libraries for Business Logic and Data Access in conformance with the defined test cases
- Persistence Implementation is Not part of this assessment and hence solution code should be built using static collections

### Instructions
1. Fork this boilerplate repository
2. Clone the boilerplate repository and cd into it
3. Analyze the application requirements as provided with the Readme.md file
4. Design Test Cases for each requirement stated (Refer **Test Specifications** Section for more details)
5. Test cases should assess the functionality for positive and negative scenarios both
6. Test cases should make use of Custom Constraints for comparing domain objects
7. Build the solution as per the test cases 
8. Execute the test cases locally
9. Fix the solution code for failed test cases
10. Push the solution to git and submit on hobbes for automated review

### Test Specifications

1. For the FriendZone Application, the Model representing Friend's Contact  should have following attributes:

    - ContactId
    - Firstname
    - Lastname
    - Birthdate
    - ContactNo
    - Email
    - Address
    - City
    - Pincode
    - BloodGroup
    - Creationdate

2. Input Data Specifications

    - Friend's name should only allow alphabets with minimum length of 3 and should not be null
    - Birthdate should not be greater than system date and friend's age should not be less than 15 years
    - ContactNo should have exactly 10 numeric characters, should be unique and should not be null
    - Pincode should have exactly 6 numeric characters
    - BloodGroup should accept only the values : A+, A-, B+, B-, AB+, AB-, O+, O-
    - Creationdate should be by default always be the system date and should not be null


3. Test Scenarios

    * Model Validation
        - Model representing friend's details should be validated for the required attributes
    * Functional Validation - Positive Scenario
        - Successful addition, modification and deletion of contact details should result into true and the count of contacts should be accordingly updated
        - Successful retrieval of friend(s) details by ContactId, Firstname, Lastname, Fullname, BloodGroup and BirthMonth should return Contact or List of Contact details
    * Functional Validation - Negative Scenario
        - Contact creation/modification should fail for all missing mandatory inputs such as ContactId, Firstname, Lastname, ContactNo and should throw customized exception with user friendly message
        - Contact creation/modification should fail for invalid Birthdate and should throw customized exception with user friendly message
        - Contact creation/modification should fail for invalid inputs for Firstname, Lastname, ContactNo, Pincode and BloodGroup
        - The failed search operations should throw customized exception with user friendly message

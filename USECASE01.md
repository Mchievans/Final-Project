# ISTA Final Project : Use Case 

### Name: Malachi Evans

##### date: March 31, 2019

------------------------------

## Use Case: Select Mechanic

Actors: 
* Registered User
* Registered Shop or Mechanic
* Connection Platform (Website)

Triggers:
* The user has uploaded a documented issue with their vehicle.

Preconditions:
* User is registered in the system.
* mechanic or shop is registered in system.
* Users Vehicle is registered in the system.
*  User has had their car diagnosed using a odbII Code Reader and obtained codes to upload. 

Post-Conditions: 
* The user will set a date and time for service. 
* The parts prosed necessary for service will be established.  
* The mechanic or shop will set an estimated price

Normal Flow:

1. The user will indicate that they want to correct the documented issue with their vehicle.

2.  The system will present them with a choice to choose location preference.

3. The system using the location chosen will present them with mechanics or shops profiles near location of choice. 

4. The user will select a mechanic or shop by reviewing their profile indicating their certifications and specialization.

5. The user will send a message with any other descriptive factors describing the vehicle's issue to the chosen mechanic or shop.

5. The mechanic or shop will be notified of a new message.

6. The mechanic or shop will review the message and indicate whether they can service the vehicle. 

7. The user will be notified of that service is available. 

8. The user will select a time for service on the mechanics or shops page. 

9. The mechanic will follow up with a confirmation and supply 
proposed parts, part price, and estimate service duration.  

Alternate Flows:

3A1: The user enters a location preference for service and there are no registered mechanics or shops in the chosen location. 

1. The system reports the closest mechanics or shops location. 

2. The uses case continues or opts to retrieve local information using yellow pages API. 




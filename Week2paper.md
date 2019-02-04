# Project Inception

## 2.1 Project selection

### By: Malachi Evans

#### Date: January 20, 2019

-------------

##### Introduction and Personal Objective

My name is Malachi Evans, my current tittle is a Sergeant in the United States Army and Student in the MSSA program. Before I obtained my current title, I have worked many previous jobs and have studied a wide variety of subjects. I have worked in security, shipping and receiving, and retail just to name a few all while studying subjects from political science, to respiratory therapy, to geosciences. Through this I have experienced many different environments, learned many things and gained several new interests. However, two things have remained the same throughout and have always been apparent since my childhood. My passion for cars and my robust interest in technology. Now as a MSSA student, in the process of learning programing through C#, I can now combine the two and create a system that reflect both. The system I plan to create is a messaging system that is a community based automotive diagnostic center that takes the diagnosis of the vehicle and places it in the hands of the right expert. 

-------------


##### Data phase Description

The system is a centralized system to connect an issue with the correct problem solver. The messaging system on the backend will be controlled by a database. A user of the system should be able to register and create a post in a community que. The data logged from a user account creation will create a table that includes the users name, user id, a unique id number, their vehicle information to include make, model, year, millage, and the users city they are located in. For the shop owners and mechanics registration information will be similar, it will include shop or mechanic name, location, user id, a unique id number, location, phone number, area of expertise, certifications and address.  When a user posts a message onto the community form their basic user information will be shown and a date column will be created in the database as well as a description of the problem and a column for the important DTC (Data Trouble Code) derived from the OBD (On Board Diagnostic) system of the vehicle. The DTC streamlines the effectiveness of the system and makes it easier for the mechanics to diagnose the issue. It also will provide metrics as time passes, giving insight into what mechanics are more effective than others at resolving certain codes. The last portion of input will be a table where users can input feedback for the mechanic. It will be based on a five-star rating column inputs 1 through 5, a comment column, and the original diagnostic
-------------

##### Programming Phase Description

The programing of the page will be based on the user interface of the system. The page will be controlled by user inputs and events. I will have to write several methods which are called by event actions. These methods will either create a table, update a table or query from an existing table. It will probably function best if it also broken down into different databases between users and mechanics. This will create an easier job with naming conventions as the fully qualified domain names will be completely different and have their will be less need for more creative names. 

-------------

##### Interface Description

The functionality of the sight will operate centered around the interaction of the mechanics and users. The user will input a post in a community que.  The mechanics and shops registered in the system can then go into the community que and based on the diagnosis of the vehicle can bid or input for the opportunity to service the vehicle. The user on the other end can then view the mechanics or shops information such as service history, area of expertise, certifications, and the amount of times they have specifically serviced or solved the specific DTC. The user can then choose who they feel is the best suited mechanic or shop for the job and contact them for maintenance.  Other functions of the system will include a centralized page to buy and sale parts and vehicles as well as a centralized page for mechanics to create advertisements for the services, modifications, and work they offer. 

-------------

##### Conclusion

The first step in achieving these objectives is to start at a point of origin that provides the frame work from the ground up, the database. Establishing this first provides understanding of what is being referenced and allows for the proper queries, methods, and scripts to be written to. In my mind the next step would be the actual design of the application. This would include some features such as a display which sorts categories, input a search into a search bar and the main community page.  The design and the execution allows for the answer or planning question of what code needs to be written to interact with the user interface and the database. Lastly the code will be written, implemented and tested to make sure it is functional. 
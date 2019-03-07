# Database Presentation

## 8.1  Database Presentation

### By: Malachi Evans

#### Date: March 01, 2019

-------------

##### Introduction

My name is Malachi Evans, my current tittle is a Sergeant in the United States Army and Student in the MSSA program. Before I obtained my current title, I have worked many previous jobs and have studied a wide variety of subjects. I have worked in security, shipping and receiving, and retail just to name a few all while studying subjects from political science, to respiratory therapy, to geosciences. Through this I have experienced many different environments, learned many things and gained several new interests. However, two things have remained the same throughout and have always been apparent since my childhood. My passion for cars and my robust interest in technology. Now as a MSSA student, in the process of learning programing, I can now combine the two and create a system that reflect both.

-------------

##### Introduction

My name is Malachi Evans, my current tittle is a Sergeant in the United States Army and Student in the MSSA program. Before I obtained my current title, I have worked many previous jobs and have studied a wide variety of subjects. I have worked in security, shipping and receiving, and retail just to name a few all while studying subjects from political science, to respiratory therapy, to geosciences. Through this I have experienced many different environments, learned many things and gained several new interests. However, two things have remained the same throughout and have always been apparent since my childhood. My passion for cars and my robust interest in technology. Now as a MSSA student, in the process of learning programing through C#, I can now combine the two and create a system that reflect both. The system I plan to create is a messaging system that is a community based automotive diagnostic center that takes the diagnosis of the vehicle and places it in the hands of the right expert. 

---------------------

##### Program Description

The system is a centralized system to connect an issue with the correct problem solver. The messaging system on the backend will be controlled by a database. A user of the system should be able to register and create a post in a community que. The data logged from a user account creation will create a table that includes the users name, user id, a unique id number, their vehicle information to include make, model, year, millage, and the users city they are located in. For the shop owners and mechanics registration information will be similar, it will include shop or mechanic name, location, user id, a unique id number, location, phone number, area of expertise, certifications and address.  When a user posts a message onto the community form their basic user information will be shown and a date column will be created in the database as well as a description of the problem and a column for the important DTC (Data Trouble Code) derived from the OBD (On Board Diagnostic) system of the vehicle. The DTC streamlines the effectiveness of the system and makes it easier for the mechanics to diagnose the issue. It also will provide metrics as time passes, giving insight into what mechanics are more effective than others at resolving certain codes. The last portion of input will be a table where users can input feedback for the mechanic. It will be based on a five-star rating column inputs 1 through 5, a comment column, and the original diagnostic

-------------

##### information architecture

The infortmaion architecture spans on the relationships between the user thier attributes and what they own and the service they need. While for the shop or mechanic it is centered around the attributes they have and the service they can supply. for instance a user has a vehicle, that vehicle has a Diagnoctic Trouble Code so now both the user and vehicle need service and will have an attribute in the service table. This relationship is the same for the mechanic or shop they will also have an attribute in the service table.

-------------------

##### The design Implemntation

THe design is implemented by using five tables in a database. These five tables consit of the User, vehicle, Service, Mechanics, and Shop tables. All consist of a primary key uniqe id. The vehicle table has a primary key of the vehicle id and a foregin key of the userid linking the two togther. Same as the service table it has a primarky of a service id with a foregin key linking the vehicle, shop, user, or mechanic to the service.

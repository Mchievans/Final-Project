﻿
DROP DATABASE IF EXISTS ProjectDatabase;

CREATE DATABASE ProjectDatabase;

DROP TABLE IF EXISTS USERS;

CREATE TABLE USERS
(
USERID INT NOT NULL,
USERNAME VARCHAR(25),
FIRSTNAME VARCHAR(30) NOT NULL,
LASTNAME VARCHAR(30) NOT NULL,
STREET VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL,
STATE VARCHAR(60) NOT NULL,
ZIPCODE VARCHAR(15) NOT NULL, 
PHONE VARCHAR(20) NOT NULL,
DEVICETYPE VARCHAR(10) not null,
--PRIMARY KEY (USERID)
);

GO

BULK INSERT USERS
FROM 'C:\Final Project\DATABASE\USER.CSV'
WITH
(
FIRSTROW = 2,
DATAFILETYPE = 'char',
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
);

GO

SELECT * FROM USERS;

DROP TABLE IF EXISTS SHOP;

CREATE TABLE SHOP
(
SHOPID INT NOT NULL,
SHOPNAME VARCHAR(60),
OWNERFIRSTNAME VARCHAR(30) NOT NULL,
OWNERLASTNAME VARCHAR(30) NOT NULL,
STREET VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL,
STATE VARCHAR(60) NOT NULL,
ZIPCODE VARCHAR(15) NOT NULL, 
PHONE VARCHAR(20) NOT NULL,
DEVICETYPE VARCHAR(10) not null,
SCHEDULE VARCHAR(15),
EXPERTISE VARCHAR(MAX),
CERTIFICATIONS VARCHAR (MAX),
--PRIMARY KEY (SHOPID)
);

GO

BULK INSERT SHOP
FROM 'C:\Final Project\DATABASE\SHOP.CSV'
WITH
(
FIRSTROW = 2,
DATAFILETYPE = 'char',
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
);

GO

SELECT * FROM SHOP;

DROP TABLE IF EXISTS MECHANIC;

CREATE TABLE MECHANIC
(
MECHANICID INT NOT NULL,
MECHANICUSERNAME VARCHAR(60),
MECHANICFIRSTNAME VARCHAR(30) NOT NULL,
MECHANICLASTNAME VARCHAR(30) NOT NULL,
STREET VARCHAR(80) NOT NULL,
CITY VARCHAR(30) NOT NULL,
STATE VARCHAR(60) NOT NULL,
ZIPCODE VARCHAR(15) NOT NULL, 
PHONE VARCHAR(20) NOT NULL,
DEVICETYPE VARCHAR(10) not null,
SCHEDULE VARCHAR(15),
EXPERTISE VARCHAR(MAX),
CERTIFICATIONS VARCHAR(MAX),
--PRIMARY KEY (MECHANICID)
);

GO

BULK INSERT MECHANIC
FROM 'C:\Final Project\DATABASE\MECHANICS.CSV'
WITH
(
FIRSTROW = 2,
DATAFILETYPE = 'char',
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
);

GO

SELECT * FROM MECHANIC;

DROP TABLE IF EXISTS VEHICLE;

CREATE TABLE VEHICLE
(
VEHICLEID INT NOT NULL,
USERID INT NOT NULL,
MAKE VARCHAR(30) NOT NULL,
MODEL VARCHAR(30) NOT NULL,
TYPE VARCHAR(80) NOT NULL,
YEAR DATETIME NOT NULL,
DTC VARCHAR(8) NOT NULL,
DESCRIPTIONOFPROBLEM VARCHAR(MAX),
--PRIMARY KEY (VEHICLEID),
--FOREIGN KEY (USERID)
--REFERENCES USERS(USERID) 
);

GO

BULK INSERT VEHICLE
FROM 'C:\Final Project\DATABASE\VEHICLE.CSV'
WITH
(
FIRSTROW = 2,
DATAFILETYPE = 'char',
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
);

GO

SELECT * FROM VEHICLE;

DROP TABLE IF EXISTS SERVICE;

CREATE TABLE SERVICE
(
SERVICEID INT NOT NULL,
USERID INT NOT NULL,
VEHICLEID INT NOT NULL,
SHOPID INT,
MECHANICID INT,
ESTIMATEDPARTSNEED VARCHAR(MAX),
ESTIMAEDPARTSPRICE MONEY,
ESTIMAEDLABORTIME FLOAT,
ESTIMAEDLABORPRICE MONEY,
ESTIMATEDTOTALPRICE MONEY,
--PRIMARY KEY (SERVICEID),
--FOREIGN KEY (USERID)
--REFERENCES USERS(USERID),
--FOREIGN KEY (MECHANICID)
--REFERENCES MECHANIC(MECHANICID),
--FOREIGN KEY (SHOPID)
--REFERENCES SHOP(SHOPID),
--FOREIGN KEY (VEHICLEID)
--REFERENCES VEHICLE(VEHICLEID)

);

GO

BULK INSERT service
FROM 'C:\Final Project\DATABASE\service.CSV'
WITH
(
FIRSTROW = 2,
DATAFILETYPE = 'char',
FIELDTERMINATOR = ',',
ROWTERMINATOR = '\n'
);

GO
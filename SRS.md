replace "placeholder" with name
*******

# **<div style="text-align: right">  Software Requirements Specification for (placeholder)</div>**

## **<div style="text-align: right">  Version 0.1 </div>**

### **<div style="text-align: right">  Prepared by Malachi Evans </div>**

#### **<div style="text-align: right"> MSSA ISTA Final Project </div>**

##### **<div style="text-align: right">  March 2017</div>**

<div style="page-break-after: always;"></div>

#### **<div style="text-align: center"> Table of Contents </div>**

Table of Contents i 

Revision History  ii 

1. Introduction

2. Overall Description

3. External Interface Requirements

4. System Features

5. Other Nonfunctional Requirements

<div style="page-break-after: always;"></div>


#### **<div style="text-align: center"> Revision History </div>**

<table style="width:100%" border=2px >
<tr>
<th>Name</th>
<th>Date</th>
<th>Version</th>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
</table>

<div style="page-break-after: always;"></div> 

-------

#### **<div style="text-align: center"> 1. Introduction </div>**

**1.1 Purpose**

The Purpose of this document is to present a detailed description of the web application placeholder. It will explain the purpose, scope, features and interfaces of the software. Established also is what the software will do and the constraints under which it must operate. This document is intended for both the potential users and potential developers of this software.

**1.2 Scope** 

placeholder is a web application designed to connect people with vehicle issues with the right person or company suitable to fix the issue. The application will be free to use and available over the web. Vehicle owners "The User" can enter their vehicle information and issue. The shop or mechanic can then view this issue and offer their services. The user can then select their choice based on number of factors. All information input into the will be kept in a data base and a profile will be kept for both the user and shop or mechanic.

**1.3 References** 

 * GitHub : ISTA Final Project
 https://github.com/Mchievans

    * Entity Relational Design
    * Database Design
    * Physical Design
    * Database Implementation   

<div style="page-break-after: always;"></div>

-------

#### **<div style="text-align: center"> 2. Overall Description </div>**


**2.1 Product perspective** 

Placeholder was developed for everyone who experiences vehicle failure or trouble and to eases the stress and uncertainty from that situation. This document contains the list of stakeholders and actors in the instance of a solution. This SRS contains the detailed needs and functions of each stakeholder involved. It also includes the characteristics and constraints as well as dependencies of those instances.

<div style="page-break-after: always;"></div>

-------

#### **<div style="text-align: center"> 3. Specific Requirements </div>**

**3.1 Functionality**

 This section contains the requirements for placeholder.

 **3.1.1 Register Users and Shops or mechanics**

 3.1.1.1  The system shall display a page that will allow users to register in a database.

 3.1.1.2 The system shall display all components of the registration. 

 3.1.1.3 The system shall encrypt username and password of individuals in database.

 3.1.1.4 The system shall not accept usernames and password combinations already in database.

 3.1.1.5 The system shall reject passwords that do not me security requirements.

 **3.1.2 User uploads a vehicle issue message**

 3.1.2.1 The system shall display a page specifically for the vehicle diagnosis.

 3.1.2.2 The system shall have input for a Diagnostic trouble Code (DTC).

 3.1.2.3 The system shall have a section for a description of for the vehicle issue.

**3.1.3 User can browse shop or mechanic Profile**

3.1.3.1 The system shall display a map with shop or mechanics locations.

3.1.3.2 The system shall allow the user to view a list of profiles visible on map.

3.1.3.3 The system shall display a shop or mechanics profile when clicked.

3.1.3.4 The system shall display all information relevant to the mechanic or shop on profile page.


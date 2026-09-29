DROP TABLE Kennels CASCADE CONSTRAINTS;
DROP TABLE KennelTypes CASCADE CONSTRAINTS;
DROP TABLE Clients CASCADE CONSTRAINTS;
DROP TABLE Dogs CASCADE CONSTRAINTS;
DROP TABLE Reservations CASCADE CONSTRAINTS;
CREATE TABLE KennelTypes (
KennelType CHAR(1) NOT NULL CHECK (KennelType IN ('S', 'M', 'L')),
Significance varchar2(20),
CONSTRAINT pk_KennelTypes PRIMARY KEY(KennelType)
);

CREATE TABLE Kennels (
KennelID NUMBER(2) PRIMARY KEY,
KennelType CHAR(1) NOT NULL CHECK (KennelType IN ('S', 'M', 'L')),
Description VARCHAR2(255),
KennelCondition VARCHAR(20) DEFAULT 'Excellent' CHECK (KennelCondition IN ('Excellent', 'Good', 'Fair')),
DailyRate NUMBER(4,2) NOT NULL,
Status VARCHAR2(20) DEFAULT 'Available' CHECK (Status IN ('Available', 'Unavailable')),
 CONSTRAINT fk_Kennel_Types FOREIGN KEY (KennelType) REFERENCES KennelTypes(KennelType));

INSERT INTO KennelTypes
VALUES('S', 'Small');
INSERT INTO KennelTypes
VALUES('M', 'Medium');
INSERT INTO KennelTypes
VALUES('L', 'Large');

INSERT INTO Kennels 
VALUES(1, 'S', 'Outdoor Access with opportunity to mingle with other dogs', 'Good', 25, 'Available');
INSERT INTO Kennels 
VALUES(2, 'M', 'Kennel with large grassy area for active dogs', 'Excellent', 35, 'Available');
INSERT INTO Kennels 
VALUES(3, 'S', 'Spacious Kennel with ventilation and private area', 'Fair', 20, 'Unavailable');
INSERT INTO Kennels 
VALUES(4, 'L', 'Extra Large Kennel with soft bedding and padded floors', 'Excellent', 35, 'Available');
INSERT INTO Kennels 
VALUES(5, 'L', 'Kennel to include soft flooring, easy access for disabled dogs', 'Excellent', 35, 'Unavailable');
INSERT INTO Kennels VALUES(6, 'S', 'Small indoor kennel with heating', 'Excellent', 22, 'Available');
INSERT INTO Kennels VALUES(7, 'S', 'Small outdoor kennel with shaded area', 'Good', 20, 'Available');
INSERT INTO Kennels VALUES(8, 'S', 'Cozy kennel with private bedding', 'Fair', 18, 'Available');
INSERT INTO Kennels VALUES(9, 'S', 'Small kennel close to garden', 'Excellent', 25, 'Available');
INSERT INTO Kennels VALUES(10, 'S', 'Basic small kennel', 'Good', 19, 'Available');
INSERT INTO Kennels VALUES(11, 'M', 'Medium kennel with grassy yard', 'Excellent', 30, 'Available');
INSERT INTO Kennels VALUES(12, 'M', 'Medium kennel with private run', 'Good', 32, 'Available');
INSERT INTO Kennels VALUES(13, 'M', 'Medium indoor kennel with windows', 'Fair', 28, 'Available');
INSERT INTO Kennels VALUES(14, 'M', 'Medium kennel with shaded patio', 'Excellent', 34, 'Available');
INSERT INTO Kennels VALUES(15, 'M', 'Medium kennel next to training field', 'Good', 31, 'Available');
INSERT INTO Kennels VALUES(16, 'L', 'Large luxury kennel with soft flooring', 'Excellent', 40, 'Available');
INSERT INTO Kennels VALUES(17, 'L', 'Large kennel with private exercise yard', 'Good', 38, 'Available');
INSERT INTO Kennels VALUES(18, 'L', 'Spacious large kennel with cooling system', 'Excellent', 42, 'Available');
INSERT INTO Kennels VALUES(19, 'L', 'Large kennel with dog park access', 'Fair', 37, 'Available');
INSERT INTO Kennels VALUES(20, 'L', 'Large shaded kennel with comfort bedding', 'Excellent', 39, 'Available');





CREATE Table Clients (
ClientID NUMBER(2) PRIMARY KEY,
FirstName VARCHAR2(30) NOT NULL,
LastName VARCHAR2(20) NOT NULL,
Email VARCHAR(35) NOT NULL,
Password VARCHAR2(40) NOT NULL,
PhoneNum VARCHAR2 (20)
);

INSERT INTO Clients (ClientID, FirstName, LastName, Email, Password, PhoneNum)
VALUES (1, 'Emily', 'Johnson', 'emilyjohnson@gmail.com', 'password', '555-123-4567');

INSERT INTO Clients (ClientID, FirstName, LastName, Email, Password, PhoneNum)
VALUES (2, 'Michael', 'Smith', 'michael.smith@example.com', 'securePass!', '555-234-5678');

INSERT INTO Clients (ClientID, FirstName, LastName, Email, Password, PhoneNum)
VALUES (3, 'Sophia', 'Davis', 'sophia.davis@example.com', 's0ph!aPwd', '555-345-6789');

INSERT INTO Clients (ClientID, FirstName, LastName, Email, Password, PhoneNum)
VALUES (4, 'Daniel', 'Brown', 'daniel.brown@example.com', 'd@nbrown22', '555-456-7890');

INSERT INTO Clients (ClientID, FirstName, LastName, Email, Password, PhoneNum)
VALUES (5, 'Olivia', 'Martinez', 'olivia.martinez@example.com', 'OliviaPwd123', '555-567-8901');


CREATE Table Dogs (
DogID NUMBER(3) PRIMARY KEY,
ClientID NUMBER(2),
DogName VARCHAR2(30) NOT NULL,
DogBreed VARCHAR(30),
DogWeight NUMBER(3, 1),
CONSTRAINT fk_Client_Dog FOREIGN KEY (ClientID) REFERENCES Clients(ClientID)
);
INSERT INTO Dogs (DogID, ClientID, DogName, DogBreed, DogWeight)
VALUES (1, 1, 'Buddy', 'Labrador', 25.5);

INSERT INTO Dogs (DogID, ClientID, DogName, DogBreed, DogWeight)
VALUES (2, 2, 'Charlie', 'Beagle', 20.0);

INSERT INTO Dogs (DogID, ClientID, DogName, DogBreed, DogWeight)
VALUES (3, 3, 'Luna', 'German Shepherd', 30.5);

INSERT INTO Dogs (DogID, ClientID, DogName, DogBreed, DogWeight)
VALUES (4, 4, 'Max', 'Golden Retriever', 28.0);

INSERT INTO Dogs (DogID, ClientID, DogName, DogBreed, DogWeight)
VALUES (5, 5, 'Bella', 'Poodle', 15.2);


CREATE TABLE Reservations (
ResID NUMBER(2) PRIMARY KEY,
ClientID NUMBER(2),
KennelID NUMBER(2),
DogID NUMBER(3),
StartDate Date,
EndDate Date,
ResStatus VARCHAR2(20) DEFAULT 'Unconfirmed' CHECK (ResStatus IN ('Confirmed', 'Unconfirmed', 'Cancelled')),
TotalCost NUMBER(5, 2),
CONSTRAINT fk_Res_Client FOREIGN KEY (ClientID) REFERENCES Clients(ClientID),
CONSTRAINT fk_Res_Kennel FOREIGN KEY (KennelID) REFERENCES Kennels(KennelID),
CONSTRAINT fk_Res_Dog FOREIGN KEY (DogID) REFERENCES Dogs(DogID)
);




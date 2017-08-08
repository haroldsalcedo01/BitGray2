﻿CREATE TABLE Users
(
Id INT IDENTITY(1,1) PRIMARY KEY,
NUI VARCHAR(50) NOT NULL,
UserName VARCHAR(50) NOT NULL,
LastName VARCHAR(50) NOT NULL,
Name VARCHAR(50) NOT NULL,
Phone VARCHAR(25) NOT NULL,
Address VARCHAR(50) NOT NULL,
Email VARCHAR(60) NOT NULL,
Password VARCHAR(100) NOT NULL,
IsActive BIT NOT NULL DEFAULT 1
)
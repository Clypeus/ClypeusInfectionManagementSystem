﻿CREATE TABLE [Users].[Organisation]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	[AddressLine1] VARCHAR(25) NOT NULL,
	[AddressLine2] VARCHAR(25) NOT NULL,
	[AddressLine3] VARCHAR(25) NOT NULL,
	[AddressLine4] VARCHAR(25) NOT NULL,
	[AddressLine5] VARCHAR(25) NOT NULL,
	[TelephoneNumber] VARCHAR(25) NOT NULL,
)
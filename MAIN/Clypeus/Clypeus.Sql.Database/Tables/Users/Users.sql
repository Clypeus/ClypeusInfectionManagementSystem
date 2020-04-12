CREATE TABLE [Users].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[UserName] VARCHAR(12) NOT NULL,
	[FirstName] VARCHAR(25) NOT NULL,
	[LastName] VARCHAR(25) NOT NULL,
	[DateRegistered] DateTime NULL,
	[LastAccessed] DateTime NULL,
	[OrganisationId] int NOT NULL,
	[ContactAddressLine1] VARCHAR(25) NOT NULL,
	[ContactAddressLine2] VARCHAR(25) NOT NULL,
	[ContactAddressLine3] VARCHAR(25) NOT NULL,
	[ContactAddressLine4] VARCHAR(25) NOT NULL,
	[ContactAddressLine5] VARCHAR(25) NOT NULL,
	[TelephoneNumber] VARCHAR(25) NOT NULL,
	[MobileTelephoneNumber] VARCHAR(25) NOT NULL,
	[EmailAddress] VARCHAR(50) NOT NULL,
	[Active] bit NOT NULL, 
    CONSTRAINT [FK_Users_ToOrganisations] FOREIGN KEY ([OrganisationId]) REFERENCES [Users].[Organisation]([Id])
)

GO

CREATE INDEX [IX_Users_OrganisationsId] ON [Users].[Users] ([OrganisationId])

CREATE TABLE [medicinals].[Organisms]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Code] VARCHAR(5) NOT NULL,
	[Description] VARCHAR(50) NULL, 
    OrganismTypeId INT,
    [Active] BIT NULL, 
    [Inserted] DATETIME NULL, 
    [Updated] DATETIME NULL, 
    CONSTRAINT [FK_Organisms_ToOrganismTypes] FOREIGN KEY ([OrganismTypeId]) REFERENCES [medicinals].[OrganismTypes]([Id])
)

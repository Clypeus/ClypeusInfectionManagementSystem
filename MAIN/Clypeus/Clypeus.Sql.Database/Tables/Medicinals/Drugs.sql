CREATE TABLE [medicinals].[Drugs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Code] VARCHAR(5) NOT NULL,
	[Description] VARCHAR(50) NULL, 
    DrugTypeId INT,
    PrincipleDrugGroupId INT,
    [Active] BIT NULL, 
    [Inserted] DATETIME NULL, 
    [Updated] DATETIME NULL, 
    CONSTRAINT [FK_Drugs_ToDrugsTypes] FOREIGN KEY ([DrugTypeId]) REFERENCES [medicinals].[Drugs]([Id]),
    CONSTRAINT [FK_Drugs_ToDrugsGroup] FOREIGN KEY ([PrincipleDrugGroupId]) REFERENCES [medicinals].[Drugs]([Id])
)

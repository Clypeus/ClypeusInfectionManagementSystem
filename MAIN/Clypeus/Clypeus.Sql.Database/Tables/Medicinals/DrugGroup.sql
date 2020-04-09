CREATE TABLE [medicinals].[DrugGroup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] VARCHAR(5) NOT NULL,
    [Description] VARCHAR(50) NULL, 
    [DrugTypeId] INT NULL,
    [Active] BIT NULL, 
    [Inserted] DATETIME NULL, 
    [Updated] DATETIME NULL,
     CONSTRAINT [FK_Drugs_ToDrugsGroupTypes] FOREIGN KEY ([DrugTypeId]) REFERENCES [medicinals].[DrugTypes]([Id])
)

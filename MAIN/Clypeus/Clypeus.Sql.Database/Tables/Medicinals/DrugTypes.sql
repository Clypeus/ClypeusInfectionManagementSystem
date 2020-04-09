CREATE TABLE [medicinals].[DrugTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(50) NULL, 
    [Active] BIT NULL, 
    [Inserted] DATETIME NULL, 
    [Updated] DATETIME NULL
)

USE [Clypeus]
GO

DELETE FROM [medicinals].[DrugTypes]
DBCC CHECKIDENT ('[medicinals].[DrugTypes]', RESEED, 1)


INSERT INTO [medicinals].[DrugTypes]
           ([Description]
           ,[Active]
           ,[Inserted]
           ,[Updated])
     VALUES
           ('Antibiotic'
           ,1
           ,GETDATE()
           ,GETDATE())

INSERT INTO [medicinals].[DrugTypes]
           ([Description]
           ,[Active]
           ,[Inserted]
           ,[Updated])
     VALUES
           ('Antiviral'
           ,1
           ,GETDATE()
           ,GETDATE())
GO



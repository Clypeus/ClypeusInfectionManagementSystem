DELETE FROM [medicinals].[OrganismClass]
DBCC CHECKIDENT ('[medicinals].[OrganismClass]', RESEED, 1)

DELETE FROM [medicinals].[OrganismFamily]
DBCC CHECKIDENT ('[medicinals].[OrganismFamily]', RESEED, 1)

DELETE FROM [medicinals].[OrganismKingdom]
DBCC CHECKIDENT ('[medicinals].[OrganismKingdom]', RESEED, 1)

DELETE FROM [medicinals].[OrganismOrder]
DBCC CHECKIDENT ('[medicinals].[OrganismOrder]', RESEED, 1)

DELETE FROM [medicinals].[OrganismPhylum]
DBCC CHECKIDENT ('[medicinals].[OrganismPhylum]', RESEED, 1)

DELETE FROM [medicinals].[OrganismTypes]
DBCC CHECKIDENT ('[medicinals].[OrganismTypes]', RESEED, 1)
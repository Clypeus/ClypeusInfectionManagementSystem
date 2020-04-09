CREATE TABLE [medicinals].[DrugGroupMembers]
(
	DrugGroupId INT NOT NULL,
	DrugId INT NOT NULL,
	PRIMARY KEY (DrugGroupId,DrugId),
	CONSTRAINT [FK_Group_DrugGroup] FOREIGN KEY ([DrugGroupId]) REFERENCES [medicinals].[DrugGroup]([Id]),
	CONSTRAINT [FK_Group_Drug] FOREIGN KEY ([DrugId]) REFERENCES [medicinals].[Drugs]([Id])


)

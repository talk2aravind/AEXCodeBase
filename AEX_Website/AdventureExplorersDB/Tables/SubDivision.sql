CREATE TABLE [dbo].[SubDivision]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] nvarchar(20) NULL, 
    [DivisionId] INT NOT NULL, 
    [FundTarget] MONEY NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
     CONSTRAINT [FK_DivisionId_Master] FOREIGN KEY ([DivisionId]) REFERENCES [Division]([Id])
)

CREATE TABLE [dbo].[SubDivision]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DivisionId] INT NOT NULL, 
    [FundTarget] MONEY NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_SubDivisionId_MasterId] FOREIGN KEY ([Id]) REFERENCES [AEXMaster]([Id]), 
    CONSTRAINT [FK_DivisionId_Master] FOREIGN KEY ([DivisionId]) REFERENCES [AEXMaster]([Id])

)

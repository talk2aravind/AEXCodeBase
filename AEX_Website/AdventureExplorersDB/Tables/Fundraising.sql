CREATE TABLE [dbo].[Fundraising]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MemberId] INT NOT NULL, 
    [SubDivisionId] INT NOT NULL, 
    [AchievedTarget] MONEY NULL, 
    [ProfileDiscription] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Fundraising_members] FOREIGN KEY ([MemberId]) REFERENCES [members]([Id]), 
    CONSTRAINT [FK_Fundraising_AEXMaster] FOREIGN KEY ([SubDivisionId]) REFERENCES [AEXMaster]([Id])
)

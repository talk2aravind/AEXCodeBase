CREATE TABLE [dbo].[AEXMaster]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [CreatedDate] DATETIME NULL DEFAULT getUtcDate(), 
    [ModifiedDate] DATETIME NULL, 
    [isActive] BIT NOT NULL DEFAULT 1
    )

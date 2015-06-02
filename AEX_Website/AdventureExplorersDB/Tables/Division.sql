CREATE TABLE [dbo].[Division]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(20) NULL, 
    [CreatedDate] DATETIME NULL DEFAULT getUtcDate(), 
    [ModifiedDate] DATETIME NULL, 
    [isActive] BIT NOT NULL DEFAULT 1
    )

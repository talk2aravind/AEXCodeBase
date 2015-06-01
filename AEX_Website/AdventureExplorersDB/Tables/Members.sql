CREATE TABLE [dbo].[Members]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(30) NULL, 
    [LastName] NVARCHAR(30) NULL, 
    [CreatedDate] DATETIME NOT NULL DEFAULT getutcdate(), 
    [ModifiedDate] DATETIME NULL
)

/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Reference Data for Members
MERGE INTO dbo.Members AS Target 
USING (VALUES 
  (1, N'Jeen'	,N'Zachariah'), 
  (2, N'Mahima'	,N'John')
) 
AS Source (Id, FirstName, LastName) 
ON Target.id= Source.Id
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET FirstName = Source.FirstName
       ,LastName = Source.LastName
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT ( FirstName, LastName) 
VALUES (FirstName, LastName) 
-- delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;
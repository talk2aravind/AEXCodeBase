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

-- Reference Data for AddressType 
MERGE INTO dbo.AexMaster AS Target 
USING (VALUES 
  (1, N'BCC'), 
  (2, N'BRC'),
  (3, N'ICC'),
  (4, N'Conservation'),
  (5, N'Fundraising'),
  (6, N'BCC 2014'),
  (7, N'BCC 2015'),
  (8, N'BRC 2014'),
  (9, N'BRC 2015'),
  (10, N'ICC 2014'),
  (11, N'ICC 2015')
) 
AS Source (Id, Name) 
ON Target.id= Source.Id
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET Name = Source.Name 
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT ( Name) 
VALUES (Name) 
-- delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;

:r .\Script.Members_Populate.sql
:r .\Script.Subdivision_Populate.sql

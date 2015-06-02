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
;
MERGE INTO dbo.SubDivision AS Target 
USING (
 ( SELECT T.SubDivision, A.id as DivisionId
	FROM (
		SELECT 'BCC 2013' AS SubDivision,'BCC' AS Division UNION ALLC:\Users\Mahima\Source\Repos\AEXCodeBase\AEX_Website\AEX_Website\Models\
		SELECT 'BCC 2014','BCC'     UNION ALL
		SELECT 'BCC 2015','BCC'		UNION ALL
		SELECT 'BRC 2013','BRC'		UNION ALL
		SELECT 'BRC 2014','BRC'		UNION ALL
		SELECT 'BRC 2015','BRC'		UNION ALL
		SELECT 'ICC 2013','ICC'		UNION ALL
		SELECT 'ICC 2014','ICC'		UNION ALL
		SELECT 'ICC 2015','ICC'
	) T
	INNER JOIN dbo.Division as A 
	ON A.Name = T.Division
	)
) 
AS Source (SubDivision,DivisionId) 
ON Target.Name = Source.SubDivision and Target.DivisionId = Source.DivisionId
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Name, DivisionId) 
VALUES (SubDivision, DivisionId) 
-- delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;

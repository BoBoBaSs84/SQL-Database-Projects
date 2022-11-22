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
WITH SOURCE
AS (
	SELECT [Date]
	FROM [dbo].[GetDateRange](DATEADD(YEAR, -25, GETDATE()), DATEADD(YEAR, 25, GETDATE()))
)
MERGE INTO [dbo].[Calendar] AS TARGET
USING SOURCE
	ON SOURCE.[Date] = TARGET.[Date]
WHEN NOT MATCHED BY TARGET
	THEN
		INSERT ([Date])
		VALUES (SOURCE.[Date]);
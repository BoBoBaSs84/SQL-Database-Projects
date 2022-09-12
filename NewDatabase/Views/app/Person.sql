CREATE VIEW [app].[Person]
AS
SELECT [Person].[PersonId]
	, [Person].[FirstName]
	, [Person].[MiddleName]
	, [Person].[LastName]
	, [Person].[ValidFrom]
	, [Person].[ValidTo]
FROM [private].[Person];

CREATE FUNCTION [private].[GetApplicationVersion] (@XML XML)
RETURNS NVARCHAR(23) 
	WITH SCHEMABINDING
AS
BEGIN
	DECLARE @ApplicationVersion NVARCHAR(23) = NULL;
		
	SELECT @ApplicationVersion = @XML.value('(/Configuration/@ApplicationVersion)[1]', 'NVARCHAR(23)');

	RETURN @ApplicationVersion;
END

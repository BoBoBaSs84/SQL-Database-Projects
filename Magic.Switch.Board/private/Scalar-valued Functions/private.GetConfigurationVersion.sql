CREATE FUNCTION [private].[GetConfigurationVersion] (@XML XML)
RETURNS NVARCHAR(23)
	WITH SCHEMABINDING
AS
BEGIN
	DECLARE @ConfigurationVersion NVARCHAR(23) = NULL;

	SELECT @ConfigurationVersion = @XML.value('(/Configuration/@ConfigurationVersion)[1]', 'NVARCHAR(23)');

	RETURN @ConfigurationVersion;
END

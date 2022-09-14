CREATE FUNCTION [private].[GetConfigurationVersion] (@XML XML)
RETURNS NVARCHAR(23)
	WITH SCHEMABINDING
AS
BEGIN
	DECLARE @ConfigurationVersion NVARCHAR(23) = NULL;

	WITH XMLNAMESPACES('http://magic.switch.board.com/configuration/device' as ns)
	SELECT @ConfigurationVersion = @XML.value('(/ns:Configuration/@ConfigurationVersion)[1]', 'NVARCHAR(23)');

	RETURN @ConfigurationVersion;
END

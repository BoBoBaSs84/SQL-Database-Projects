CREATE FUNCTION [private].[GetApplicationVersion] (@XML XML)
RETURNS NVARCHAR(23) 
	WITH SCHEMABINDING
AS
BEGIN
	DECLARE @ApplicationVersion NVARCHAR(23) = NULL;

	WITH XMLNAMESPACES('http://magic.switch.board.com/configuration/device' as ns)
	SELECT @ApplicationVersion = @XML.value('(/ns:Configuration/@ApplicationVersion)[1]', 'NVARCHAR(23)');

	RETURN @ApplicationVersion;
END

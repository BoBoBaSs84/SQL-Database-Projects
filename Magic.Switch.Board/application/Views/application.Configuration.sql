CREATE VIEW [application].[Configuration]
AS
SELECT [ConfigurationId]
	, [XmlData]
  , [ApplicationVersion]
	, [ConfigurationVersion]
FROM [private].[Configuration];
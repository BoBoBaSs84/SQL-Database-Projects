CREATE TABLE [private].[Configuration] (
	[ConfigurationId] UNIQUEIDENTIFIER NOT NULL CONSTRAINT [DF_Configuration_ConfigurationId] DEFAULT NEWID()
	, [XmlData] XML NOT NULL
	, [ApplicationVersion] AS [private].[GetApplicationVersion]([XmlData])
	, [ConfigurationVersion] AS [private].[GetConfigurationVersion]([XmlData])
	, [ValidFrom] DATETIME2 GENERATED ALWAYS AS ROW START HIDDEN NOT NULL
	, [ValidTill] DATETIME2 GENERATED ALWAYS AS ROW END HIDDEN NOT NULL
	, CONSTRAINT [PK_Configuration] PRIMARY KEY NONCLUSTERED ([ConfigurationId] ASC)
	, PERIOD FOR SYSTEM_TIME ([ValidFrom], [ValidTill])
	)
	WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE = [history].[Configuration]));

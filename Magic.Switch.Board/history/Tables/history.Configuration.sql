CREATE TABLE [history].[Configuration] (
	[ConfigurationId] UNIQUEIDENTIFIER NOT NULL
	, [XmlData] XML NOT NULL
	, [ApplicationVersion] NVARCHAR(23) NULL
	, [ConfigurationVersion] NVARCHAR(23) NULL
	, [ValidFrom] DATETIME2 NOT NULL
	, [ValidTill] DATETIME2 NOT NULL
	);
GO
CREATE CLUSTERED COLUMNSTORE INDEX IX_Configuration
    ON [history].[Configuration];
GO
CREATE NONCLUSTERED INDEX IX_Configuration_ID_PERIOD_COLUMNS
    ON [history].[Configuration] ([ValidTill], [ValidFrom], [ConfigurationId]);
GO

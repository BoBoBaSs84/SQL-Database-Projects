﻿CREATE TABLE [dbo].[Calendar] (
	[Id] INT IDENTITY NOT NULL
	, CONSTRAINT [PK_Calendar] PRIMARY KEY NONCLUSTERED ([Id] ASC)
	, [Date] DATE NOT NULL
	, CONSTRAINT [UK_Calendar_Date] UNIQUE NONCLUSTERED ([Date] ASC)
	, [Year] AS DATEPART(YEAR, [Date]) PERSISTED
	, [Month] AS DATEPART(MONTH, [Date]) PERSISTED
	, [Day] AS DATEPART(DAY, [Date]) PERSISTED
	, [Week] AS DATEPART(WEEK, [Date])
	, [IsoWeek] AS DATEPART(ISO_WEEK, [Date]) PERSISTED
	, [DayOfYear] AS DATEPART(DAYOFYEAR, [Date]) PERSISTED
	, [WeekDay] AS DATEPART(WEEKDAY, [Date])
	, [EndOfMonth] AS EOMONTH([Date]) PERSISTED
	, [WeekDayName] AS DATENAME(WEEKDAY, [Date])
	, [MonthName] AS DATENAME(MONTH, [Date])
	);
GO
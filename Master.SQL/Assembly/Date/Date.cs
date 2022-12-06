using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Globalization;

public partial class Date
{
	private const string TableDefinition = $"Date DATE, Year INT, Month INT, DayOfMonth INT, WeekOfYear INT, DayOfWeek INT," +
		$"DayOfYear INT, DaysInMonth INT, DaysInYear INT, Era INT, DayName NVARCHAR(100), DayNameShort NVARCHAR(100)," +
		$"MonthName NVARCHAR(100), MonthNameShort NVARCHAR(100), EraName NVARCHAR(100), EraNameShort NVARCHAR(100)";

	private static void FillGetDateRangeRows(object objDateData, out DateTime date, out int year, out int month, out int dayOfMonth,
		out int weekOfYear, out int dayOfWeek, out int dayOfYear, out int daysInMonth, out int daysInYear, out int era, out string dayName,
		out string dayNameShort, out string monthName, out string monthNameShort, out string eraName, out string eraNameShort)
	{
		DateData dateData = objDateData as DateData;
		date = dateData.Date;
		year = dateData.CultureInfo.Calendar.GetYear(dateData.Date);
		month = dateData.CultureInfo.Calendar.GetMonth(dateData.Date);
		dayOfMonth = dateData.CultureInfo.Calendar.GetDayOfMonth(dateData.Date);
		weekOfYear = dateData.CultureInfo.Calendar.GetWeekOfYear(dateData.Date, dateData.CultureInfo.DateTimeFormat.CalendarWeekRule, dateData.CultureInfo.DateTimeFormat.FirstDayOfWeek);
		dayOfWeek = (int)dateData.CultureInfo.Calendar.GetDayOfWeek(dateData.Date);
		dayOfYear = dateData.CultureInfo.Calendar.GetDayOfYear(dateData.Date);
		daysInMonth = dateData.CultureInfo.Calendar.GetDaysInMonth(dateData.CultureInfo.Calendar.GetYear(dateData.Date), dateData.CultureInfo.Calendar.GetMonth(dateData.Date));
		daysInYear = dateData.CultureInfo.Calendar.GetDaysInYear(dateData.CultureInfo.Calendar.GetYear(dateData.Date));
		era = dateData.CultureInfo.Calendar.GetEra(dateData.Date);
		dayName = dateData.CultureInfo.DateTimeFormat.GetDayName(dateData.CultureInfo.Calendar.GetDayOfWeek(dateData.Date));
		dayNameShort = dateData.CultureInfo.DateTimeFormat.GetAbbreviatedDayName(dateData.CultureInfo.Calendar.GetDayOfWeek(dateData.Date));
		monthName = dateData.CultureInfo.DateTimeFormat.GetMonthName(dateData.CultureInfo.Calendar.GetMonth(dateData.Date));
		monthNameShort = dateData.CultureInfo.DateTimeFormat.GetAbbreviatedMonthName(dateData.CultureInfo.Calendar.GetMonth(dateData.Date));
		eraName = dateData.CultureInfo.DateTimeFormat.GetEraName(dateData.CultureInfo.Calendar.GetEra(dateData.Date));
		eraNameShort = dateData.CultureInfo.DateTimeFormat.GetAbbreviatedEraName(dateData.CultureInfo.Calendar.GetEra(dateData.Date));
	}

	private class DateData
	{
		public DateTime Date { get; private set; }
		public CultureInfo CultureInfo { get; private set; }

		public DateData(DateTime date, CultureInfo cultureInfo)
		{
			Date = date;
			CultureInfo = cultureInfo;
		}
	}

	private static ArrayList GetDateDataRange(SqlDateTime dateStart, SqlDateTime dateEnd, CultureInfo cultureInfo)
	{
		if (dateStart > dateEnd)
			throw new ArgumentOutOfRangeException($"{nameof(dateEnd)} is smaller than {nameof(dateStart)}", nameof(dateStart));

		ArrayList arrayToReturn = new();
		DateTime startDate = (DateTime)dateStart, endDate = (DateTime)dateEnd;

		while (startDate <= endDate)
		{
			_ = arrayToReturn.Add(new DateData(startDate, cultureInfo));
			startDate = startDate.AddDays(1);
		}
		return arrayToReturn;
	}
}

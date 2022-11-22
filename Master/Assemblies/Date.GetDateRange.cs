using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;

public partial class Date
{
	/// <summary>
	/// The <see cref="GetDateRange(SqlDateTime, SqlDateTime)"/> method should return a range of dates.
	/// </summary>
	/// <param name="StartDate"></param>
	/// <param name="EndDate"></param>
	/// <returns>A list of objects (of type <see cref="DateTime"/>).</returns>
	/// <exception cref="Exception">Simply rethrows the exception that occured.</exception>
	[SqlFunction(Name = nameof(GetDateRange),
		FillRowMethodName = nameof(FillGetDateRangeRows),
		DataAccess = DataAccessKind.Read,
		TableDefinition = "Date DATE")]
	public static IEnumerable GetDateRange(SqlDateTime StartDate, SqlDateTime EndDate)
	{
		try
		{
			if (StartDate > EndDate)
				throw new ArgumentException($"{nameof(EndDate)} is smaller than {nameof(StartDate)}", nameof(StartDate));

			ArrayList result = new();
			DateTime startDate = (DateTime)StartDate, endDate = (DateTime)EndDate;
			while (startDate <= endDate)
			{
				_ = result.Add(new DateData(startDate));
				startDate = startDate.AddDays(1);
			}
			return result;
		}
		catch (Exception ex)
		{
			throw new AssemblyException($"Something went wrong within method '{nameof(GetDateRange)}'.", ex);
		}
	}

	private static void FillGetDateRangeRows(object objDateData, out DateTime date)
	{
		DateData dateData = (DateData)objDateData;
		date = dateData.Date;
	}

	private class DateData
	{
		public DateTime Date { get; private set; }
		public DateData(DateTime date) => Date = date;
	}
}

using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;

public partial class Date
{
	/// <summary>
	/// The <see cref="GetDateRange(SqlDateTime, SqlDateTime)"/> method should return a range of dates.
	/// </summary>
	/// <param name="startDate"></param>
	/// <param name="endDate"></param>
	/// <returns>A list of objects (of type <see cref="DateTime"/>).</returns>
	/// <exception cref="Exception">Simply rethrows the exception that occured.</exception>
	[SqlFunction(Name = nameof(GetDateRange),
		FillRowMethodName = nameof(FillGetDateRangeRows),
		DataAccess = DataAccessKind.Read,
		TableDefinition = "Date DATE")]
	public static IEnumerable GetDateRange(SqlDateTime startDate, SqlDateTime endDate)
	{
		try
		{
			if (startDate > endDate)
				throw new ArgumentException($"{nameof(endDate)} is smaller than {nameof(startDate)}", nameof(startDate));

			ArrayList result = new();
			DateTime dateStart = (DateTime)startDate, dateEnd = (DateTime)endDate;
			while (dateStart <= dateEnd)
			{
				_ = result.Add(new DateData(dateStart));
				dateStart = dateStart.AddDays(1);
			}
			return result;
		}
		catch (Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetDateRange)}'", ex);
		}
	}

	private static void FillGetDateRangeRows(object objDateData, out DateTime date)
	{
		DateData dateData = objDateData as DateData;
		date = dateData.Date;
	}

	private class DateData
	{
		public DateTime Date { get; private set; }
		public DateData(DateTime date) => Date = date;
	}
}

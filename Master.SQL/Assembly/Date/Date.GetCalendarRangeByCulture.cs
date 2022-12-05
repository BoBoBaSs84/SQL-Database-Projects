using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Globalization;

public partial class Date
{
	/// <summary>
	/// The <see cref="GetCalendarRangeByCulture(SqlDateTime, SqlDateTime, SqlString)"/> method should return
	/// a calendar table based on te provided <paramref name="cultureName"/>.
	/// </summary>
	/// <param name="startDate">The start date of the table.</param>
	/// <param name="endDate">The end date of the table.</param>
	/// <param name="cultureName">The culture of the calendar.</param>
	/// <returns>The calendar table.</returns>
	/// <exception cref="SqlClrException">Simply rethrows the exception that occured.</exception>
	[SqlFunction(Name = nameof(GetCalendarRangeByCulture),
		FillRowMethodName = nameof(FillGetDateRangeRows),
		DataAccess = DataAccessKind.Read,
		TableDefinition = TableDefinition)]
	public static IEnumerable GetCalendarRangeByCulture(SqlDateTime startDate, SqlDateTime endDate, [SqlFacet(MaxSize = 15, IsNullable = false)] SqlString cultureName)
	{
		try
		{
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo((string)cultureName);

			return GetDateDataRange((DateTime)startDate, (DateTime)endDate, cultureInfo);
		}
		catch (Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetCalendarRangeByCulture)}'", ex);
		}
	}
}

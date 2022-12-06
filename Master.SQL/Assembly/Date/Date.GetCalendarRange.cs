using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Globalization;

public partial class Date
{
	/// <summary>
	/// The <see cref="GetDateDataRange(DateTime, DateTime)"/> method should return a calendar table.
	/// </summary>
	/// <param name="startDate">The start date of the table.</param>
	/// <param name="endDate">The end date of the table.</param>
	/// <returns>A list of objects (of type <see cref="DateTime"/>).</returns>
	/// <exception cref="SqlClrException">Simply rethrows the exception that occured.</exception>
	[SqlFunction(
		Name = nameof(GetCalendarRange),
		FillRowMethodName = nameof(FillGetDateRangeRows),
		DataAccess = DataAccessKind.Read,
		TableDefinition = TableDefinition
		)]
	public static IEnumerable GetCalendarRange(
		[SqlFacet(IsNullable = true)] SqlDateTime startDate,
		[SqlFacet(IsNullable = true)] SqlDateTime endDate
		)
	{
		try
		{
			return GetDateDataRange(startDate, endDate, CultureInfo.InvariantCulture);
		}
		catch (Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetCalendarRange)}'", ex);
		}
	}
}

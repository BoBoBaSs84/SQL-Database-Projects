using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Globalization;

public partial class Globalization
{
	/// <summary>
	/// Should return culture related information of all cultures.
	/// </summary>
	/// <returns>Culture related information.</returns>
	/// <exception cref="AssemblyException"></exception>
	[SqlFunction(Name = nameof(GetNeutralCultures), FillRowMethodName = nameof(FillGetCultureRows),
		DataAccess = DataAccessKind.Read, TableDefinition = TableDefinition)]
	public static IEnumerable GetNeutralCultures()
	{
		try
		{
			return GetCultures(CultureTypes.NeutralCultures);
		}
		catch (Exception ex)
		{
			throw new AssemblyException($"Something went wrong within method: '{nameof(GetNeutralCultures)}'", ex);
		}
	}
}

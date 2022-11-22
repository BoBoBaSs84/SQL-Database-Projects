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
	[SqlFunction(Name = nameof(GetCultures), FillRowMethodName = nameof(FillGetCultureRows),
		DataAccess = DataAccessKind.Read, TableDefinition = TableDefinition)]
	public static IEnumerable GetCultures()
	{
		try
		{
			ArrayList result = new();
			CultureInfo[] cultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures);

			foreach (CultureInfo culture in cultureInfo)
				_ = result.Add(culture);

			return result;
		}
		catch (Exception ex)
		{
			throw new AssemblyException($"Something went wrong within method: '{nameof(GetCultures)}'", ex);
		}
	}
}

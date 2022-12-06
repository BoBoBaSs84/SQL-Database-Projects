using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Globalization;

public partial class Globalization
{
	/// <summary>
	/// The <see cref="GetAllCultures"/> method should return culture related information of all cultures.
	/// </summary>
	/// <returns>Culture related information.</returns>
	/// <exception cref="SqlClrException">Simply rethrows the exception that occured.</exception>
	[SqlFunction(
		Name = nameof(GetAllCultures),
		FillRowMethodName = nameof(FillGetCultureRows),
		DataAccess = DataAccessKind.Read,
		TableDefinition = TableDefinition
		)]
	public static IEnumerable GetAllCultures()
	{
		try
		{
			return GetCultures(CultureTypes.AllCultures);
		}
		catch (Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetAllCultures)}'", ex);
		}
	}
}

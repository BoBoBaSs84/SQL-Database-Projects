using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Globalization;

public partial class Globalization
{
	/// <summary>
	/// The <see cref="GetCultureByName(SqlString)"/> method should return culture related information by land code name.
	/// </summary>
	/// <remarks>
	/// If something goes wrong, the invariant culture gets returned.
	/// </remarks>
	/// <param name="cultureName">This is the culture name. ("de-DE" or "en")</param>
	/// <returns>Culture related information.</returns>
	/// <exception cref="SqlClrException">Simply rethrows the exception that occured.</exception>
	[SqlFunction(Name = nameof(GetCultureByName), FillRowMethodName = nameof(FillGetCultureRows),
		DataAccess = DataAccessKind.Read, TableDefinition = TableDefinition)]
	public static IEnumerable GetCultureByName([SqlFacet(MaxSize = 15, IsNullable = false)] SqlString cultureName)
	{
		try
		{
			ArrayList result = new();
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo((string)cultureName);

			cultureInfo ??= CultureInfo.InvariantCulture;

			_ = result.Add(new CultureData(cultureInfo.Name));
			return result;
		}
		catch(Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetCultureByName)}'", ex);
		}
	}
}

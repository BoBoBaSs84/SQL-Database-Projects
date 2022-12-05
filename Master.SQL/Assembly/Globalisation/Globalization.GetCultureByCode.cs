using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Globalization;

public partial class Globalization
{
	/// <summary>
	/// The <see cref="GetCultureByCode(SqlInt32)"/> method should return culture related information by land code identifier.
	/// </summary>
	/// <remarks>
	/// If something goes wrong, the invariant culture gets returned.
	/// </remarks>
	/// <param name="lcid">This is the Windows Language Code Identifier.</param>
	/// <returns>Culture related information.</returns>
	/// <exception cref="SqlClrException">Simply rethrows the exception that occured.</exception>
	[SqlFunction(Name = nameof(GetCultureByCode), FillRowMethodName = nameof(FillGetCultureRows),
		DataAccess = DataAccessKind.Read, TableDefinition = TableDefinition)]
	public static IEnumerable GetCultureByCode(SqlInt32 lcid)
	{
		try
		{
			ArrayList result = new();
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo((int)lcid);

			cultureInfo ??= CultureInfo.InvariantCulture;

			_ = result.Add(new CultureData(cultureInfo.Name));
			return result;
		}
		catch (Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetCultureByCode)}'", ex);
		}
	}
}

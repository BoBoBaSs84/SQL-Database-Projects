using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Globalization;

public partial class Globalization
{
	/// <summary>
	/// Should return culture related information by land code name.
	/// </summary>
	/// <param name="cultureName">This is the culture name. ("de-DE" or "en")</param>
	/// <returns>Culture related information.</returns>
	/// <exception cref="AssemblyException"></exception>
	[SqlFunction(Name = nameof(GetCultureByName),
		FillRowMethodName = nameof(FillGetCultureRows),
		DataAccess = DataAccessKind.Read,
		TableDefinition = TableDefinition)]
	public static IEnumerable GetCultureByName([SqlFacet(MaxSize = 5)] SqlString cultureName)
	{
		try
		{
			if (cultureName == null)
				throw new ArgumentNullException(nameof(cultureName));

			ArrayList result = new();
			CultureInfo cultureInfo = CultureInfo.GetCultureInfo((string)cultureName);

			cultureInfo ??= CultureInfo.InvariantCulture;

			_ = result.Add(new CultureData(cultureInfo.Name));
			return result;
		}
		catch(Exception ex)
		{
			throw new AssemblyException($"Something went wrong within method: '{nameof(GetCultureByName)}'", ex);
		}
	}
}

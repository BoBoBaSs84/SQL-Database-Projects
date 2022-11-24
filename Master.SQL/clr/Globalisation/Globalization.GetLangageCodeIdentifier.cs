using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlTypes;
using System.Globalization;

namespace Master.SQL;

public partial class Globalization
{
	/// <summary>
	/// The <see cref="GetLangageCodeIdentifier(SqlString)"/> method should return the langauge code identifier.
	/// </summary>
	/// <param name="cultureName">The culture name. (ie. "de-DE")</param>
	/// <returns>Should return the langauge code identifier.</returns>
	/// <exception cref="SqlClrException"></exception>
	[SqlFunction(DataAccess = DataAccessKind.None, IsDeterministic = true,
		SystemDataAccess = SystemDataAccessKind.None, IsPrecise = true)]
	public static SqlInt32 GetLangageCodeIdentifier([SqlFacet(MaxSize = 15)] SqlString cultureName)
	{
		try
		{
			if (cultureName == null)
				throw new ArgumentNullException(nameof(cultureName));

			CultureInfo cultureInfo = CultureInfo.GetCultureInfo((string)cultureName);
			return cultureInfo.LCID;
		}
		catch (Exception ex)
		{
			throw new SqlClrException($"Something went wrong within method: '{nameof(GetLangageCodeIdentifier)}'", ex);
		}
	}
}

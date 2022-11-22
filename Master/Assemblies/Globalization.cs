using System.Collections;
using System.Collections.Generic;
using System.Globalization;

public partial class Globalization
{
	private const string TableDefinition = "CultureName NVARCHAR(15), NativeName NVARCHAR(100), DisplayName NVARCHAR(100), EnglishName NVARCHAR(100), ThreeLetterISO NVARCHAR(5), TwoLetterISO NVARCHAR(5), IsNeutralCulture BIT, LCID INT, ANSICodePage INT";

	private static void FillGetCultureRows(object objCultureData, out string cultureName,
		out string nativeName, out string displayName, out string englishName,
		out string threeLetterISO, out string twoLetterISO, out bool isNeutralCulture,
		out int lcid, out int ansiCodePage)
	{
		CultureData cultureData = objCultureData as CultureData;
		cultureName = cultureData.TextInfo.CultureName;
		nativeName = cultureData.NativeName;
		displayName = cultureData.DisplayName;
		englishName = cultureData.EnglishName;
		threeLetterISO = cultureData.ThreeLetterISOLanguageName;
		twoLetterISO = cultureData.TwoLetterISOLanguageName;
		isNeutralCulture = cultureData.IsNeutralCulture;
		lcid = cultureData.TextInfo.LCID;
		ansiCodePage = cultureData.TextInfo.ANSICodePage;
	}

	private class CultureData : CultureInfo
	{
		public CultureData(string name) : base(name)
		{
		}
	}

	private static IEnumerable GetCultures(CultureTypes cultureTypes)
	{
		List<CultureInfo> result = new();
		CultureInfo[] cultureInfo = CultureInfo.GetCultures(cultureTypes);

		foreach (CultureInfo culture in cultureInfo)
			result.Add(new CultureData(culture.Name));

		return result;
	}
}

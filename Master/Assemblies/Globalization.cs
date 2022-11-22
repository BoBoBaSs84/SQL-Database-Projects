using System.Globalization;

public partial class Globalization
{
	private const string TableDefinition = "Name NVARCHAR(10), NativeName NVARCHAR(100), DisplayName NVARCHAR(100), EnglishName NVARCHAR(100), ThreeLetterISO NVARCHAR(3), TwoLetterISO NVARCHAR(2), IsNeutralCulture BIT, LCID INT, ANSICodePage INT";

	private static void FillGetCultureRows(object objCultureData, out string name, out string nativeName,
		out string displayName, out string englishName, out string threeLetterISO, out string twoLetterISO,
		out bool isNeutralCulture, out int lcid, out int ansiCodePage)
	{
		CultureData cultureData = objCultureData as CultureData;
		name = cultureData.Name;
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
}

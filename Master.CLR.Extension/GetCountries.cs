using Nager.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.CLR.Extension;

public static class Country
{
	public static IEnumerable<ICountryInfo> GetCountries()
	{
		CountryProvider countryProvider = new();
		return countryProvider.GetCountries();
	}

	public static ICountryInfo GetCountryByName(string countryName)
	{
		CountryProvider countryProvider = new();
		return countryProvider.GetCountryByName(countryName);
	}
}

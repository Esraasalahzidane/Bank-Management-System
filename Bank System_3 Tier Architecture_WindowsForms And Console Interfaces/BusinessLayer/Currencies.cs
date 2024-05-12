using Shared;
using Shared.ModelViews;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class Currencies
    {
        public static DataTable get() => DataLayer.Currencies.get();
        public static CountryCurrency get(string code) => DataLayer.Currencies.get(code);
        public static bool isExsist(string countryCode) => DataLayer.Currencies.isExsist(countryCode);
        public static List<string> getCodes() => DataLayer.Currencies.getCodes();
        public static void update(CountryCurrency currencyToUpdate) => DataLayer.Currencies.update(currencyToUpdate);
        public static decimal calculater(string fromCountryCode, string toCountryCode, decimal amountToExchange) => DataLayer.Currencies.calculater(fromCountryCode, toCountryCode, amountToExchange);
    }
}
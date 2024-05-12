using ConsoleInterface.Views.Shared;
using Shared.ModelViews;
using System;
using System.Data;

namespace ConsoleInterface.Views.Currencies
{
    public class Currencies : FrontEndFunctions
    {
        void printCurrenciesListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("Country", 50, ' ') +
                padRight("Currency", 50, ' ') +
                padRight("Code", 40, ' ') +
                padRight("Rate $", 20, ' '));

            Console.WriteLine(getBreakLine('_', 150));
            Console.WriteLine();
        }
        void printCountryCurrencyRow(CountryCurrency currency)
        {
            Console.Write(padRight(currency.Country, 50, ' '));
            Console.Write(padRight(currency.Currency, 50, ' '));
            Console.Write(padRight(currency.Code, 40, ' '));
            Console.Write(padRight(currency.ExchangeRateUSD.ToString(), 20, ' '));
            Console.WriteLine();
        }
        CountryCurrency convertDataRowToCountryCurrency(DataRow dataRow)
        {
            CountryCurrency countryCurrency = new CountryCurrency();

            countryCurrency.Country = (string)dataRow["Country Name"];
            countryCurrency.Currency = (string)dataRow["Currency"];
            countryCurrency.Code = (string)dataRow["Code"];
            countryCurrency.ExchangeRateUSD = (decimal)dataRow["Rate $"];

            return countryCurrency;
        }
        void printCurreny(CountryCurrency currency, string header = "Curreny Card")
        {
            Console.WriteLine();
            Console.WriteLine(header + ":");
            Console.WriteLine(getBreakLine('_', 25));
            Console.WriteLine();
            Console.WriteLine("Country: {0}", currency.Country);
            Console.WriteLine("Code: {0}", currency.Currency);
            Console.WriteLine("Name: {0}", currency.Code);
            Console.WriteLine("Rate(1$) = {0}", currency.ExchangeRateUSD);
            Console.WriteLine(getBreakLine('_', 25));
        }
        CountryCurrency readValidCurrencyCode(int currencyNumber)
        {
            CountryCurrency currency = BusinessLayer.Currencies.get(readOneInfo("Please Enter Currency " + currencyNumber + " Code: ").ToString());

            while (currency == null)
                currency = BusinessLayer.Currencies.get(readOneInfo("Invalid Currency Code, Please Enter Currency " + currencyNumber + " Code: ").ToString());

            Console.WriteLine();
            return currency;
        }
        void printCurrencyCalculator(decimal amountToExchange, CountryCurrency currency1, CountryCurrency currency2)
        {
            Console.WriteLine();
            Console.WriteLine("{0} {1} = {2} {3}", amountToExchange, currency1.Code, BusinessLayer.Currencies.calculater(currency1.Code, currency2.Code, amountToExchange), currency2.Code);
        }
        void goCurrenciesMenue()
        {
            goBack();
            Home currenciesHome = new Home();
            currenciesHome.run();
        }



        public void show()
        {
            try
            {
                DataTable currencies = BusinessLayer.Currencies.get();
                int currenciesCount = currencies.Rows.Count;

                if (currenciesCount == 0)
                    Console.WriteLine("No Currencies Available in the System!");
                else
                {
                    Console.WriteLine();
                    drawViewHeader("Currencies List", "(" + currenciesCount + ") Currency (s)");

                    printCurrenciesListTableHeader();

                    foreach (DataRow currency in currencies.Rows)
                        printCountryCurrencyRow(convertDataRowToCountryCurrency(currency));

                    Console.WriteLine(getBreakLine('_', 150));
                }

                goCurrenciesMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void update()
        {
            try
            {
                drawViewHeader("Update Currency");
                string currencyCode = readOneInfo("Enter Currency Code: ").ToString();

                while (!BusinessLayer.Currencies.isExsist(currencyCode))
                    currencyCode = readOneInfo("currency Code (" + currencyCode + ") is not found, choose another one: ").ToString();

                CountryCurrency currencyToUpdate = BusinessLayer.Currencies.get(currencyCode);
                printCurreny(currencyToUpdate);

                currencyToUpdate.ExchangeRateUSD = decimal.Parse(readIntNumber("Enter New Rate: ").ToString());

                if (readYesOrNoChoose("Are you sure to Update Curreny (" + currencyCode + ") Y/N ?") == 'y')
                {
                    BusinessLayer.Currencies.update(currencyToUpdate);

                    Console.WriteLine();
                    Console.WriteLine("Currency ({0}) Updated Successfully", currencyToUpdate.Code);

                    printCurreny(currencyToUpdate);
                }

                goCurrenciesMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void calculator()
        {
            try
            {
                do
                {
                    drawViewHeader("Currency Calculator");

                    CountryCurrency currency1 = readValidCurrencyCode(1), currency2 = readValidCurrencyCode(2);
                    decimal amountToExchange = decimal.Parse(readIntNumber("Enter Amount to Exchange: ").ToString());

                    printCurreny(currency1, "Convert From");
                    printCurrencyCalculator(amountToExchange, currency1, currency2);

                } while (readYesOrNoChoose("Do you want to perforrm another calculation? Y/N :") == 'y');

                goCurrenciesMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

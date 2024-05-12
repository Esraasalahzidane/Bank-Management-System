using DataLayer.Settings;
using Shared.ModelViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Currencies
    {
        public static DataTable get()
        {
            DataTable dataTable = new DataTable();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select c.Name 'Country Name', t.Name 'Currency', t.Code, t.ExchangeRateUSD 'Rate $' from countries c join currencies t on c.CurrencyId = t.id order by c.Name";

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
        public static CountryCurrency get(string code)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select c.Name 'Country Name', t.Name 'Currency', t.Code, t.ExchangeRateUSD 'Rate $' from countries c join currencies t on c.CurrencyId = t.id where t.Code= @code";
                cmd.Parameters.AddWithValue("Code", code);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CountryCurrency currency = new CountryCurrency()
                    {
                        Country = (string)reader["Country Name"],
                        Code = (string)reader["Code"],
                        Currency = (string)reader["Currency"],
                        ExchangeRateUSD = (decimal)reader["Rate $"]
                    };

                    return currency;
                }

                reader.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return null;
        }
        public static bool isExsist(string countryCode) => get(countryCode) != null;
        public static List<string> getCodes()
        {
            List<string> codes = new List<string>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select code from currencies";
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    codes.Add((string)reader["code"]);

                reader.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return codes;
        }
        public static void update(CountryCurrency currencyToUpdate)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update currencies set ExchangeRateUSD = @exchangeRateUSD where Code = @code";
                cmd.Parameters.AddWithValue("exchangeRateUSD", currencyToUpdate.ExchangeRateUSD);
                cmd.Parameters.AddWithValue("code", currencyToUpdate.Code);

                con.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static decimal calculater(string fromCountryCode, string toCountryCode, decimal amountToExchange) => (amountToExchange / get(fromCountryCode).ExchangeRateUSD) * get(toCountryCode).ExchangeRateUSD;
    }
}
using DataLayer.Settings;
using Shared;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Transactions
    {
        public static void deposit(string accountNumber, int depositeAmount)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update clients set Balance = Balance + @depositeAmount where AccountNumber = @accountNumber";
                cmd.Parameters.AddWithValue("depositeAmount", depositeAmount);
                cmd.Parameters.AddWithValue("accountNumber", accountNumber);

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
        public static int totalBalances()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;
            int totalBalances = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select sum(Balance) from clients";

                con.Open();
                totalBalances = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return totalBalances;
        }
        public static DataTable transferLog()
        {
            DataTable dataTable = new DataTable();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select date 'Date', fromAccount 'From Account', toAccount 'To Account', Amount from transferlog; ";

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
        public static void addTransferBalanceLog(ClientTransfer clientTransfer)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into transferlog (Amount, FromAccount, ToAccount)Values (@Amount,@FromAccount,@ToAccount)";
                cmd.Parameters.AddWithValue("Amount", clientTransfer.Amount);
                cmd.Parameters.AddWithValue("FromAccount", clientTransfer.FromAcc);
                cmd.Parameters.AddWithValue("ToAccount", clientTransfer.ToAcc);

                con.Open();

                cmd.ExecuteScalar();
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

    }
}

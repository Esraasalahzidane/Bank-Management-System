using DataLayer.Settings;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Clients
    {
        private static int getPersonId(string accountNumber)
        {
            int personId = -1;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select P.Id from persons p join clients c on c.personId = p.Id where c.AccountNumber = @accNumber";
                cmd.Parameters.AddWithValue("accNumber", accountNumber);

                con.Open();
                personId = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return personId;
        }
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

                cmd.CommandText = "select c.AccountNumber 'Acc. Num', p.FirstName 'First Name',p.LastName 'Last Name' ,p.Email,p.Phone,c.PinCode 'Pin',c.Balance 'Balance $' from persons p join clients c on c.personId = p.Id";

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
        public static Client get(string accountNumber)
        {
            Client client = new Client("", "", "", "", "", "", 0);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select c.Id, p.FirstName,p.LastName,p.Email,p.Phone,c.AccountNumber,c.PinCode,c.Balance from persons p join clients c on c.personId = p.Id where c.accountNumber = @accountNumber";
                cmd.Parameters.AddWithValue("accountNumber", accountNumber);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    if ((string)reader["accountNumber"] == accountNumber)
                    {
                        client.Id = (int)reader["Id"];
                        client.FirstName = (string)reader["FirstName"];
                        client.LastName = (string)reader["LastName"];
                        client.Email = (string)reader["Email"];
                        client.Phone = (string)reader["Phone"];
                        client.AccountNumber = (string)reader["AccountNumber"];
                        client.PinCode = (string)reader["PinCode"];
                        client.Balance = (int)reader["Balance"];

                        break;
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

            return client;
        }
        public static List<string> getAccountNumbers()
        {
            List<string> accountNumbers = new List<string>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select accountNumber from clients";
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    accountNumbers.Add((string)reader["accountNumber"]);

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

            return accountNumbers;
        }
        public static bool isExsist(string accountNumber) => get(accountNumber).Id != 0;
        public static void post(Client client)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "insert into Persons Values (@firstName,@lastName,@email,@phone); SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("firstName", client.FirstName);
                cmd.Parameters.AddWithValue("lastName", client.LastName);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("phone", client.Phone);

                con.Open();

                object result = cmd.ExecuteScalar();
                int.TryParse(result.ToString(), out int insertedPersonID);


                cmd.CommandText = "insert into clients Values (@AccountNumber,@PinCode,@Balance,@PersonId)";
                cmd.Parameters.AddWithValue("AccountNumber", client.AccountNumber);
                cmd.Parameters.AddWithValue("PinCode", client.PinCode);
                cmd.Parameters.AddWithValue("Balance", client.Balance);
                cmd.Parameters.AddWithValue("PersonId", insertedPersonID);
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
        public static void update(Client client)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update persons set firstName = @firstName, lastName=@lastName, Email= @email, Phone= @phone where Id = @personId";
                cmd.Parameters.AddWithValue("firstName", client.FirstName);
                cmd.Parameters.AddWithValue("lastName", client.LastName);
                cmd.Parameters.AddWithValue("email", client.Email);
                cmd.Parameters.AddWithValue("phone", client.Phone);
                cmd.Parameters.AddWithValue("personId", getPersonId(client.AccountNumber));

                con.Open();

                cmd.ExecuteNonQuery();

                cmd.CommandText = "update clients set PinCode = @pinCode, Balance = @balance where AccountNumber = @accountNumber";
                cmd.Parameters.AddWithValue("pinCode", client.PinCode);
                cmd.Parameters.AddWithValue("balance", client.Balance);
                cmd.Parameters.AddWithValue("AccountNumber", client.AccountNumber);

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
        public static void delete(string accountNumber)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                int personId = getPersonId(accountNumber);

                cmd.CommandText = "delete from clients where AccountNumber = @accountNumber";
                cmd.Parameters.AddWithValue("accountNumber", accountNumber);

                con.Open();

                cmd.ExecuteNonQuery();

                cmd.CommandText = "delete from persons where Id = @personId";
                cmd.Parameters.AddWithValue("personId", personId);

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
    }
}
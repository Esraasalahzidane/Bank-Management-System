using DataLayer.Settings;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Users
    {
        public static User get(string userName)
        {
            User user = new User("", "", "", "", "", "", 0);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select  u.Id, p.FirstName,p.LastName,u.userName,p.Email,p.Phone,u.password, u.permissions from persons p join users u on u.personId = p.id where u.UserName = @userName";
                cmd.Parameters.AddWithValue("UserName", userName);

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    if ((string)reader["userName"] == userName)
                    {
                        user.Id = (int)reader["Id"];
                        user.FirstName = (string)reader["FirstName"];
                        user.LastName = (string)reader["LastName"];
                        user.Email = (string)reader["Email"];
                        user.Phone = (string)reader["Phone"];
                        user.UserName = (string)reader["UserName"];
                        user.Password = Util.decryptText((string)reader["Password"]);
                        user.Permissions = (int)reader["Permissions"];

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

            return user;
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

                cmd.CommandText = " select u.userName 'User Name', p.FirstName 'First Name', p.LastName 'Last Name', p.Email, p.Phone from persons p join users u on p.id = u.personId";

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
        private static int getPersonId(string userName)
        {
            int personId = -1;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select P.Id from persons p join users u on u.personId = p.Id where u.UserName = @userName";
                cmd.Parameters.AddWithValue("userName", userName);

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
        private static int getUserId(string userName)
        {
            int userId = -1;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select Id from users where UserName = @userName";
                cmd.Parameters.AddWithValue("userName", userName);

                con.Open();
                userId = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }

            return userId;
        }
        public static void post(User user)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "insert into Persons Values (@firstName,@lastName,@email,@phone); SELECT SCOPE_IDENTITY()";
                cmd.Parameters.AddWithValue("firstName", user.FirstName);
                cmd.Parameters.AddWithValue("lastName", user.LastName);
                cmd.Parameters.AddWithValue("email", user.Email);
                cmd.Parameters.AddWithValue("phone", user.Phone);

                con.Open();

                object result = cmd.ExecuteScalar();
                int.TryParse(result.ToString(), out int insertedPersonID);


                cmd.CommandText = "insert into users Values (@UserName,@Password,@Permissions,@PersonId)";
                cmd.Parameters.AddWithValue("UserName", user.UserName);
                cmd.Parameters.AddWithValue("Password", Util.encryptText(user.Password));
                cmd.Parameters.AddWithValue("Permissions", user.Permissions);
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
        public static bool isExsist(string userName) => String.IsNullOrEmpty(get(userName).UserName) ? false : true;
        public static List<string> getUsersNames()
        {
            List<string> usersNames = new List<string>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select UserName from users";
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    usersNames.Add((string)reader["userName"]);

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

            return usersNames;
        }
        public static void update(User user)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update persons set firstName = @firstName, lastName=@lastName, Email= @email, Phone= @phone where Id = @personId";
                cmd.Parameters.AddWithValue("firstName", user.FirstName);
                cmd.Parameters.AddWithValue("lastName", user.LastName);
                cmd.Parameters.AddWithValue("email", user.Email);
                cmd.Parameters.AddWithValue("phone", user.Phone);
                cmd.Parameters.AddWithValue("personId", getPersonId(user.UserName));

                con.Open();

                cmd.ExecuteNonQuery();

                cmd.CommandText = "update users set Password = @password, Permissions= @permissions where UserName = @userName";
                cmd.Parameters.AddWithValue("password", Util.encryptText(user.Password));
                cmd.Parameters.AddWithValue("permissions", user.Permissions);
                cmd.Parameters.AddWithValue("userName", user.UserName);

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
        public static void delete(string userName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                int personId = getPersonId(userName);

                cmd.CommandText = "delete from users where UserName = @userName";
                cmd.Parameters.AddWithValue("userName", userName);

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
        public static bool isValidUser(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName))
                return false;

            User user = get(userName);
            return user.UserName == userName && user.Password == password ? true : false;
        }
        public static void loginRegister(string userName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into usersLoginLog (UserId) Values (@userId)";
                cmd.Parameters.AddWithValue("userID", getUserId(userName));

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
        public static DataTable getLoggedInUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DataAccessSettings.ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select l.date, u.UserName, p.FirstName,p.LastName, u.Permissions from usersLoginLog l join Users u on l.userId = u.id join Persons p on u.PersonId = p.id";

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
    }
}

using ConsoleInterface.Views.Shared;
using Shared;
using System;
using System.Data;

namespace ConsoleInterface.Views.Users
{
    public class Users : FrontEndFunctions
    {
        enum enPermissions
        {
            ManageClients = 1, ManageUsers = 2, ClientsTransactions = 4, CurrencyExchange = 8
        }
        string[] permissionsOptions()
        {
            string[] permissions = new string[4];
            permissions[0] = "Manage Clients";
            permissions[1] = "Manage Users";
            permissions[2] = "Transactions";
            permissions[3] = "Currency Exchange";

            return permissions;
        }
        int getPermissionsValue()
        {
            int permissions = 0,
                mainMuenueIndex = 0;

            Console.WriteLine();
            char userChoose = readYesOrNoChoose("Do you want to give full access? Y/N: ");

            if (userChoose == 'y')
                return -1;

            Console.WriteLine();

            string[] menueOptions = permissionsOptions();

            foreach (int permission in Enum.GetValues(typeof(enPermissions)))
            {
                userChoose = readYesOrNoChoose("Do you want to give " + menueOptions[mainMuenueIndex] + " access? Y/N: ");
                Console.WriteLine();
                if (Char.ToLower(userChoose) == 'y')
                    permissions += permission;

                mainMuenueIndex++;
            }

            return permissions == 10 ? -1 : permissions;
        }
        User readUserInfo(string userName = "") => new User(readOneInfo("Enter First Name: ").ToString(),
                                                            readOneInfo("Enter Last Name: ").ToString(),
                                                            readOneInfo("Enter Email: ").ToString(),
                                                            readOneInfo("Enter Phone: ").ToString(),
                                                            userName == null ? readOneInfo("Enter User Name: ").ToString() : userName,
                                                            readOneInfo("Enter Password: ").ToString(),
                                                            getPermissionsValue());
        User convertDataRowToUser(DataRow dataRow)
        {
            User user = new User("", "", "", "", "", "", 0);

            user.UserName = (string)dataRow["User Name"];
            user.FirstName = (string)dataRow["First Name"];
            user.LastName = (string)dataRow["Last Name"];
            user.Email = (string)dataRow["Email"];
            user.Phone = (string)dataRow["Phone"];

            return user;
        }
        void printUserRow(User user)
        {
            Console.Write(padRight(user.UserName, 15, ' '));
            Console.Write(padRight(user.FirstName, 15, ' '));
            Console.Write(padRight(user.LastName, 15, ' '));
            Console.Write(padRight(user.Email, 30, ' '));
            Console.Write(padRight(user.Phone, 15, ' '));
            Console.WriteLine();
        }
        void PrintUser(User user)
        {
            Console.WriteLine();
            Console.WriteLine("User Card: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("First Name : {0}", user.FirstName);
            Console.WriteLine("Last Name : {0}", user.LastName);
            Console.WriteLine("Email : {0}", user.Email);
            Console.WriteLine("Phone : {0}", user.Phone);
            Console.WriteLine("User Name : {0}", user.UserName);
            Console.WriteLine("Password : {0}", user.Password);
            Console.WriteLine("Permissions : {0}", user.Permissions);
            Console.WriteLine("____________________________________");
        }
        void printUsersListTableHeader(bool fromUsersLoginLog = false)
        {
            Console.WriteLine();

            if (fromUsersLoginLog)
                Console.Write(padRight("Log Date", 25, ' '));

            Console.WriteLine(
                 padRight("UserName", 15, ' ') +
                 padRight("First Name", 15, ' ') +
                 padRight("Last Name", 15, ' ') +
                 padRight("Email", 30, ' ') +
                 padRight("Phone", 15, ' '));

            Console.WriteLine(getBreakLine('_', 100));
        }
        void goManageUsersMenue()
        {
            goBack();
            Home clientsHome = new Home();
            clientsHome.run();
        }

        public void show()
        {
            try
            {
                DataTable users = BusinessLayer.Users.get();
                int usersCount = users.Rows.Count;

                if (usersCount == 0)
                    Console.WriteLine("No Users found");
                else
                {
                    Console.WriteLine();
                    drawViewHeader("Users List", "(" + usersCount + ") User (s)");

                    printUsersListTableHeader();

                    foreach (DataRow user in users.Rows)
                        printUserRow(convertDataRowToUser(user));

                    Console.WriteLine(getBreakLine('_', 100));
                    Console.WriteLine();
                }

                goManageUsersMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void add()
        {
            try
            {
                drawViewHeader("Add New User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                while (BusinessLayer.Users.isExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is already used, choose another one: ").ToString();

                User user = readUserInfo(userName);
                user.UserName = userName;

                BusinessLayer.Users.post(user);

                Console.WriteLine();
                Console.WriteLine("User ({0}) Added Successfully", userName);

                PrintUser(user);
                goManageUsersMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void find()
        {
            try
            {
                drawViewHeader("Find User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                User user = BusinessLayer.Users.get(userName);

                while (!BusinessLayer.Users.isExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                PrintUser(BusinessLayer.Users.get(userName));
                goManageUsersMenue();
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
                drawViewHeader("Update User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                while (!BusinessLayer.Users.isExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                User userToUpdate = BusinessLayer.Users.get(userName);
                PrintUser(userToUpdate);


                if (readYesOrNoChoose("Are you sure to Update User " + userName + " Y/N ?") == 'y')
                {
                    User updatedUser = readUserInfo(userName);
                    BusinessLayer.Users.update(updatedUser);

                    Console.WriteLine();
                    Console.WriteLine("User ({0}) Updated Successfully", userName);
                    PrintUser(updatedUser);
                }

                goManageUsersMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void delete()
        {
            try
            {
                drawViewHeader("Delete User");
                string userName = readOneInfo("Enter User Name: ").ToString();

                while (!BusinessLayer.Users.isExsist(userName))
                    userName = readOneInfo("User Name (" + userName + ") is not found, choose another one: ").ToString();

                User UserToDelete = BusinessLayer.Users.get(userName);
                PrintUser(UserToDelete);

                if (readYesOrNoChoose("Are you sure to delete " + userName + " Y/N ?") == 'y')
                {
                    BusinessLayer.Users.delete(userName);
                    Console.WriteLine();
                    Console.WriteLine("User " + userName + " deleted Successfully");
                }

                goManageUsersMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

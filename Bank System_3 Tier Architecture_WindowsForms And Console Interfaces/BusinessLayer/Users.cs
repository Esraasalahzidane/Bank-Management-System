using Shared;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class Users
    {
        public static User getEmptyUser() => new User("", "", "", "", "", "", 0);
        public static DataTable get() => DataLayer.Users.get();
        public static void post(User user) => DataLayer.Users.post(user);
        public static User get(string userName) => DataLayer.Users.get(userName);
        public static bool isExsist(string userName) => DataLayer.Users.isExsist(userName);
        public static List<string> getUsersNames() => DataLayer.Users.getUsersNames();
        public static void update(User user) => DataLayer.Users.update(user);
        public static void delete(string userName) => DataLayer.Users.delete(userName);
        public static void loginRegister(string userName) => DataLayer.Users.loginRegister(userName);
        public static bool isValidUser(string userName, string password) => DataLayer.Users.isValidUser(userName, password);
        public static DataTable getLoggedInUsers() => DataLayer.Users.getLoggedInUsers();
    }
}

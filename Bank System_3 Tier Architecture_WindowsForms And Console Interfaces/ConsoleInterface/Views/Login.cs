using ConsoleInterface.Views.Shared;
using ConsoleInterface.Views.Users;
using Shared;
using System;

namespace ConsoleInterface.Views
{
    public class Login : FrontEndFunctions
    {
        User readUserCredentials(User user)
        {
            user.UserName = readOneInfo("User Name: ").ToString();
            user.Password = readOneInfo("Password: ").ToString();
            return user;
        }

        public void login()
        {
            bool isValidUser = false;
            int loginAttempts = 1;
            User emptyUser = BusinessLayer.Users.getEmptyUser();

            drawViewHeader("Welcome to our bank", "  Please Login");

            User userCredentials = readUserCredentials(emptyUser);

            isValidUser = BusinessLayer.Users.isValidUser(userCredentials.UserName, userCredentials.Password);

            while (loginAttempts < 3 && !isValidUser)
            {
                loginAttempts++;
                Console.WriteLine();
                Console.WriteLine("Inavlid User Name Or Password!!");
                Console.WriteLine("You have only {0} Attempt(s) Before Lock Your Account", 4 - loginAttempts);
                Console.WriteLine();
                userCredentials = readUserCredentials(emptyUser);
                isValidUser = BusinessLayer.Users.isValidUser(userCredentials.UserName, userCredentials.Password);
            }

            if (loginAttempts == 3)
            {
                Console.WriteLine();
                Console.WriteLine("You Are Locked after 3 Faild Trails!!");
                Console.WriteLine("Contact to Admins!!");
            }
            else
            {
                User user = BusinessLayer.Users.get(userCredentials.UserName);
                BusinessLayer.Users.loginRegister(user.UserName);
                LoggedUser.loggedUser = user;
                Home home = new Home();
                home.startBank();
            }
        }
    }
}

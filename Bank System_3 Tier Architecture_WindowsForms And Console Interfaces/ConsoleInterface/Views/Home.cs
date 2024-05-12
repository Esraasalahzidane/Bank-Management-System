
using ConsoleInterface.Views.Clients;
using ConsoleInterface.Views.Currencies;
using ConsoleInterface.Views.Shared;
using ConsoleInterface.Views.Transactions;
using ConsoleInterface.Views.Users;
using System;

namespace ConsoleInterface.Views
{
    public class Home : FrontEndFunctions
    {
        string[] mainMenueOptions()
        {
            string[] mainMenueOptions = new string[5];
            mainMenueOptions[0] = "Manage Clients";
            mainMenueOptions[1] = "Manage Users";
            mainMenueOptions[2] = "Clients Transactions";
            mainMenueOptions[3] = "Currency Exchange";
            mainMenueOptions[4] = "Logout";

            return mainMenueOptions;
        }
        bool checkUserAccessPrivelege(int menueNumber, int userSessionPrivelege)
        {
            if (userSessionPrivelege == -1)
                return true;

            if ((menueNumber & userSessionPrivelege) == menueNumber)
                return true;

            return false;
        }
         void accessDenied()
        {
            Console.WriteLine();
            Console.WriteLine("Access Denied! Contact Your Admin.");
            goBack();
        }
        void logOut() => LoggedUser.loggedUser = BusinessLayer.Users.getEmptyUser();
        void performMainViews(int userChoose)
        {
            int usersessionPrivelege = LoggedUser.loggedUser.Permissions;

            switch (userChoose)
            {
                case 1:
                    if (checkUserAccessPrivelege(1, usersessionPrivelege))
                    {
                        Clients.Home clientsHome = new Clients.Home();
                        clientsHome.run();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }

                case 2:
                    if (checkUserAccessPrivelege(2, usersessionPrivelege))
                    {
                        Users.Home usersHome = new Users.Home();
                        usersHome.run();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 3:
                    if (checkUserAccessPrivelege(4, usersessionPrivelege))
                    {
                        Transactions.Home transactionsHome = new Transactions.Home();
                        transactionsHome.run();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 4:
                    if (checkUserAccessPrivelege(8, usersessionPrivelege))
                    {
                        Currencies.Home currenciesHome = new Currencies.Home();
                        currenciesHome.run();
                        break;
                    }
                    else
                    {
                        accessDenied();
                        break;
                    }
                case 5:
                    Console.Clear();
                    logOut();
                    break;
            }
        }


        public void startBank()
        {
            int userChoose = 0;
            do
            {
                drawViewHeader("Main Menue");
                drawMenueOptions(mainMenueOptions());
                userChoose = readUserMenueCorrectChoose(5);

                if (userChoose == 5)
                {
                    Login login = new Login();
                    login.login();
                }
                performMainViews(userChoose);

            } while (userChoose < 5);
        }
    }
}
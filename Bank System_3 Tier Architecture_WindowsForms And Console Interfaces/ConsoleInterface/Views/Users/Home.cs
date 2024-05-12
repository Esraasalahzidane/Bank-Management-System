using ConsoleInterface.Views.Shared;

namespace ConsoleInterface.Views.Users
{
    public class Home : FrontEndFunctions
    {
        Users users = new Users();
        void performMenue(int userChoose)
        {
            switch (userChoose)
            {
                case 1:
                    users.show();
                    break;
                case 2:
                    users.add();
                    break;
                case 3:
                    users.find();
                    break;
                case 4:
                    users.update();
                    break;
                case 5:
                    users.delete();
                    break;
            }
        }
        public void run()
        {
            drawViewHeader("Manage Clients Menue");
            drawMenueOptions(clientsUsersMenueOptions("User"));
            performMenue(readUserMenueCorrectChoose(6));
        }
    }
}

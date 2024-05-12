using ConsoleInterface.Views.Shared;

namespace ConsoleInterface.Views.Clients
{
    public class Home : FrontEndFunctions
    {
        Clients clients = new Clients();
        void performMenue(int userChoose)
        {
            switch (userChoose)
            {
                case 1:
                    clients.show();
                    break;
                case 2:
                    clients.add();
                    break;
                case 3:
                    clients.find();
                    break;
                case 4:
                    clients.update();
                    break;
                case 5:
                    clients.delete();
                    break;
            }
        }

        public void run()
        {
            drawViewHeader("Manage Clients Menue");
            drawMenueOptions(clientsUsersMenueOptions());
            performMenue(readUserMenueCorrectChoose(6));
        }
    }
}

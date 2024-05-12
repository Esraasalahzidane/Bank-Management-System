using ConsoleInterface.Views.Shared;

namespace ConsoleInterface.Views.Transactions
{
    public class Home : FrontEndFunctions
    {
        Transactions transactions = new Transactions();
        void performMenue(int userChoose)
        {
            switch (userChoose)
            {
                case 1:
                    transactions.deposite();
                    break;
                case 2:
                    transactions.withDraw();
                    break;
                case 3:
                    transactions.totalBalances();
                    break;
                case 4:
                    transactions.transfer();
                    break;
                case 5:
                    transactions.transferLog();
                    break;
            }
        }
        string[] transactionsMenueOptions()
        {
            string[] mainMenueOptions = new string[6];
            mainMenueOptions[0] = "Deposite";
            mainMenueOptions[1] = "WithDraw";
            mainMenueOptions[2] = "Total Balances";
            mainMenueOptions[3] = "Transfer";
            mainMenueOptions[4] = "Transfer Log";
            mainMenueOptions[5] = "Main Menue";

            return mainMenueOptions;
        }

        public void run()
        {
            drawViewHeader("Transactions Menue");
            drawMenueOptions(transactionsMenueOptions());
            performMenue(readUserMenueCorrectChoose(6));
        }
    }
}

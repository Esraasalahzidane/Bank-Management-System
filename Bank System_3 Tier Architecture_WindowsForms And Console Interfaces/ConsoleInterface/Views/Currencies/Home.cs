using ConsoleInterface.Views.Shared;

namespace ConsoleInterface.Views.Currencies
{
    internal class Home : FrontEndFunctions
    {
        Currencies currencies = new Currencies();
        void performMenue(int userChoose)
        {
            switch (userChoose)
            {
                case 1:
                    currencies.show();
                    break;
                case 2:
                    currencies.update();
                    break;
                case 3:
                    currencies.calculator();
                    break;
            }
        }
        string[] currenciesMenueOptions()
        {
            string[] mainMenueOptions = new string[4];
            mainMenueOptions[0] = "Show Currencies";
            mainMenueOptions[1] = "Update Currency";
            mainMenueOptions[2] = "Currency Calculator";
            mainMenueOptions[3] = "Main Menue";

            return mainMenueOptions;
        }


        public void run()
        {
            drawViewHeader("Currency Menue");
            drawMenueOptions(currenciesMenueOptions());
            performMenue(readUserMenueCorrectChoose(4));
        }
    }
}

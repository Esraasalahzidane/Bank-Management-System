using Shared;
using System;
using System.Data;

namespace ConsoleInterface.Views.Shared
{
    public class FrontEndFunctions
    {
        bool isDigit(char c)
        {
            switch (c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
            }
            return false;
        }

        protected bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!isDigit(s[i]))
                    return false;
            return true;
        }
        protected string padRight(string word, int numberOfFiilingCells, char fillChar)
        {
            if (word.Length >= numberOfFiilingCells)
                return word;

            for (int i = word.Length; i < numberOfFiilingCells; i++)
                word += fillChar;

            return word;
        }
        protected string getBreakLine(char lineType, int rowLength = 50)
        {
            string breakLine = "";

            for (int i = 0; i < rowLength; i++)
                breakLine += lineType;
            return breakLine;
        }
        protected void drawViewHeader(string Title, string SubTitle = "")
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine();
            if (LoggedUser.loggedUser.FirstName != "")
                Console.WriteLine("\tWelcome: {0} {1}", LoggedUser.loggedUser.FirstName, LoggedUser.loggedUser.LastName);

            Console.WriteLine("\t" + DateTime.Now.ToString());
            Console.WriteLine();

            Console.WriteLine(getBreakLine('*'));
            Console.WriteLine("\t" + Title);
            if (SubTitle != "")
                Console.WriteLine("\t" + SubTitle);
            Console.WriteLine(getBreakLine('*'));
            Console.WriteLine();
        }
        protected void goBack()
        {
            Console.WriteLine();
            Console.Write("Press any key to go back Menue...");
            Console.ReadKey();
        }
        protected object readOneInfo(string msg)
        {
            Console.WriteLine();
            Console.Write(msg);
            return Console.ReadLine();
        }
        protected int readIntNumber(string msg)
        {
            string userChoose = readOneInfo(msg).ToString();

            while (!isNumber(userChoose) || (isNumber(userChoose) && int.Parse(userChoose) < 1))
                userChoose = readOneInfo("Invalid Number!! Please Enter the Correct one: ").ToString();
            return int.Parse(userChoose);
        }
        protected char readYesOrNoChoose(string msg)
        {
            Console.WriteLine();
            Console.Write(msg);
            string userChoose = Console.ReadLine();

            while (userChoose.ToLower() != "y" && userChoose.ToLower() != "n")
                userChoose = readOneInfo("Invalid Choose, Please Choose Y or N :").ToString();

            return char.Parse(userChoose);
        }
        protected void PrintClient(Client client)
        {
            Console.WriteLine();
            Console.WriteLine("Client Card: ");
            Console.WriteLine("____________________________________");
            Console.WriteLine("Acc. Number : {0}", client.AccountNumber);
            Console.WriteLine("Pin Code : {0}", client.PinCode);
            Console.WriteLine("First Name : {0}", client.FirstName);
            Console.WriteLine("Last Name : {0}", client.LastName);
            Console.WriteLine("Email : {0}", client.Email);
            Console.WriteLine("Phone : {0}", client.Phone);
            Console.WriteLine("Balance : {0}$", client.Balance);
            Console.WriteLine("____________________________________");
            Console.WriteLine();
        }
        protected Client convertDataRowToClient(DataRow dataRow)
        {
            Client client = new Client("", "", "", "", "", "", 0);
            client.AccountNumber = (string)dataRow["Acc. Num"];
            client.FirstName = (string)dataRow["First Name"];
            client.LastName = (string)dataRow["Last Name"];
            client.Email = (string)dataRow["Email"];
            client.Phone = (string)dataRow["Phone"];
            client.PinCode = (string)dataRow["Pin"];
            client.Balance = (int)dataRow["Balance $"];

            return client;
        }
        protected void printMenueOptions(string[] menueOptions)
        {
            for (int i = 0; i < menueOptions.Length; i++)
                Console.WriteLine("[{0}] {1}", i + 1, menueOptions[i]);
        }
        protected void drawMenueOptions(string[] menuOptions)
        {
            printMenueOptions(menuOptions);
            Console.WriteLine();
            Console.WriteLine(getBreakLine('='));
            Console.WriteLine();
        }
        protected int readUserMenueCorrectChoose(int to)
        {
            string userChoose = readOneInfo("Press number in range [1 to " + to + "] :").ToString();

            while (!isNumber(userChoose) || int.Parse(userChoose) < 1 || int.Parse(userChoose) > to)
                userChoose = readOneInfo("Invalid Choose, Press number in range [1 to " + to + "] :").ToString();

            return int.Parse(userChoose);
        }
        protected string[] clientsUsersMenueOptions(string menueFor = "CLient")
        {
            string[] mainMenueOptions = new string[6];
            mainMenueOptions[0] = "Show " + menueFor + "s";
            mainMenueOptions[1] = "Add " + menueFor;
            mainMenueOptions[2] = "Find " + menueFor;
            mainMenueOptions[3] = "Update " + menueFor;
            mainMenueOptions[4] = "Delete " + menueFor;
            mainMenueOptions[5] = "Main Menue";

            return mainMenueOptions;
        }
    }
}
using ConsoleInterface.Views.Shared;
using Shared;
using System;
using System.Data;

namespace ConsoleInterface.Views.Transactions
{
    public class Transactions : FrontEndFunctions
    {
        void printBalanceTableHeader(int fileRwosCount, int lineLength)
        {
            Console.WriteLine(getBreakLine('_', 50));
            Console.WriteLine();
            Console.WriteLine(
                padRight("Acc. Num", 20, ' ') +
                padRight("First Name", 20, ' ') +
                padRight("Balance", 20, ' '));

            Console.WriteLine(getBreakLine('_', 50));
            Console.WriteLine();
        }
        void printClienBalancetRow(Client client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.FirstName, 20, ' '));
            Console.Write(padRight(client.Balance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        string readAccountNumber(string destination)
        {
            string accountNumber = readOneInfo("Enter Account Number to Transfer " + destination + " : ").ToString();

            while (!BusinessLayer.Clients.isExsist(accountNumber))
                accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

            return accountNumber;
        }
        bool isValidClientBalanceToTransfer(int clientAmountBalance, int transferAmount) => clientAmountBalance >= transferAmount ? true : false;
        void printTransferBalancesListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("Date", 25, ' ') +
                padRight("From Account", 20, ' ') +
                padRight("To Account", 30, ' ') +
                padRight("Amount", 20, ' '));


            Console.WriteLine(getBreakLine('_', 100));
        }
        void printTransferBalanceRow(ClientTransfer clientTransfer)
        {
            Console.Write(padRight(clientTransfer.Date.ToString(), 25, ' '));
            Console.Write(padRight(clientTransfer.FromAcc, 20, ' '));
            Console.Write(padRight(clientTransfer.ToAcc, 30, ' '));
            Console.Write(padRight(clientTransfer.Amount.ToString(), 20, ' '));
            Console.WriteLine();
        }
        ClientTransfer convertDataRowToClientTransfer(DataRow dataRow)
        {
            ClientTransfer clientTransfer = new ClientTransfer(0, "", "");

            clientTransfer.Date = (DateTime)dataRow["Date"];
            clientTransfer.FromAcc = (string)dataRow["From Account"];
            clientTransfer.ToAcc = (string)dataRow["To Account"];
            clientTransfer.Amount = (int)dataRow["Amount"];

            return clientTransfer;
        }
        void goTransactionsMenue()
        {
            goBack();
            Home clientsHome = new Home();
            clientsHome.run();
        }



        public void deposite()
        {
            try
            {
                drawViewHeader("Deposite Balance");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!BusinessLayer.Clients.isExsist(accountNumber))
                    accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

                Console.WriteLine();
                int depositAmount = readIntNumber("Please Enter Deposit Amount :");

                if (readYesOrNoChoose("Are you sure to perfoem this transaction? Y/N :") == 'y')
                {
                    BusinessLayer.Transactions.deposit(accountNumber, depositAmount);

                    Console.WriteLine();
                    Console.WriteLine("Amount has been deposited ({0}) Successfully", depositAmount);

                    PrintClient(BusinessLayer.Clients.get(accountNumber));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Transaction Canceled");
                }

                goTransactionsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void withDraw()
        {
            try
            {
                drawViewHeader("Withdraw Balance");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!BusinessLayer.Clients.isExsist(accountNumber))
                    accountNumber = readOneInfo("Invalid Account Number (" + accountNumber + "), choose another one: ").ToString();

                PrintClient(BusinessLayer.Clients.get(accountNumber));
                double clientBalnce = BusinessLayer.Clients.get(accountNumber).Balance;
                if (clientBalnce <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot Transfer, Zero Balance!! ");
                    Console.WriteLine();
                    goTransactionsMenue();
                    return;
                }

                Console.WriteLine();
                int withdrawAmount = readIntNumber("Please Enter Withdraw Amount :");

                if (withdrawAmount <= clientBalnce)
                {
                    if (readYesOrNoChoose("Are you sure to perfoem this transaction? Y/N :") == 'y')
                    {
                        BusinessLayer.Transactions.withdraw(accountNumber, withdrawAmount);
                        Console.WriteLine();
                        Console.WriteLine("Amount has been withdrawn ({0}) Successfully", withdrawAmount);
                        PrintClient(BusinessLayer.Clients.get(accountNumber));
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Transaction Canceled");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot Withdraw, Insuffent Balance!");
                    Console.WriteLine("_____________________________________");
                    Console.WriteLine("Amount to Withdraw is: {0}", withdrawAmount);
                    Console.WriteLine("Your Balance is: {0}", clientBalnce);
                    Console.WriteLine();
                }
                goTransactionsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void totalBalances()
        {
            try
            {
                DataTable clients = BusinessLayer.Clients.get();
                int totalBalances = BusinessLayer.Transactions.totalBalances();

                if (clients.Rows.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Balances found!!");
                }
                else
                {
                    drawViewHeader("Total Clients Balances", "Client (s): " + clients.Rows.Count);
                    printBalanceTableHeader(clients.Rows.Count, 50);

                    foreach (DataRow client in clients.Rows)
                        printClienBalancetRow(convertDataRowToClient(client));

                    Console.WriteLine();
                    Console.WriteLine(getBreakLine('_', 50));

                    Console.WriteLine();
                    Console.WriteLine("Total Balances = " + totalBalances);
                    Console.WriteLine();
                    Console.WriteLine("(" + BusinessLayer.Transactions.getBalancesWord(totalBalances) + ")");
                    Console.WriteLine();
                }
                goTransactionsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void transfer()
        {
            try
            {
                int transferAmount = 0;
                string fromClientAccountNumber = " ", toClientAccountNumber = "";

                drawViewHeader("Transfer Balances");
                fromClientAccountNumber = readAccountNumber("From");

                Client fromClient = BusinessLayer.Clients.get(fromClientAccountNumber);

                if (fromClient.Balance <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot Transfer, Zero Balance!! ");
                    Console.WriteLine();
                    goTransactionsMenue();
                    return;
                }

                PrintClient(fromClient);

                toClientAccountNumber = readAccountNumber("To");
                Client toClient = BusinessLayer.Clients.get(toClientAccountNumber);

                while (fromClient.AccountNumber == toClient.AccountNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot Transfer Balance Amount to the Same Account!!");
                    Console.WriteLine();
                    toClientAccountNumber = readAccountNumber("To");
                    toClient = BusinessLayer.Clients.get(toClientAccountNumber);
                }

                PrintClient(toClient);

                transferAmount = readIntNumber("Enter Transfer Amount: ");

                while (!isValidClientBalanceToTransfer(fromClient.Balance, transferAmount))
                    transferAmount = int.Parse(readOneInfo("Amount Exceeds the Available Balance, Enter another Amount: ").ToString());

                if (readYesOrNoChoose("Are You Sure you want to perform this operation? Y/N :") == 'y')
                {
                    BusinessLayer.Transactions.transfer(transferAmount, fromClient.AccountNumber, toClient.AccountNumber);

                    fromClient = BusinessLayer.Clients.get(fromClientAccountNumber);
                    toClient = BusinessLayer.Clients.get(toClientAccountNumber);

                    ClientTransfer clientsTransferLog = new ClientTransfer(
                              transferAmount,
                               fromClient.AccountNumber,
                               toClient.AccountNumber);
                    BusinessLayer.Transactions.addTransferBalanceLog(clientsTransferLog);

                    Console.WriteLine();
                    Console.WriteLine("Transfer Done Successfully");

                    Console.WriteLine();
                    PrintClient(fromClient);
                    PrintClient(toClient);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Transfer Cancelled");
                }

                goTransactionsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void transferLog()
        {

            try
            {

                DataTable transferBalancesLog = BusinessLayer.Transactions.transferLog();
                int transferBalancesCount = transferBalancesLog.Rows.Count;

                if (transferBalancesCount == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Transfer Balances found!!");
                }
                else
                {
                    Console.WriteLine();
                    drawViewHeader("Transfer Log", "Count( " + transferBalancesCount + " )");
                    printTransferBalancesListTableHeader();

                    foreach (DataRow transferBalance in transferBalancesLog.Rows)
                        printTransferBalanceRow(convertDataRowToClientTransfer(transferBalance));

                    Console.WriteLine(getBreakLine('_', 100));
                }
                goTransactionsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
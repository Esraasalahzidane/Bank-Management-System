using DataLayer.Settings;
using Shared;
using System.Data;

namespace BusinessLayer
{
    public class Transactions
    {
        public static void deposit(string accountNumber, int depositeAmount) => DataLayer.Transactions.deposit(accountNumber, depositeAmount);
        public static void withdraw(string accountNumber, int depositeAmount) => deposit(accountNumber, -depositeAmount);
        public static int totalBalances() => DataLayer.Transactions.totalBalances();
        public static void transfer(int transferAmount, string fromAccountNumber, string toAccountNumber)
        {
            withdraw(fromAccountNumber, transferAmount);
            deposit(toAccountNumber, transferAmount);
        }
        public static DataTable transferLog() => DataLayer.Transactions.transferLog();
        public static string getBalancesWord(int balances) => Util.NumberToText(balances);
        public static void addTransferBalanceLog(ClientTransfer clientTransfer) => DataLayer.Transactions.addTransferBalanceLog(clientTransfer);
    }
}
using ConsoleInterface.Views.Shared;
using Shared;
using System;
using System.Data;

namespace ConsoleInterface.Views.Clients
{
    public class Clients : FrontEndFunctions
    {
        void printClientsListTableHeader()
        {
            Console.WriteLine();
            Console.WriteLine(
                padRight("Acc. Num", 20, ' ') +
                padRight("First Name", 20, ' ') +
                padRight("Last Name", 20, ' ') +
                padRight("Email", 30, ' ') +
                padRight("Phone", 25, ' ') +
                padRight("Pin Code", 20, ' ') +
                padRight("Balance $", 20, ' '));

            Console.WriteLine(getBreakLine('_', 150));
            Console.WriteLine();
        }
        void printClientRow(Client client)
        {
            Console.Write(padRight(client.AccountNumber, 20, ' '));
            Console.Write(padRight(client.FirstName, 20, ' '));
            Console.Write(padRight(client.LastName, 20, ' '));
            Console.Write(padRight(client.Email, 30, ' '));
            Console.Write(padRight(client.Phone, 25, ' '));
            Console.Write(padRight(client.PinCode, 20, ' '));
            Console.Write(padRight(client.Balance.ToString(), 20, ' '));
            Console.WriteLine();
        }
        Client readClientInfo(string accountNumber = "") => new Client(accountNumber == null ? readOneInfo("Enter Account Number: ").ToString() : accountNumber,
                                                                      readOneInfo("Enter Pin Code: ").ToString(),
                                                                      readOneInfo("Enter First Name: ").ToString(),
                                                                      readOneInfo("Enter Last Name: ").ToString(),
                                                                      readOneInfo("Enter Email: ").ToString(),
                                                                      readOneInfo("Enter Phone: ").ToString(),
                                                                      readIntNumber("Enter Account Balance: "));
        void goManageClientsMenue()
        {
            goBack();
            Home clientsHome = new Home();
            clientsHome.run();
        }


        public void show()
        {
            try
            {
                DataTable clients = BusinessLayer.Clients.get();
                int clientsConunt = clients.Rows.Count;

                if (clientsConunt == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("No Clients Found!!");
                }

                else
                {
                    drawViewHeader("Clients List", clientsConunt + " Client (s)");
                    printClientsListTableHeader();

                    foreach (DataRow client in clients.Rows)
                        printClientRow(convertDataRowToClient(client));

                    Console.WriteLine(getBreakLine('_', 150));
                    Console.WriteLine();
                }

                goManageClientsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void add()
        {
            try
            {
                drawViewHeader("Add New Client");

                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (BusinessLayer.Clients.isExsist(accountNumber))
                {
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is already used, choose another one: ").ToString();
                    Console.WriteLine();
                }

                Client client = readClientInfo(accountNumber);
                client.AccountNumber = accountNumber;
                BusinessLayer.Clients.post(client);
                Console.WriteLine();
                Console.WriteLine("Client ({0}) Added Successfully", accountNumber);
                PrintClient(client);
                goManageClientsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void find()
        {
            try
            {
                drawViewHeader("Find Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                Client client = BusinessLayer.Clients.get(accountNumber);

                while (!BusinessLayer.Clients.isExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                PrintClient(BusinessLayer.Clients.get(accountNumber));
                goManageClientsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void update()
        {
            try
            {
                drawViewHeader("Update Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!BusinessLayer.Clients.isExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, choose another one: ").ToString();

                Client clientToUpdate = BusinessLayer.Clients.get(accountNumber);
                PrintClient(clientToUpdate);

                if (readYesOrNoChoose("Are you sure to Update Acc. (" + accountNumber + ") Y /N ?") == 'y')
                {
                    Console.WriteLine();
                    Client updatedClient = readClientInfo(accountNumber);
                    BusinessLayer.Clients.update(updatedClient);

                    Console.WriteLine();
                    Console.WriteLine("Client ({0}) Updated Successfully", accountNumber);
                    PrintClient(updatedClient);
                }

                goManageClientsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void delete()
        {
            try
            {
                drawViewHeader("Delete Client");
                string accountNumber = readOneInfo("Enter Account Number: ").ToString();

                while (!BusinessLayer.Clients.isExsist(accountNumber))
                    accountNumber = readOneInfo("Account Number (" + accountNumber + ") is not found, Choose another one: ").ToString();

                global::Shared.Client clientToDelete = BusinessLayer.Clients.get(accountNumber);
                PrintClient(clientToDelete);

                if (readYesOrNoChoose("Are you sure to delete Acc. " + accountNumber + " Y /N ?") == 'y')
                {
                    BusinessLayer.Clients.delete(accountNumber);
                    Console.WriteLine();
                    Console.WriteLine("Client " + accountNumber + " deleted Successfully");
                }

                goManageClientsMenue();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
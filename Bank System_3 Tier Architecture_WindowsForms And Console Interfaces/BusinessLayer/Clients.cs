using Shared;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class Clients
    {
        public static DataTable get() => DataLayer.Clients.get();
        public static void post(Client client) => DataLayer.Clients.post(client);
        public static List<string> accountNumbers() => DataLayer.Clients.getAccountNumbers();
        public static bool isExsist(string accountNumber) => DataLayer.Clients.isExsist(accountNumber);
        public static Client get(string accountNumber) => DataLayer.Clients.get(accountNumber);
        public static void update(Client client) => DataLayer.Clients.update(client);
        public static void delete(string accountNumber) => DataLayer.Clients.delete(accountNumber);  
    }
}

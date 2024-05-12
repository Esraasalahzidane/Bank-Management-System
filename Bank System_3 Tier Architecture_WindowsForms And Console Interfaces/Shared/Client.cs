namespace Shared
{
    public class Client : Person
    {
        public new int Id { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public int Balance { get; set; }
        public int PersonId { get; set; }

        public Client(string accountNumber, string pinCode,
                      string firstName, string lastName, string email, string phone, int balance)
            : base(firstName, lastName, email, phone)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            Balance = balance;
        }
    }
}

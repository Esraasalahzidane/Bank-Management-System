namespace Shared.ModelsView
{
    public class PersonClient
    {
        public int ClientId { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }

        public PersonClient(string accountNumber, string pinCode, string firstName, string lastName, string email, string phone, int balance)
        {
            AccountNumber = accountNumber;
            PinCode = pinCode;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Balance = balance;
        }
        public PersonClient()
        {

        }
    }
}

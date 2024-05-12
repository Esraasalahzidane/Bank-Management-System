
namespace Shared
{
    public class User : Person
    {
        public new int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public int PsersonId { get; set; }

        public User(string firstName, string lastName, string email, string phone, string userName, string password, int permissions)
                   : base(firstName, lastName, email, phone)
        {
            UserName = userName;
            Password = password;
            Permissions = permissions;
        }
    }
}
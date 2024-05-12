using Shared;

namespace Bank.Shared
{
    public static class LoggedUser
    {
        public static User loggedUser = new User("","","","","","",0);
        public static int loginFailedAttempts = 0;
    }
}

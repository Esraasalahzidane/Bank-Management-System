using Shared;

namespace ConsoleInterface.Views.Shared
{
    public class LoggedUser
    {
        public static User loggedUser = new User("", "", "", "", "", "", 0);
        public static int loginFailedAttempts = 0;
    }
}

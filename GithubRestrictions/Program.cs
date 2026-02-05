using UserData;
using static System.Console;
using static ProcessUserData.UserMethods;

namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            int userCount = DetermineUserCount();

            AddUsers(userCount);

            ProcessUserInformation();

            WriteLine("Do you want to see all users again??? type YES or NO");
            SeeAllUsersAgain(ReadLine());

            WriteLine("press enter to exit");
            ReadLine();
        }
    }
}

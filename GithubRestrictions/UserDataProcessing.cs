using UserData;
using static System.Console;

namespace ProcessUserData
{
    public class UserDataProcessing
    {
        public static List<User> Users { get; set; } = new List<User>();
        const int DEFAULT_USER_COUNT = 2;

        internal static void WelcomeMessage()
        {
            WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            WriteLine("Please enter how many users you want to add?");
        }

        internal static int DetermineUserCount(string input)
        {
            int userCount;
            try
            {
                userCount = Convert.ToInt32(input);
            }
            catch
            {
                WriteLine("invalid input, defaulting to 2");
                userCount = DEFAULT_USER_COUNT;
            }

            return userCount;
        }
        internal static void AddUsers(int userCount)
        {
            for (int i = 0; i < userCount; i++)
            {
                WriteLine("Enter name:");
                string name = ReadLine();

                WriteLine("Enter age:");
                int age = Convert.ToInt32(ReadLine());

                WriteLine("Enter email:");
                string email = ReadLine();

                Users.Add(new User(name, age, email));
            }
        }
        internal static void ProcessUserInformation()
        {
            for (int q = 0; q < Users.Count; q++)
            {
                WriteLine($"USER {q + 1}:");
                WriteLine($"NAME={Users[q].Name}, age is {Users[q].Age}, EMAIL: {Users[q].Email}");
                Users[q].EvaluateAge();
                Users[q].ValidateEmail();
            }
            for (int q = 0; q < Users.Count; q++)
            {
                Users[q].EvaluateNameLength();
            }
        }
        internal static void SeeAllUsersAgain(string? ans)
        {
            if (ans == "YES")
            {
                for (int i = 0; i < Users.Count; i++)
                {
                    WriteLine($"User again: {Users[i].Name} / {Users[i].Age} / {Users[i].Email}");
                }
            }
            else if (ans == "NO")
            {
                WriteLine("ok bye lol");
            }
            else
            {
                WriteLine("idk what you mean but bye");
            }
        }
    }
}
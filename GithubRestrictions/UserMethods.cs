using UserData;
using static System.Console;

namespace ProcessUserData
{
    public class UserMethods
    {
        public static List<User> Users { get; set; } = new List<User>();
        const int DEFAULT_USER_COUNT = 2;
        const int ADULT_AGE = 18;
        const int OLD_AGE = 60;
        const int LONG_NAME_LENGTH = 10;
        const int SHORT_NAME_LENGTH = 3;

        internal static void WelcomeMessage()
        {
            WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            WriteLine("Please enter how many users you want to add?");
        }

        internal static int DetermineUserCount()
        {
            int userCount;
            try
            {
                userCount = Convert.ToInt32(ReadLine());
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
                WriteLine($"USER {(q + 1)}:");
                WriteLine($"NAME={Users[q].Name}, age is {Users[q].Age}, EMAIL: {Users[q].Email}");
                ProcessAge(q);
                ProcessEmail(q);
            }
            ProcessNames();
        }

        private static void ProcessNames()
        {
            for (int q = 0; q < Users.Count; q++)
            {
                if (Users[q].Name.Length > LONG_NAME_LENGTH)
                {
                    WriteLine($"{Users[q].Name} has a long name");
                }
                else if (Users[q].Name.Length < SHORT_NAME_LENGTH)
                {
                    WriteLine($"shorty name alert: {Users[q].Name}");
                }
                else
                {
                    WriteLine("Name length is good enough I guess");
                }
            }
        }

        private static void ProcessEmail(int q)
        {
            if (!Users[q].Email.Contains("@"))
            {
                WriteLine("Not a valid email but who cares");
            }
        }

        private static void ProcessAge(int q)
        {
            if (Users[q].Age < ADULT_AGE)
            {
                WriteLine("This person is underaged!!!");
            }
            else if (Users[q].Age > OLD_AGE)
            {
                WriteLine("This person is OLD!!!");
            }
            else
            {
                WriteLine("This person is fine I guess");
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
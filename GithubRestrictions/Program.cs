namespace BadCode
{
    class Program
    {
        
        const int LowerAgeLimit = 18;
        const int UpperAgeLimit = 60;
        const int UsernameUpperLengthLimit = 10;
        const int UsernameLowerLengthLimit = 3;
        private const int InvalidAmountOfUsersInput = 2;

        static void Main(string[] args)
        {
            RunProgram();
        }

        private static void RunProgram()
        {
            int parsedNumberOfUsers = GetNumberOfUsers();

            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            GetUserInformation(parsedNumberOfUsers, usernames, ages, emails);

            DisplayUserInformation(usernames, ages, emails);

            DisplayUsernameLength(usernames);

            AskToDisplayUsersAgain(usernames, ages, emails);

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        private static void AskToDisplayUsersAgain(List<string> usernames, List<int> ages, List<string> emails)
        {
            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var userResponse = Console.ReadLine();
            if (userResponse == "YES")
            {
                DisplayUsersAgain(usernames, ages, emails);
            }
            else if (userResponse == "NO")
            {
                Console.WriteLine("ok bye lol");
            }
            else
            {
                Console.WriteLine("idk what you mean but bye");
            }
        }

        private static void DisplayUsersAgain(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int index = 0; index < usernames.Count; index++)
            {
                Console.WriteLine("User again: " + usernames[index] + " / " + ages[index] + " / " + emails[index]);
            }
        }

        private static void DisplayUsernameLength(List<string> usernames)
        {
            for (int index = 0; index < usernames.Count; index++)
            {
                string username = usernames[index];
                if (username.Length > UsernameUpperLengthLimit)
                {
                    Console.WriteLine(username + " has a long name");
                }
                else if (username.Length < UsernameLowerLengthLimit)
                {
                    Console.WriteLine("shorty name alert: " + username);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }
        }

        private static void DisplayUserInformation(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int index = 0; index < usernames.Count; index++)
            {
                Console.WriteLine("USER " + (index + 1) + ":");
                Console.WriteLine("NAME=" + usernames[index] + ", age is " + ages[index] + ", EMAIL: " + emails[index]);
                if (ages[index] < LowerAgeLimit)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[index] > UpperAgeLimit)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }

                if (emails[index].Contains("@") == false)
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }
        }

        private static void GetUserInformation(int parsedNumberOfUsers, List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int i = 0; i < parsedNumberOfUsers; i++)
            {
                Console.WriteLine("Enter name:");
                usernames.Add(Console.ReadLine());

                Console.WriteLine("Enter age:");
                ages.Add(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("Enter email:");
                emails.Add(Console.ReadLine());
            }
        }

        private static int GetNumberOfUsers()
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string numberOfUsers = Console.ReadLine();
            int parsedNumberOfUsers = 0;
            try
            {
                parsedNumberOfUsers = Convert.ToInt32(numberOfUsers);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                parsedNumberOfUsers = InvalidAmountOfUsersInput;
            }

            return parsedNumberOfUsers;
        }
    }
}

namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");

            int numberOfUsers = GetNumberOfUsers();

            for (int i = 0; i < numberOfUsers; i++)
            {
                string name = GetUserName();
                usernames.Add(name);

                int age = GetUserAge();
                ages.Add(age);

                string email = GetUserEmail();
                emails.Add(email);
            }

            for (int i = 0; i < usernames.Count; i++)
            {
                Console.WriteLine("USER " + (i + 1) + ":");
                Console.WriteLine("NAME=" + usernames[i] + ", age is " + ages[i] + ", EMAIL: " + emails[i]);
                if (ages[i] < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[i] > 60)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }
                if (emails[i].Contains("@") == false)
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }

            for (int index = 0; index < usernames.Count; index++)
            {
                if (usernames[index].Length > 10)
                {
                    Console.WriteLine(usernames[index] + " has a long name");
                }
                else if (usernames[index].Length < 3)
                {
                    Console.WriteLine("shorty name alert: " + usernames[index]);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }

            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var answer = Console.ReadLine().Trim().ToUpper();
            if (answer == "YES")
            {
                for (int i = 0; i < usernames.Count; i++)
                {
                    Console.WriteLine("User again: " + usernames[i] + " / " + ages[i] + " / " + emails[i]);
                }
            }
            else if (answer == "NO")
            {
                Console.WriteLine("ok bye lol");
            }
            else
            {
                Console.WriteLine("idk what you mean but bye");
            }

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        static int GetNumberOfUsers()
        {
            string numberOfUsersInput = Console.ReadLine();

            int numberOfUsers;
            try
            {
                numberOfUsers = Convert.ToInt32(numberOfUsersInput);
            }
            catch
            {
                Console.WriteLine("Invalid input, defaulting to 2");
                numberOfUsers = 2;
            }

            return numberOfUsers;
        }

        static string GetUserName()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                System.Console.WriteLine("Invalid name, please enter a valid name: ");
                name = GetUserName();
            }
            return name;
        }

        static int GetUserAge()
        {
            Console.WriteLine("Enter age:");
            string age = Console.ReadLine();

            if (!Int32.TryParse(age, out int parsedAge))
            {
                System.Console.WriteLine("Invalid age, please enter a valid age:");
                return GetUserAge();
            }

            return parsedAge;
        }

        static string GetUserEmail()
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(email))
            {
                System.Console.WriteLine("Invalid email, please enter a valid email:");
                return GetUserEmail();
            }
            return email;
        }
    }
}

namespace BadCode
{
    class Program
    {
        private const int Underage = 18;
        private const int Old = 60;

        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string n = Console.ReadLine();
            int numberOfUsers;
            try
            {
                numberOfUsers = Convert.ToInt32(n);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                numberOfUsers = 2;
            }


            for (int i = 0; i < numberOfUsers; i++)
            {
                Console.WriteLine("Enter name:");
                string nm = Console.ReadLine();
                usernames.Add(nm);

                Console.WriteLine("Enter age:");
                string ag = Console.ReadLine();
                ages.Add(Int32.Parse(ag));

                Console.WriteLine("Enter email:");
                string e = Console.ReadLine();
                emails.Add(e);
            }

            for (int q = 0; q < usernames.Count; q++)
            {
                Console.WriteLine("USER " + (q + 1) + ":");
                Console.WriteLine("NAME=" + usernames[q] + ", age is " + ages[q] + ", EMAIL: " + emails[q]);
                CheckAge(ages, q);
                CheckEmail(emails, q);
                CheckUsernameLength(usernames, q);
            }

            RewriteEverything(usernames, ages, emails);

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        private static void RewriteEverything(List<string> usernames, List<int> ages, List<string> emails)
        {
            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var ans = Console.ReadLine();
            if (ans == "YES")
            {
                for (int i = 0; i < usernames.Count; i++)
                {
                    Console.WriteLine("User again: " + usernames[i] + " / " + ages[i] + " / " + emails[i]);
                }
            }
            else if (ans == "NO")
            {
                Console.WriteLine("ok bye lol");
            }
            else
            {
                Console.WriteLine("idk what you mean but bye");
            }
        }

        private static void CheckEmail(List<string> emails, int q)
        {
            if (emails[q].Contains("@") == false)
            {
                Console.WriteLine("Not a valid email but who cares");
            }
        }

        private static void CheckAge(List<int> ages, int q)
        {
            if (ages[q] < Underage)
            {
                Console.WriteLine("This person is underaged!!!");
            }
            else if (ages[q] > Old)
            {
                Console.WriteLine("This person is OLD!!!");
            }
            else
            {
                Console.WriteLine("This person is fine I guess");
            }
        }

        private static void CheckUsernameLength(List<string> usernames, int q)
        {
            if (usernames[q].Length > 10)
            {
                Console.WriteLine(usernames[q] + " has a long name");
            }
            else if (usernames[q].Length < 3)
            {
                Console.WriteLine("shorty name alert: " + usernames[q]);
            }
            else
            {
                Console.WriteLine("Name length is good enough I guess");
            }
        }
    }
}

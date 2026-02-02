namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            int x = PromptNumOfUsers();

            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            for (int i = 0; i < x; i++)
            {
                usernames.Add(PromptName());
                ages.Add(PromptAge());
                emails.Add(PromptEmail());
            }

            for (int q = 0; q < usernames.Count; q++)
            {
                displayUser(usernames[q], ages[q], emails[q], q);
            }

            for (int q = 0; q < usernames.Count; q++)
            {
                displayNameJudgment(usernames[q]);
            }

            string? ans = promptRepeatDisplay();
            if (ans == "YES")
            {
                displayUserAgain(usernames, ages, emails);
            }
            else if (ans == "NO")
            {
                Console.WriteLine("ok bye lol");
            }
            else
            {
                Console.WriteLine("idk what you mean but bye");
            }

            waitForExit();
        }

        private static void waitForExit()
        {
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        private static void displayUserAgain(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int i = 0; i < usernames.Count; i++)
            {
                Console.WriteLine("User again: " + usernames[i] + " / " + ages[i] + " / " + emails[i]);
            }
        }

        private static string? promptRepeatDisplay()
        {
            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var ans = Console.ReadLine();
            return ans;
        }

        private static void displayNameJudgment(string username)
        {
            if (username.Length > 10)
            {
                Console.WriteLine(username + " has a long name");
            }
            else if (username.Length < 3)
            {
                Console.WriteLine("shorty name alert: " + username);
            }
            else
            {
                Console.WriteLine("Name length is good enough I guess");
            }
        }

        private static void displayUser(string username, int age, string email, int q)
        {
            Console.WriteLine("USER " + (q + 1) + ":");
            Console.WriteLine("NAME=" + username + ", age is " + age + ", EMAIL: " + email);
            if (age < 18)
            {
                Console.WriteLine("This person is underaged!!!");
            }
            else if (age > 60)
            {
                Console.WriteLine("This person is OLD!!!");
            }
            else
            {
                Console.WriteLine("This person is fine I guess");
            }
            if (email.Contains("@") == false)
            {
                Console.WriteLine("Not a valid email but who cares");
            }
        }

        private static string PromptEmail()
        {
            Console.WriteLine("Enter email:");
            string e = Console.ReadLine();
            return e;
        }

        private static int PromptAge()
        {
            Console.WriteLine("Enter age:");
            string ag = Console.ReadLine();
            return int.Parse(ag);
        }

        private static string PromptName()
        {
            Console.WriteLine("Enter name:");
            string nm = Console.ReadLine();
            return nm;
        }

        private static int PromptNumOfUsers()
        {
            Console.WriteLine("Please enter how many users you want to add?");
            string n = Console.ReadLine();
            int x = 0;
            try
            {
                x = Convert.ToInt32(n);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                x = 2;
            }

            return x;
        }
    }
}

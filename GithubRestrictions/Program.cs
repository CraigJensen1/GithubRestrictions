using System;

namespace BadCode
{
    class pRoGrAm
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();
            int numUsers = 0;

            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");

            numUsers = UserInput();
            GetInfo(usernames, ages, emails, numUsers);
            AgeEvauation(usernames, ages, emails);
            NameEvauation(usernames);
            SeeInfo(usernames, ages, emails);

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        private static void SeeInfo(List<string> usernames, List<int> ages, List<string> emails)
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

        private static void NameEvauation(List<string> usernames)
        {
            foreach (string name in usernames)
            {
                if (name.Length > 10)
                {
                    Console.WriteLine(name + " has a long name");
                }
                else if (name.Length < 3)
                {
                    Console.WriteLine("shorty name alert: " + name);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }
        }

        private static void GetInfo(List<string> usernames, List<int> ages, List<string> emails, int numUsers)
        {
            for (int i = 0; i < numUsers; i++)
            {
                Console.WriteLine("Enter name:");
                usernames.Add(Console.ReadLine());

                Console.WriteLine("Enter age:");
                ages.Add(Int32.Parse(Console.ReadLine()));

                Console.WriteLine("Enter email:");
                emails.Add(Console.ReadLine());
            }
        }

        private static void AgeEvauation(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int j = 0; j < usernames.Count; j++)
            {
                Console.WriteLine("USER " + (j + 1) + ":");
                Console.WriteLine("NAME=" + usernames[j] + ", age is " + ages[j] + ", EMAIL: " + emails[j]);
                if (ages[j] < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[j] > 60)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }
                if (emails[j].Contains("@") == false)
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }
        }

        public static int UserInput()
        {
            int numUsers = 0;
            Console.WriteLine("Please enter how many users you want to add?");
            try
            {
                numUsers = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                numUsers = 2;
            }
            return numUsers;
        }
    }
}
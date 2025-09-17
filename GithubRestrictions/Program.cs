using System;
using System.Collections.Generic;

namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string n = Console.ReadLine();
            int userNameQuantity = 0;
            try
            {
                userNameQuantity = Convert.ToInt32(n);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                userNameQuantity = 2;
            }

            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            Users.CreateAUser(userNameQuantity, usernames, ages, emails);

            Users.UserAge(usernames, ages, emails);

            Users.CheckUsernameLength(usernames);

            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var ans = Console.ReadLine();

            Users.DisplayAllUsers(usernames, ages, emails, ans);

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

      
        }
    }


    public class Users
    {
        public const int MINOR_AGE = 18;
        public const int ELDER_AGE = 60;
        public const int LONG_USERNAME = 10;
        public const int SHORT_USERNAME = 3;




        internal static void UserAge(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int q = 0; q < usernames.Count; q++)
            {
                Console.WriteLine("USER " + (q + 1) + ":");
                Console.WriteLine("NAME=" + usernames[q] + ", age is " + ages[q] + ", EMAIL: " + emails[q]);
                if (ages[q] < MINOR_AGE)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[q] > ELDER_AGE)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }
                if (emails[q].Contains("@") == false)
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }
        }

        internal static void CreateAUser(int userNameQuantity, List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int i = 0; i < userNameQuantity; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                usernames.Add(name);

                Console.WriteLine("Enter age:");
                string age = Console.ReadLine();
                ages.Add(Int32.Parse(age));

                Console.WriteLine("Enter email:");
                string emailAddress = Console.ReadLine();
                emails.Add(emailAddress);
            }
        }


        internal static void CheckUsernameLength(List<string> usernames)
        {
            for (int q = 0; q < usernames.Count; q++)
            {
                if (usernames[q].Length > LONG_USERNAME)
                {
                    Console.WriteLine(usernames[q] + " has a long name");
                }
                else if (usernames[q].Length < SHORT_USERNAME)
                {
                    Console.WriteLine("shorty name alert: " + usernames[q]);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }
        }
    internal static void DisplayAllUsers(List<string> usernames, List<int> ages, List<string> emails, string? ans)
    {
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
}

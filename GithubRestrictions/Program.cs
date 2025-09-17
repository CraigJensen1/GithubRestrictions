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
            string number = Console.ReadLine();
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

            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            for (int i = 0; i < x; i++)
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
                if (ages[q] < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[q] > 60)
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

            for (int q = 0; q < usernames.Count; q++)
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

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }
    }
}

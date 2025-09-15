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
            string name = Console.ReadLine();
            int age = 0;
            try
            {
                age = Convert.ToInt32(name);
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input, defaulting to 2");
                age = 2;
            }

            List<string> userNames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                userNames.Add(name);

                Console.WriteLine("Enter age:");
                string age = Console.ReadLine();
                try
                {
                    ages.Add(Int32.Parse(age));
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid input, defaulting to 18");
                    age = "18";
                }

                Console.WriteLine("Enter email:");
                string email = Console.ReadLine();
                emails.Add(email);
            }

            for (int q = 0; q < userNames.Count; q++)
            {
                Console.WriteLine("USER " + (q + 1) + ":");
                Console.WriteLine("NAME=" + userNames[q] + ", age is " + ages[q] + ", EMAIL: " + emails[q]);
                if (ages[q] < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[q] > 60)git
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

            for (int q = 0; q < userNames.Count; q++)
            {
                if (userNames[q].Length > 10)
                {
                    Console.WriteLine(userNames[q] + " has a long name");
                }
                else if (userNames[q].Length < 3)
                {
                    Console.WriteLine("shorty name alert: " + userNames[q]);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }

            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var answer = Console.ReadLine();
            if (answer == "YES")
            {
                for (int i = 0; i < userNames.Count; i++)
                {
                    Console.WriteLine("User again: " + userNames[i] + " / " + ages[i] + " / " + emails[i]); 
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
    }
}

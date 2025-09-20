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
            string numberOfUsersString = Console.ReadLine();
            int numberOfUsers = 0;
            try
            {
                numberOfUsers = Convert.ToInt32(numberOfUsersString);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                numberOfUsers = 2;
            }

            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            for (int playerNumber = 0; playerNumber < numberOfUsers; playerNumber++)
            {
                Console.WriteLine("Enter name:");
                string username = Console.ReadLine();
                usernames.Add(username);

                Console.WriteLine("Enter age:");
                string age = Console.ReadLine();
                ages.Add(Int32.Parse(age));

                Console.WriteLine("Enter email:");
                string email = Console.ReadLine();
                emails.Add(email);
            }

            for (int index = 0; index < usernames.Count; index++)
            {
                Console.WriteLine("USER " + (index + 1) + ":");
                Console.WriteLine("NAME=" + usernames[index] + ", age is " + ages[index] + ", EMAIL: " + emails[index]);
                if (ages[index] < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (ages[index] > 60)
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
            var userResponse = Console.ReadLine();
            if (userResponse == "YES")
            {
                for (int index = 0; index < usernames.Count; index++)
                {
                    Console.WriteLine("User again: " + usernames[index] + " / " + ages[index] + " / " + emails[index]);
                }
            }
            else if (userResponse == "NO")
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

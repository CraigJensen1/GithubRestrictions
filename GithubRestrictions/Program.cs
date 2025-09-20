using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");

            List<string> usernames = new List<string>();
            List<int> ages = new List<int>();
            List<string> emails = new List<string>();

            int numberOfUsers = GetNumberOfUsers();
            CollectUserInformation(numberOfUsers, usernames, ages, emails);
            EvaluateAges(usernames, ages, emails);
            EvaluateEmails(usernames, emails);
            EvaluateLengthOfNames(usernames);

            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var userResponse = Console.ReadLine();
            if (userResponse == "YES")
            {
                DisplayUserInfo(usernames, ages, emails);
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

        private static void DisplayUserInfo(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int index = 0; index < usernames.Count; index++)
            {
                Console.WriteLine("User again: " + usernames[index] + " / " + ages[index] + " / " + emails[index]);
            }
        }


        private static void EvaluateLengthOfNames(List<string> usernames)
        {
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
        }


        private static void EvaluateEmails(List<string> usernames, List<string> emails)
        {
            for (int index = 0; index < usernames.Count; index++)
            {
                if (emails[index].Contains("@") == false)
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }
        }


        private static void EvaluateAges(List<string> usernames, List<int> ages, List<string> emails)
        {
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
            }
        }


        private static void CollectUserInformation(int numberOfUsers, List<string> usernames, List<int> ages, List<string> emails)
        {
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
        }


        private static int GetNumberOfUsers()
        {
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

            return numberOfUsers;
        }

    }
}

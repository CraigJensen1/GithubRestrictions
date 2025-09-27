using System;
using System.Collections.Generic;

namespace BetterCode
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

            if (PromptYesNo("Show users again? (yes/no): "))
            {
                DisplayUserInfo(usernames, ages, emails);
            }
            else
            {
                Console.WriteLine("ok bye lol");
            }

            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        private static bool PromptYesNo(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string response = (Console.ReadLine() ?? "").Trim();

                if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    return true;
                if (response.Equals("no", StringComparison.OrdinalIgnoreCase))
                    return false;

                Console.WriteLine("Please type yes or no.");
            }
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
                string email = (emails[index] ?? "").Trim();
                while (true)
                {
                    if (email.Contains("@") && !email.Contains(" ") && !email.Contains(",") && !email.Contains(":"))
                    {
                        Console.WriteLine($"[OK] {usernames[index]}: {email}");
                        break;
                    }
                    Console.WriteLine("[NG] invalid email. Please enter a valid email:");
                    email = (Console.ReadLine() ?? "").Trim();
                }
            }
        }

        private static void EvaluateAges(List<string> usernames, List<int> ages, List<string> emails)
        {
            for (int index = 0; index < usernames.Count; index++)
            {
                Console.WriteLine("USER " + (index + 1) + ":");

                Console.WriteLine($"Name={usernames[index]}, Age={ages[index]}, Email={emails[index]}");

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
                Console.WriteLine($"--- User {playerNumber + 1} ---");

                //name
                Console.WriteLine("Enter name:");

                string username;
                while (true)
                {
                    username = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(username))
                    {
                        username = username.Trim();
                        break;
                    }
                    Console.WriteLine("Name cannot be empty. Please try again.");
                }
                usernames.Add(username); 

                //age
                while (true)
                {
                    Console.WriteLine("Enter age:");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int parsedAge) && parsedAge >= 0)
                    {
                        ages.Add(parsedAge);
                        break;
                    }
                    Console.WriteLine("Please enter a valid positive whole number for age.");
                }

                //email
                Console.WriteLine("Enter email:");
                string email;
                while (true)
                {
                    email = Console.ReadLine() ?? "";
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        email = email.Trim();
                        break;
                    }
                    Console.WriteLine("Email cannot be empty. Please try again.");
                }
                emails.Add(email);
            }
        }

        private static int GetNumberOfUsers()
        {
            while (true)
            {
                Console.Write("How many users? ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out var n) && n > 0)
                {
                    return n;
                }

                Console.WriteLine("Please enter a positive whole number.");
            }
        }
    }
}

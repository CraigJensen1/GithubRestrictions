using System;
using System.Collections.Generic;

namespace Badcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Management App");
            int userCount = ReadInt("How many users do you want to add?", 2);

            List<User> users = new List<User>();

            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine($"\nEntering details for User {i + 1}");
                string name = ReadString("Enter name:");
                int age = ReadInt("Enter age:", 18);
                string email = ReadString("Enter email:");

                users.Add(new User(name, age, email));
            }

            DisplayUsers(users);

            Console.WriteLine("\nDo you want to see all users again? (YES/NO)");
            string answer = Console.ReadLine()?.Trim().ToUpper();

            if (answer == "YES")
            {
                DisplayUsers(users);
            }
            else if (answer == "NO")
            {
                Console.WriteLine("Okay, goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid response, exiting anyway.");
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        static int ReadInt(string message, int defaultValue)
        {
            Console.WriteLine(message);
            return int.TryParse(Console.ReadLine(), out int value) ? value : defaultValue;
        }

        static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine() ?? "";
        }

        static void DisplayUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"\nName: {user.Name}, Age: {user.Age}, Email: {user.Email}");

                if (user.Age < 18)
                    Console.WriteLine("User is underaged.");
                else if (user.Age > 60)
                    Console.WriteLine("User is a senior.");
                else
                    Console.WriteLine("User is an adult.");

                if (!user.Email.Contains("@"))
                    Console.WriteLine("Warning: Invalid email format.");

                if (user.Name.Length > 10)
                    Console.WriteLine("Long name detected.");
                else if (user.Name.Length < 3)
                    Console.WriteLine("Very short name detected.");
            }
        }
    }

    class User
    {
        public string Name { get; }
        public int Age { get; }
        public string Email { get; }

        public User(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}

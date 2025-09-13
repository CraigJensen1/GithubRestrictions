using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BadCode
{
    class Program //Class names should use PascalCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string numberOfUsersInput = Console.ReadLine(); //Variable names should be descriptive 
            int numberOfUsers = 0;
            try
            {
                numberOfUsers = Convert.ToInt32(numberOfUsersInput);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                numberOfUsers = 2;
            }

            //Keeping all user information in a single list is more concise and easier to access

            List<(string usarname, int age, string email)> userInformation = new List<(string usarname, int age, string email)>();

            for (int i = 0; i < numberOfUsers; i++)
            {
                //Variable names should be descriptive
                //Add a validation function so that user cannot put incorrect information
                //Do not pass incorrect information without validation, like leaving an incorrect email without an "@" symbol
                string userName = ValidateName();
                int userAge = validateAge();
                string userEmail = validateEmail();

                userInformation.Add((userName, userAge, userEmail));
            }

            //Not an error but convention dictates that i and j are used for iteration variables
            for (int i = 0; i < userInformation.Count; i++)
            {
                Console.WriteLine("USER " + (i + 1) + ":");
                Console.WriteLine("NAME=" + userInformation[i].usarname + ", age is " + userInformation[i].age + ", EMAIL: " + userInformation[i].email);
                if (userInformation[i].age < 18)
                {
                    Console.WriteLine("This person is underaged");
                }
                else if (userInformation[i].age > 60)
                {
                    Console.WriteLine("This person is older");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }
            }

            for (int i = 0; i < userInformation.Count; i++)
            {
                if (userInformation[i].usarname.Length > 10)
                {
                    Console.WriteLine(userInformation[i].usarname + " has a long name");
                }
                else if (userInformation[i].usarname.Length < 3)
                {
                    Console.WriteLine("short name: " + userInformation[i].usarname);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }

            //Keep user interaction formal
            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var userAnswer = Console.ReadLine();
            if (userAnswer == "YES")
            {
                for (int i = 0; i < userInformation.Count; i++)
                {
                    Console.WriteLine("User again: " + userInformation[i].usarname + " / " + userInformation[i].age + " / " + userInformation[i].email);
                }
            }
            else
            {
                Console.WriteLine("press enter to exit");
                Console.ReadLine();
            }

        }

        static string ValidateName()
        {
            System.Console.WriteLine("Please enter a name your name:");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid name, enter a valid name");
                return ValidateName();
            }
            return name;
        }

        static string validateEmail()
        {
            System.Console.WriteLine("Please enter your email address:");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Please enter a valid email address.");
                return validateEmail();
            }
            return email;
        }

        static int validateAge()
        {
            System.Console.WriteLine("Please enter your age:");
            string ageInput = Console.ReadLine();
            if (!int.TryParse(ageInput, out int age) || age < 0 || age > 120)
            {
                Console.WriteLine("Please enter a valid age between 0 and 120.");
                return validateAge();
            }
            return age;
        }
    }
}
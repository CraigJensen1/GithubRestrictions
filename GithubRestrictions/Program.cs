namespace BadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add:");

            string userCountInput = Console.ReadLine();
            int userCount = 0;

            try
            {
                userCount = Convert.ToInt32(userCountInput);
            }
            catch
            {
                Console.WriteLine("Invalid input, defaulting to 2 users.");
                userCount = 2;
            }

            List<User> users = new List<User>();

            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty. Defaulting to 'Unknown'.");
                    name = "Unknown";
                }

                Console.WriteLine("Enter age:");
                string ageInput = Console.ReadLine();
                int age = 0;

                if (!Int32.TryParse(ageInput, out age))
                {
                    Console.WriteLine("Invalid age. Defaulting to 0.");
                }

                Console.WriteLine("Enter email:");
                string email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("Email cannot be empty. Defaulting to 'unknown@email.com'.");
                    email = "unknown@email.com";
                }

                users.Add(new User(name, age, email));
            }

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("USER " + (i + 1) + ":");
                Console.WriteLine("NAME=" + users[i].Name + ", AGE=" + users[i].Age + ", EMAIL=" + users[i].Email);

                if (users[i].Age < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (users[i].Age > 60)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }

                if (!users[i].Email.Contains("@"))
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name.Length > 10)
                {
                    Console.WriteLine(users[i].Name + " has a long name");
                }
                else if (users[i].Name.Length < 3)
                {
                    Console.WriteLine("Short name alert: " + users[i].Name);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }

            Console.WriteLine("Do you want to see all users again? Type YES or NO");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "YES")
            {
                foreach (User user in users)
                {
                    Console.WriteLine("User again: " + user.Name + " / " + user.Age + " / " + user.Email);
                }
            }
            else if (answer == "NO")
            {
                Console.WriteLine("Ok bye lol");
            }
            else
            {
                Console.WriteLine("I don't know what you mean but bye");
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }

    class User
    {
        public string Name;
        public int Age;
        public string Email;

        public User(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
namespace BadCode
{
    class pRoGrAm
    {
        class User(string name, int age, string email)
        {
            public string Name = name;
            public int Age = age;
            public string Email = email;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string usersAmountString = Console.ReadLine();
            int usersAmount = 0;
            try
            {
                usersAmount = Convert.ToInt32(usersAmountString);
            }
            catch
            {
                Console.WriteLine("invalid input, defaulting to 2");
                usersAmount = 2;
            }

            List<User> users = [];

            for (int index = 0; index < usersAmount; index++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                string age = Console.ReadLine();
                Console.WriteLine("Enter email:");
                string email = Console.ReadLine();

                users.Add(new User(name, Int32.Parse(age), email));
            }

            for (int index = 0; index < usersAmount; index++)
            {
                User user = users[index];
                Console.WriteLine("USER " + (index + 1) + ":");
                Console.WriteLine("NAME=" + user.Name + ", age is " + user.Age + ", EMAIL: " + user.Email);
                evaluateAge(user.Age);
                evaluateEmail(user.Email);
            }

            foreach (var user in users)
            {
                evaluateName(user.Name);
            }

            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            string userResponse = Console.ReadLine();
            switch (userResponse)
            {
                case "YES":
                    foreach (var user in users)
                    {
                        Console.WriteLine("User again: " + user.Name + " / " + user.Age + " / " + user.Email);
                    }
                    break;
                case "NO":
                    Console.WriteLine("ok bye lol");
                    break;
                default:
                    Console.WriteLine("idk what you mean but bye");
                    break;
            }
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

        static void evaluateName(string name)
        {
            const int highNameLength = 10;
            const int lowNameLength = 3;
            if (name.Length > highNameLength)
            {
                Console.WriteLine(name + " has a long name");
            }
            else if (name.Length < lowNameLength)
            {
                Console.WriteLine("shorty name alert: " + name);
            }
            else
            {
                Console.WriteLine("Name length is good enough I guess");
            }
        }

        static void evaluateEmail(string email)
        {
            if (email.Contains("@") == false)
            {
                Console.WriteLine("Not a valid email but who cares");
            }
        }

        static void evaluateAge(int age)
        {
            const int lowAgeLimit = 18;
            const int highAgeLimit = 60;
            if (age < lowAgeLimit)
            {
                Console.WriteLine("This person is underaged!!!");
            }
            else if (age > highAgeLimit)
            {
                Console.WriteLine("This person is OLD!!!");
            }
            else
            {
                Console.WriteLine("This person is fine I guess");
            }
        }
    }
}

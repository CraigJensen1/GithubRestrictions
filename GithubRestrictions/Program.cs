using badcode;

namespace badCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string userInput = Console.ReadLine();
            if (!Int32.TryParse(userInput, out int numUsers))
            {
                Console.WriteLine("invalid input, defaulting to 2");
                numUsers = 2;
            }

            List<User> usersList = new List<User>();
            for (int userNum = 0; userNum < numUsers; userNum++)
            {
                usersList.Add(new User{
                    username = Input("Enter name:"),
                    age = int.Parse(Input("Enter age:")),
                    email = Input("Enter email:")
                    });
            }

            for (int userNum = 0; userNum < numUsers; userNum++)
            {
                Console.WriteLine("USER " + (userNum + 1) + ":");
                Console.WriteLine("NAME=" + usersList[userNum].username + ", age is " + usersList[userNum].age + ", EMAIL: " + usersList[userNum].email);
                if (usersList[userNum].age < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (usersList[userNum].age > 60)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }
                if (usersList[userNum].email.Contains("@") == false)
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            }

            for (int userNum = 0; userNum < numUsers; userNum++)
            {
                if (usersList[userNum].username.Length > 10)
                {
                    Console.WriteLine(usersList[userNum].username + " has a long name");
                }
                else if (usersList[userNum].username.Length < 3)
                {
                    Console.WriteLine("shorty name alert: " + usersList[userNum].username);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }
            
            Console.WriteLine("Do you want to see all users again??? type YES or NO");
            string ans = Console.ReadLine().ToUpper();
            if (ans == "YES")
            {
                for (int userNum = 0; userNum < numUsers; userNum++)
                {
                    Console.WriteLine("User again: " + usersList[userNum].username + " / " + usersList[userNum].age + " / " + usersList[userNum].email);
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

        private static string Input(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}

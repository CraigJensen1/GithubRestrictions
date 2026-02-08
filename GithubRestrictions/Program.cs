using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace BetterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SUPER COOL APP!!!");
            Console.WriteLine("Please enter how many users you want to add?");
            string n = Console.ReadLine();
            
            int x;
            if (!int.TryParse(n, out x) || x <= 0)
            {
                Console.WriteLine("invalid input, defaulting to 2");
                x = 2;
            }

            List<User> users = new List<User>();
          

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                

                Console.WriteLine("Enter age:");
                int age = int.Parse(Console.ReadLine());
                

                Console.WriteLine("Enter email:");
                string email = Console.ReadLine();
                
                users.Add(new User(name, age, email));
            }

            for(int i = 0; i < users.Count; i++)
            {
                PrintUserInfo(users[i], i);
            }

             Console.WriteLine("Do you want to see all users again??? type YES or NO");
            var ans = Console.ReadLine();
            if (ans == "YES")
            {
                for (int i = 0; i < users.Count; i++)
                {
                   PrintUserInfo(users[i], i);
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

            static void PrintUserInfo(User user, int index)
            {
                Console.WriteLine("USER " + (index + 1) + ":");
                Console.WriteLine("NAME=" + user.Name + ", age is " + user.Age + ", EMAIL: " + user.Email);
                if (user.Age < 18)
                {
                    Console.WriteLine("This person is underaged!!!");
                }
                else if (user.Age > 60)
                {
                    Console.WriteLine("This person is OLD!!!");
                }
                else
                {
                    Console.WriteLine("This person is fine I guess");
                }
                if (!user.Email.Contains("@"))
                {
                    Console.WriteLine("Not a valid email but who cares");
                }
            
                if (user.Name.Length > 10)
                {
                    Console.WriteLine(user.Name + " has a long name");
                }
                else if (user.Name.Length < 3)
                {
                    Console.WriteLine("shorty name alert: " + user.Name);
                }
                else
                {
                    Console.WriteLine("Name length is good enough I guess");
                }
            }
        }
            class User
        {
            public string Name {get; set;}
            public int Age {get; set;}
            public string Email { get; set;}

            public User (string name, int age, string email)
            {
                Name = name;
                Age = age;
                Email = email;
            }

        
        }
}


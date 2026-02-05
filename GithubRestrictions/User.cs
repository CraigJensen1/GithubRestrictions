using static System.Console;

namespace UserData
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        const int ADULT_AGE = 18;
        const int OLD_AGE = 60;
        const int LONG_NAME_LENGTH = 10;
        const int SHORT_NAME_LENGTH = 3;
        public User() { }
        public User(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
        internal void EvaluateAge()
        {
            if (Age < ADULT_AGE)
            {
                WriteLine("This person is underaged!!!");
            }
            else if (Age > OLD_AGE)
            {
                WriteLine("This person is OLD!!!");
            }
            else
            {
                WriteLine("This person is fine I guess");
            }
        }
        internal void ValidateEmail()
        {
            if (!Email.Contains("@"))
            {
                WriteLine("Not a valid email but who cares");
            }
        }
        internal void EvaluateNameLength()
        {
            if (Name.Length > LONG_NAME_LENGTH)
            {
                WriteLine($"{Name} has a long name");
            }
            else if (Name.Length < SHORT_NAME_LENGTH)
            {
                WriteLine($"shorty name alert: {Name}");
            }
            else
            {
                WriteLine("Name length is good enough I guess");
            }
        }
    }
}
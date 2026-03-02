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
        internal string EvaluateAge()
        {
            if (Age < ADULT_AGE)
            {
                return "This person is underaged!!!";
            }
            else if (Age > OLD_AGE)
            {
                return "This person is OLD!!!";
            }
            else
            {
                return "This person is fine I guess";
            }
        }
        internal string ValidateEmail()
        {
            if (!Email.Contains("@"))
            {
                return "Not a valid email but who cares";
            }
            return "";
        }
        internal string EvaluateNameLength()
        {
            if (Name.Length > LONG_NAME_LENGTH)
            {
                return $"{Name} has a long name";
            }
            else if (Name.Length < SHORT_NAME_LENGTH)
            {
                return $"shorty name alert: {Name}";
            }
            else
            {
                return "Name length is good enough I guess";
            }
        }
    }
}
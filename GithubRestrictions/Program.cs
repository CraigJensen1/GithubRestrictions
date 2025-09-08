// Don't abbreviate ever
// Crappy vague variable name
// PascalCase = Methods, classes etc.
// Variable are in camelCase


class PlayList
{

    public const decimal UTAH_TAX_CODE = 343.343m;
    public const decimal PI = 3.14m;


    public void ThisIsAddingASong(string name)
    {
        Console.WriteLine("Added: " + name);

        if (true)
        {
            Console.WriteLine("indent");
        }
    }
}

class Program
{
    static void Main()
    {
        PlayList playList = new PlayList();
        playList.AddSong("Song A");
    }
}
//just testing
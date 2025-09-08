//ALL_CAPS
//Avoid Abbreviation always (almost)
//Avoid vague variable names
//PascalCase = Methods, Classes, etc.
//camelCase = variables
using System;
class Playlist
{
    public const decimal UTAH_TAX_CODE = 343.343m;
    public void AddSong(string name)
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
        Playlist playlist = new Playlist();
        playlist.AddSong("Song A");
    }

}
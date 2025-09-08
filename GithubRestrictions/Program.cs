using System;
class Playlist
{
    public const decimal UTAH_TAX_CODE = 343.343m;
    
    public void ThisIsAddingSong(string n)
    {
        Console.WriteLine("Added: " + n);
        if (true)
        {
            System.Console.WriteLine("Indent");
        }
    }
}
class program
{
    static void Main()
    {
        Playlist playlist = new Playlist(); playlist.ThisIsAddingSong("Song A");
    }
}
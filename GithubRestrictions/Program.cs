using System;
class PlayList
{
    public void AddSong(string n)
    {
        Console.WriteLine("Added: " + n);
    }
}
class Program
{
    static void Main()
    {
        PlayList playlist = new PlayList(); 
        PlayList.AddSong("Song A");
    }
}
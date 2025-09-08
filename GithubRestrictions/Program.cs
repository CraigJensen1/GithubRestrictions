using System;



class Playlist 
{

    public const decimal UTAH_TAX_CODE = 343.343m;
    public const decimal PI = 3.14m;


    public void AddingASong(string name) 
    { 
        Console.WriteLine("Added: " + name); 
    } 
}

class Program 
{ 
    static void Main() 
    { 
        Playlist playList = new Playlist();
        playList.AddSong("Song A"); 
    } 
}
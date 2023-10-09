class Music
{
    public string name;
    public string artist;
    public string style;
    public int duration;
    public bool available;

    public void DisplayMusicDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Style: {style}");
        Console.WriteLine($"Duration: {duration}");
        if (available)
        {
            Console.WriteLine("Available on the plan.");
        }
        else
        {
            Console.WriteLine("Join the plan Plus+");
        }
    }

    public void DisplayNameAndArtist()
    {
        Console.WriteLine($"Name: {name}, artist: {artist}");
    }
}
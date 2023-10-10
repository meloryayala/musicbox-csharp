class Music
{
    public Music(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }
    
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public Genre Genre { get; set; }

    //get - arrow function type
    public string Summary =>
        $"The music {Name} is from {Artist}";
    

    public void DisplayMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
        if (Available)
        {
            Console.WriteLine("Available on the plan.");
        }
        else
        {
            Console.WriteLine("Join the plan Plus+");
        }
    }
}
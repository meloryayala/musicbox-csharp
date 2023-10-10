class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public Genre Genre { get; set; }

    //get - arrow function type
    public string Summary =>
        $"The music {Name} is from {Artist}";
    

    public void DisplayMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
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
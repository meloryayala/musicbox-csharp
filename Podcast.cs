class Podcast
{
    private List<Episode> episodes = new List<Episode>();
    public Podcast(string host, string name)
    {
        Host = host;
        Name = name;
    }
    
    public string Host { get; }
    public string Name { get; }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void DisplayPodcastDetails()
    {
        Console.WriteLine($"All {Name}'s Podcast details\n");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Episodes in total => {TotalEpisodes}");
        DisplayEpisodes();
        
    }

    public void DisplayEpisodes()
    {
        Console.WriteLine($"All {Name}'s episodes\n");
        foreach (Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine($"Episode => {episode.Title}");
            Console.WriteLine(episode.Summary);
            Console.WriteLine("\n");
        }
    }
}
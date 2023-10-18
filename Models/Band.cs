namespace MusicBox.Models;

internal class Band : IRatable
{
    private List<Album> albums = new List<Album>();
    private List<Rating> rates = new List<Rating>();

    public Band(string name)
    {
        Name = name;
    }
    
    public string Name { get; }

    public double Average
    {
        get
        {
            if (rates.Count == 0) return 0;
            else return rates.Average(r => r.Rate);
        }
    }
    public List<Album> Albums => albums;
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }
    
    public void AddRate(Rating rate)
    {
        rates.Add(rate);
    }

    public void DisplayAlbums()
    {
        Console.WriteLine($"Albums of {Name}\n");
        foreach (var album in albums)
        {
            Console.WriteLine("\n-----------------------------------------------------------\n");
            Console.WriteLine($"Album => {album.Name}");
            Console.WriteLine($"Duration - ({album.TotalDuration}s) ");
            Console.WriteLine($"Avarage rate - ${album.Average}\"");
        }
        Console.WriteLine("\n-----------------------------------------------------------\n");    
    }
}
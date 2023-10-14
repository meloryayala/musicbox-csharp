namespace MusicBox.Models;

class Band
{
    private List<Album> albums = new List<Album>();
    private List<int> rates = new List<int>();

    public Band(string name)
    {
        Name = name;
    }
    
    public string Name { get; }
    public double Average => rates.Average();
    public List<Album> Albums => albums;
    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }
    
    public void AddRate(int rate)
    {
        rates.Add(rate);
    }

    public void DisplayAlbums()
    {
        Console.WriteLine($"Albums of {Name}\n");
        foreach (var album in albums)
        {
            Console.WriteLine($"Album => {album.Name} - ({album.TotalDuration}s)");
        }
    }
}
class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; set; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
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
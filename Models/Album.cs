namespace MusicBox.Models;

internal class Album : IRatable
{
    private List<Music> musics = new List<Music>();
    private List<Rating> rates = new List<Rating>();

    public static int CountObjects = 0;
    public Album(string name)
    {
        Name = name;
        CountObjects++;
    }
    
    public double Average
    {
        get
        {
            if (rates.Count == 0) return 0;
            else return rates.Average(r => r.Rate);
        }
    }
    
    public void AddRate(Rating rate)
    {
        rates.Add(rate);
    }

    public string Name { get; }
    public int TotalDuration => musics.Sum(m => m.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayAlbumMusics()
    {
        Console.WriteLine($"$Musics on the album #{Name}: \n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Music => {music.Name}");
        }

        Console.WriteLine($"\nThis album has {TotalDuration}");
    }


}
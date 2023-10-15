namespace MusicBox.Models;

internal class Album
{
    private List<Music> musics = new List<Music>();

    public static int CountObjects = 0;
    public Album(string name)
    {
        Name = name;
        CountObjects++;
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
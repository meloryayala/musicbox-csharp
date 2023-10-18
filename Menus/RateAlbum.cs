using MusicBox.Models;

namespace MusicBox.Menus;

internal class RateAlbum : Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);

        //which band?
        //if band  name exist
        //if this band has album name -> Add rate
        //otherwise return menu

        DisplayLogo();
        DisplayTitle("Rate an album");
        Console.Write("Write the band you want to rate: ");
        string bandName = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            Band band = registeredBands[bandName];
            Console.Write("\nWrite the album you want to rate: ");
            string albumName = Console.ReadLine()!;
            if (band.Albums.Any(a => a.Name.Equals(albumName)))
            {
                Album album = band.Albums.First(a => a.Name.Equals(albumName));
                Console.Write($"\nWhich rate the album #{albumName} deserve? ");
                Rating rate = Rating.Parse(Console.ReadLine()!);
                album.AddRate(rate);
                Console.WriteLine($"\nThe rate => {rate.Rate} was successfully registered to #{albumName}!");
            }
            else
            {
                Console.WriteLine($"\nThe band => {albumName} was not found");
            }
        }
        else
        {
            Console.WriteLine($"\nThe band => {bandName} was not found");
        }
    }
}
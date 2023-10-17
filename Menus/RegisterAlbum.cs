using MusicBox.Models;

namespace MusicBox.Menus;

internal class RegisterAlbum: Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        DisplayTitle("Register an Album");
        Console.Write("Write the band you want to add an album: ");
        string bandName = Console.ReadLine()!;
        Console.Write("Write the album name: ");
        string albumName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Band band = registeredBands[bandName];
            band.AddAlbum(new Album(albumName));
            Console.WriteLine($"The album {albumName} of {bandName} was registered successfully!");
        }
        else
        {
            Console.WriteLine($"\nThe band {bandName} was not found!");
        }
    }
}
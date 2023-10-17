using MusicBox.Models;

namespace MusicBox.Menus;

internal class RegisterBand: Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        DisplayLogo();
        DisplayTitle("Register a band");
        Console.Write("\nWrite the band name: ");
        string bandName = Console.ReadLine()!;
        Band band = new Band(bandName);
        registeredBands.Add(bandName, band);
        Console.WriteLine($"The band {bandName} was successfully registered!");
    }
}
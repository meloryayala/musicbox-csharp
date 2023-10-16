using MusicBox.Models;

namespace MusicBox.Menus;

internal class RegisterBand: Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        DisplayLogo();
        DisplayTitle("Register a band");
        Console.Write("\nWrite the band name: ");
        string bandName = Console.ReadLine()!;
        Band band = new Band(bandName);
        registeredBands.Add(bandName, band);
        Console.WriteLine($"The band {bandName} was successfully registered!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}
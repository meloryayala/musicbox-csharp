using MusicBox.Models;

namespace MusicBox.Menus;

internal class DisplayBandAverage: Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        DisplayLogo();
        DisplayTitle("Check the bands average rate");
        Console.Write("\nWhich band average do you want to know? ");
        string bandName = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            Band band = registeredBands[bandName];
            Console.WriteLine($"\nThe band #{bandName} average is => {band.Average}!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"The band #{bandName} was not found");
        }
    }
}
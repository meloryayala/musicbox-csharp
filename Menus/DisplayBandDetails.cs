using MusicBox.Models;

namespace MusicBox.Menus;

internal class DisplayBandDetails: Menu
{
   public void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        DisplayTitle("Band details");
        Console.Write("Which band do you want to know better? ");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Band band = registeredBands[bandName];
            Console.WriteLine($"\nThe average rate of {bandName} is {band.Average}.");
            /**
            * complete function
            */
            
        }
        else
        {
            Console.WriteLine($"\nThe band {bandName} was not found!");
            
        }
    }
}
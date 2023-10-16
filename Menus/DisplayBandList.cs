using MusicBox.Models;

namespace MusicBox.Menus;

internal class DisplayBandList: Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
        DisplayLogo();
        DisplayTitle("Check all bands");
        //for with integer
        // for (int i = 0; i < bandsList.Count(); i++)
        // {
        //     Console.WriteLine($"Band => {bandsList[i]}");
        // }
        foreach (string band in registeredBands.Keys)
        {
            Console.WriteLine($"Band => {band}");
        }
    }
}
using MusicBox.Models;

namespace MusicBox.Menus;

internal class BandsList: Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        
        Console.Clear();
        DisplayLogo();
        DisplayTitle("Check all bands");
        foreach (string band in registeredBands.Keys)
        {
            Console.WriteLine($"Band => {band}");
        }
    }
}
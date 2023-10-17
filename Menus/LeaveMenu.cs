using MusicBox.Models;

namespace MusicBox.Menus;

internal class LeaveMenu: Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.WriteLine("Bye bye :)");
    }
}
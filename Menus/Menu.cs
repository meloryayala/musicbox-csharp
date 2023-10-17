using MusicBox.Models;

namespace MusicBox.Menus;

internal class Menu
{
    public void DisplayLogo()
    {
        Console.WriteLine(@"
█▀▄▀█ █░█ █▀ █ █▀▀   █▄▄ █▀█ ▀▄▀
█░▀░█ █▄█ ▄█ █ █▄▄   █▄█ █▄█ █░█
");
    }
    
    public void DisplayTitle(string title)
    {
        int lettersQuantity = title.Length;
        string asterisks = string.Empty.PadLeft(lettersQuantity, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }

    public virtual void Execute(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
    }
}
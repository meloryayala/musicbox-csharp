namespace MusicBox.Menus;

public class Menu
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
}
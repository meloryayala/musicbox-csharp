using MusicBox.Models;
namespace MusicBox.Menus;

internal class RateBand: Menu
{
    public void Execute(Dictionary<string, Band> registeredBands)
    {
        //which band?
        //if band exist -> add rate
        //otherwise return menu

        Console.Clear();
        DisplayLogo();
        DisplayTitle("Rate a band");
        Console.Write("Write the band name you want to rate: ");
        string bandName = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            Band band = registeredBands[bandName];
            Console.Write($"\nWhich rate the band #{bandName} deserve? ");
            Rating rate = Rating.Parse(Console.ReadLine()!);
            band.AddRate(rate);
            Console.WriteLine($"\nThe rate => {rate.Rate} was successfully registered to #{bandName}!");
            Thread.Sleep(4000);
            Console.Clear();
            
        }
        else
        {
            Console.WriteLine($"\nThe band => {bandName} was not found");
            
        }
    }
}
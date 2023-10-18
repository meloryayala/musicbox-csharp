using MusicBox.Models;
namespace MusicBox.Menus;

internal class RateBand: Menu
{
    public override void Execute(Dictionary<string, Band> registeredBands)
    {
        base.Execute(registeredBands);
        
        //which band?
        //if band exist -> add rate
        //otherwise return menu
        
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
        }
        else
        {
            Console.WriteLine($"\nThe band => {bandName} was not found");
        }
    }
}
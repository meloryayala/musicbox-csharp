using System.Threading.Channels;
using MusicBox.Models;
using MusicBox.Menus;

Band mana = new Band("Mana");
mana.AddRate(new Rating(10));
mana.AddRate(new Rating(8));
mana.AddRate(new Rating(6));
Band shakira = new Band("Shakira");

string welcomeMsg = "Welcome to Music Box!";
Dictionary<string, Band> registeredBands = new();
registeredBands.Add(mana.Name, mana);

Dictionary<int, Menu> options = new();
options.Add(1, new RegisterBand());
options.Add(2, new RegisterAlbum());
options.Add(3, new BandsList());
options.Add(4, new RateBand());
options.Add(5, new RateAlbum());
options.Add(6, new DisplayBandDetails());
options.Add(-1, new LeaveMenu());

void DisplayMenuOptions()
{
    Menu menu = new Menu();
    menu.DisplayLogo();
    Console.WriteLine(welcomeMsg);
    Console.WriteLine("\nWrite 1 to register a band");
    Console.WriteLine("Write 2 to register an album of a band");
    Console.WriteLine("Write 3 to see all bands");
    Console.WriteLine("Write 4 to rate a band");
    Console.WriteLine("Write 5 to rate an album of a band");
    Console.WriteLine("Write 6 to see a band details");
    Console.WriteLine("Write -1 to leave the application");

    Console.Write("\nWhat is your choice? ");
    string choseOption = Console.ReadLine()!;
    int choseOptionNumber = int.Parse(choseOption);

    if (options.ContainsKey(choseOptionNumber))
    {
        Menu menuToDisplay = options[choseOptionNumber];
        menuToDisplay.Execute(registeredBands);
        if (choseOptionNumber > 0) ReturnMenuOptions();
    }

    {
        Console.WriteLine("Invalid option");
    }
}

void ReturnMenuOptions()
{
    Console.WriteLine("\nWrite a key to return to the menu");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

DisplayMenuOptions();
using System.Diagnostics;
using MusicBox.Models;


Band mana = new Band("Mana");
mana.AddRate(new Rating(10));
mana.AddRate(new Rating(8));
mana.AddRate(new Rating(6));
Band shakira = new Band("Shakira");

string welcomeMsg = "Welcome to Music Box!";
Dictionary<string, Band> registeredBands = new();
registeredBands.Add(mana.Name, mana);

void DisplayLogo()
{
    Console.WriteLine(@"
█▀▄▀█ █░█ █▀ █ █▀▀   █▄▄ █▀█ ▀▄▀
█░▀░█ █▄█ ▄█ █ █▄▄   █▄█ █▄█ █░█
");
}

void DisplayMenuOptions()
{
    DisplayLogo();
    Console.WriteLine(welcomeMsg);
    Console.WriteLine("\nWrite 1 to register a band");
    Console.WriteLine("Write 2 to display all bands");
    Console.WriteLine("Write 3 to rate a band");
    Console.WriteLine("Write 4 to display the band average rate");
    Console.WriteLine("Write 5 to see a band details");
    Console.WriteLine("Write -1 to leave the application");

    Console.Write("\nWhat is your choice? ");
    string choseOption = Console.ReadLine()!;
    int choseOptionNumber = int.Parse(choseOption);

    switch (choseOptionNumber)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            DisplayBandsList();
            break;
        case 3:
            RateBand();
            break;
        case 4:
            DisplayBandAverage();
            break;
        case 5:
            DisplayBandDetails();
            break;
        case -1:
            Console.WriteLine("Bye bye :)");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void ReturnMenuOptions()
{
    Console.WriteLine("\nWrite a key to return to the menu");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

void RegisterAlbum()
{
    Console.Clear();
    DisplayTitle("Register an Album");
    Console.Write("Write the band you want to add an album: ");
    string bandName = Console.ReadLine()!;
    Console.Write("Write the album name: ");
    string albumName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandName))
    {
        Band band = registeredBands[bandName];
        band.AddAlbum(new Album(albumName));
        Console.WriteLine($"The album {albumName} of {bandName} was registered successfully!");
        Thread.Sleep(4000);
        Console.Clear();
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine($"\nThe band {bandName} was not found!");
        ReturnMenuOptions();
    }
}

void RegisterBand()
{
    Console.Clear();
    DisplayLogo();
    DisplayTitle("Register a band");
    Console.Write("\nWrite the band name: ");
    string bandName = Console.ReadLine()!;
    Band band = new Band(bandName);
    registeredBands.Add(bandName, band);
    Console.WriteLine($"The band {bandName} was successfully registered!");
    Thread.Sleep(2000);
    Console.Clear();
    DisplayMenuOptions();
}

void DisplayBandsList()
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

    ReturnMenuOptions();
}

void DisplayTitle(string title)
{
    int lettersQuantity = title.Length;
    string asterisks = string.Empty.PadLeft(lettersQuantity, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void RateBand()
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
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine($"\nThe band => {bandName} was not found");
        ReturnMenuOptions();
    }
}

void DisplayBandAverage()
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
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine($"The band #{bandName} was not found");
        ReturnMenuOptions();
    }
}

void DisplayBandDetails()
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
        ReturnMenuOptions();
    }
    else
    {
        Console.WriteLine($"\nThe band {bandName} was not found!");
        ReturnMenuOptions();
    }
}

DisplayMenuOptions();
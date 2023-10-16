using System.Diagnostics;
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
            RegisterBand menu1 = new RegisterBand();
            menu1. Execute(registeredBands);
            DisplayMenuOptions();
            break;
        case 2:
            DisplayBandList menu2 = new DisplayBandList();
            menu2.Execute(registeredBands);
            ReturnMenuOptions();
            break;
        case 3:
            RateBand menu3 = new RateBand();
            menu3.Execute(registeredBands);
            ReturnMenuOptions();
            break;
        case 4:
            DisplayBandAverage menu4 = new DisplayBandAverage();
            menu4.Execute(registeredBands);
            ReturnMenuOptions();
            break;
        case 5:
            DisplayBandDetails menu5 = new DisplayBandDetails();
            menu5.Execute(registeredBands);
            ReturnMenuOptions();
            break;
        case -1:
            LeaveMenu menuOut = new LeaveMenu();
            menuOut.Execute();
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

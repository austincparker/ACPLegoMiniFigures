using ACPLegoMiniFigures.Models;

Console.WriteLine("What type of head to you want?");

string response = Console.ReadLine();

var jackSparrow = new PirateHead();
var ronWeasley = new HarryPotterHead();

jackSparrow.Color = LegoColor.Yellow;
ronWeasley.Color = LegoColor.Grey;

ronWeasley.Speak();
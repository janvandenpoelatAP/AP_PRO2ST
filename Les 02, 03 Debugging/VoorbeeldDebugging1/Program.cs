// See https://aka.ms/new-console-template for more information

var currentDate = DateTime.Now;
Console.WriteLine($"Het is momenteel: {currentDate}");
currentDate.AddYears(1);
Console.WriteLine($"Binnen een jaar is het: {currentDate}");

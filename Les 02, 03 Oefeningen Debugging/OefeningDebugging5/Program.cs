// See https://aka.ms/new-console-template for more information

string w;
int i, t, ttl;
List<TimeSheetEntry> ents = new List<TimeSheetEntry>();
Console.Write("Wat heb je gedaan, voor wie?");
w = Console.ReadLine();
Console.Write("Hoe lang heb je gewerkt?");
t = int.Parse(Console.ReadLine());
TimeSheetEntry ent = new TimeSheetEntry();
ent.HoursWorked = t;
ent.WorkDone = w;
ents.Add(ent);
Console.Write("Wil je nog een tijdeenheid ingeven?");
bool cont = bool.Parse(Console.ReadLine());
do
{
    Console.Write("Wat heb je gedaan, voor wie?");
    w = Console.ReadLine();
    Console.Write("Hoe lang heb je gewerkt?");
    t = int.Parse(Console.ReadLine());
    ent.HoursWorked = t;
    ent.WorkDone = w;
    ents.Add(ent);
    Console.Write("Wil je nog een tijdeenheid ingeven?");
    cont = bool.Parse(Console.ReadLine());
} while (cont == true);
ttl = 0;
for (i = 0; i < ents.Count; i++)
{
    if (ents[i].WorkDone.Contains("AP"))
    {
        ttl += i;
    }
}
Console.WriteLine("Simulatie zenden email naar AP");
Console.WriteLine("De rekening is €" + ttl * 150 + " voor de gewerkte uren.");
for (i = 0; i < ents.Count; i++)
{
    if (ents[i].WorkDone.Contains("Microsoft"))
    {
        ttl += i;
    }
}
Console.WriteLine("Simulatie zenden email naar Microsoft");
Console.WriteLine("De rekening is €" + ttl * 125 + " voor de gewerkte uren.");
for (i = 0; i < ents.Count; i++)
{
    ttl += ents[i].HoursWorked;
}
if (ttl > 40)
{
    Console.WriteLine("Je verdient €" + ttl * 15 + " voor je werk.");
}
else
{
    Console.WriteLine("Je verdient €" + ttl * 10 + " voor je werk.");
}
Console.WriteLine();
Console.Write("Druk op een toets om de applicatie af te sluiten...");
Console.ReadKey();


public class TimeSheetEntry
{
    public string WorkDone;
    public int HoursWorked;
}


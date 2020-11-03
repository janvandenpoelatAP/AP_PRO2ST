using System;

namespace VoorbeeldDebugging1
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDate = DateTime.Now;
            Console.WriteLine($"Het is momenteel: {currentDate}");
            currentDate.AddYears(1);
            Console.WriteLine($"Binnen een jaar is het: {currentDate}");
        }
    }
}

using System;

namespace OefeningDebugging1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam?");
            var name = Console.ReadLine();
            Console.WriteLine("Hoe vaak wil je deze naam tonen?");
            var repeat = int.Parse(Console.ReadLine());
            for (int i = 1; i < repeat; i++)
            {
                Console.WriteLine(name);
                i += 1;
            }
            Console.ReadLine();
        }
    }
}

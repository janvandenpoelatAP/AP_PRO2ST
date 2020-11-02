using System;

namespace OefeningDebugging2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int i = 0; i <= letters.Length; i++)
            {
                letters[i].ToLower();
                Console.WriteLine(letters[i]);
            }
        }
    }
}

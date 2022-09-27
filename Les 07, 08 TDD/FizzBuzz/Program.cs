using System;
using FizzBuzz.Library;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}

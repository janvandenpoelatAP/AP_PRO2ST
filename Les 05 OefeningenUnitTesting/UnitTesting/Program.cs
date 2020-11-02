using System;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberGame = new NumberGame(new Die());
            var score = numberGame.RateGuess(5);
            Console.WriteLine($"Uw score: {score}");
        }
    }
}

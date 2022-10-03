// See https://aka.ms/new-console-template for more information
using UnitTestingDependencies;

var numberGame = new NumberGame(new Die());
var score = numberGame.RateGuess(5);
Console.WriteLine($"Uw score: {score}");

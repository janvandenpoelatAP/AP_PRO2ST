using MockingRandomNumber;

Console.WriteLine("Geef de naam van speler 1:");
var player1 = Console.ReadLine();
Console.WriteLine("Geef de naam van speler 2:");
var player2 = Console.ReadLine();
Console.WriteLine();

var dieGame = new DieGame(new RandomNumberApiDie(), new RandomNumberApiDie());
var result = dieGame.Play(player1, player2);

Console.WriteLine(result);

namespace MockingRandomNumber;

public class DieGame
{
    private readonly IDie player1Die;
    private readonly IDie player2Die;

    public DieGame(IDie player1Die, IDie player2Die)
    {
        this.player1Die = player1Die;
        this.player2Die = player2Die;
    }

    public string Play(string player1, string player2)
    {
        var player1result = player1Die.Roll();
        var player2result = player2Die.Roll();

        if (player1result > player2result)
        {
            return $"{player1} wint";
        }
        else if (player2result > player1result)
        {
            return $"{player2} wint";
        }
        else
        {
            return "Er is geen winnaar";
        }
    }
}

using MockingRandomNumber;
using Moq;

namespace MockingRndomNumberApi.Tests;

[TestClass()]
public class DieGameTests
{
    [TestMethod()]
    public void Play_Returns_Player1_As_Winner_If_Player1_Rolls_Highest_Value()
    {
        //Arrange
        var player1Die = new Mock<IDie>();
        player1Die.Setup(x => x.Roll()).Returns(4);

        var player2Die = new Mock<IDie>();
        player2Die.Setup(x => x.Roll()).Returns(3);

        var dieGame = new DieGame(player1Die.Object, player2Die.Object);

        //Act            
        var result = dieGame.Play("Player1", "Player2");

        //Assert
        Assert.AreEqual("Player1 wint", result);
    }

    [TestMethod()]
    public void Play_Returns_Player2_As_Winner_If_Player2_Rolls_Highest_Value()
    {
        //Arrange
        var player1Die = new Mock<IDie>();
        player1Die.Setup(x => x.Roll()).Returns(3);

        var player2Die = new Mock<IDie>();
        player2Die.Setup(x => x.Roll()).Returns(4);

        var dieGame = new DieGame(player1Die.Object, player2Die.Object);

        //Act            
        var result = dieGame.Play("Player1", "Player2");

        //Assert
        Assert.AreEqual("Player2 wint", result);
    }

    [TestMethod()]
    public void Play_Returns_No_Winner_If_Player1_And_Player2_Roll_Same_Value()
    {
        //Arrange
        var player1Die = new Mock<IDie>();
        player1Die.Setup(x => x.Roll()).Returns(3);

        var player2Die = new Mock<IDie>();
        player2Die.Setup(x => x.Roll()).Returns(3);

        var dieGame = new DieGame(player1Die.Object, player2Die.Object);

        //Act            
        var result = dieGame.Play("Player1", "Player2");

        //Assert
        Assert.AreEqual("Er is geen winnaar", result);
    }

    [TestMethod()]
    public void Play_Returns_No_Winner_If_Player1_And_Player2_Roll_Same_Value_Integration_Test()
    {
        var url = "http://localhost:3000/api/v1.0/random";

        var dieGame = new DieGame(new RandomNumberApiDie(url), new RandomNumberApiDie(url));

        //Act            
        var result = dieGame.Play("Player1", "Player2");

        //Assert
        Assert.AreEqual("Er is geen winnaar", result);
    }
}
using BowlingGameScore;
using NUnit.Framework;

namespace BowlingGameScoreTests
{
    [TestFixture]
    public class BowlingGameScoreTests
    {
        private BowlingGame game;

        [SetUp]
        public void Setup()
        {
            game = new BowlingGame();
        }

        [Test]
        public void When_Roll_GutterGame_Returns_0()
        {
            // Arrange
            // Act
            RollMany(20, 0);
            // Assert
            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void When_Roll_AllOnes_Returns_20()
        {
            // Arrange
            // Act
            RollMany(20, 1);
            // Assert
            Assert.AreEqual(20, game.Score);
        }
        [Test]
        public void When_Roll_SpareAndThree_Returns_16()
        {
            // Arrange
            // Act
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17, 0);
            // Assert
            Assert.AreEqual(16, game.Score);
        }
        [Test]
        public void When_Roll_StrikeAndThreeAndFour_Returns_24()
        {
            // Arrange
            // Act
            game.Roll(10);
            game.Roll(3);
            game.Roll(4);
            RollMany(16, 0);
            // Assert
            Assert.AreEqual(24, game.Score);
        }
        [Test]
        public void When_Roll_PerfectGame_Returns_300()
        {
            // Arrange
            // Act
            RollMany(12, 10);
            // Assert
            Assert.AreEqual(300, game.Score);
        }

        private void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
                game.Roll(pins);
        }
    }
}
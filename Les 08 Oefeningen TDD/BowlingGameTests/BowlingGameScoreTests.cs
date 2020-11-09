using NUnit.Framework;

namespace BowlingGameScoreTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanCreateGame()
        {
            var game = new BowlingGame();
        }
    }
}
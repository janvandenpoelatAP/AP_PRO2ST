using NUnit.Framework;

namespace BowlingGameScoreTests
{
    [TestFixture]
    public class BowlingGameScoreTests
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
using NUnit.Framework;

namespace BowlingGameTests
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
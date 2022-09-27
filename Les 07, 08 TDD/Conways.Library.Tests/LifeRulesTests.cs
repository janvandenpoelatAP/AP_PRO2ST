using NUnit.Framework;

namespace Conways.Library.Tests
{
    // Any live cell with fewer than two live neighbours dies
    // Any live cell with two or three live neighbours lives
    // Any live cell with more than three live neighbours dies
    // Any dead cell with exactly three live neighbours becomes a live cell

    [TestFixture]
    public class LifeRulesTests
    {
    }
}
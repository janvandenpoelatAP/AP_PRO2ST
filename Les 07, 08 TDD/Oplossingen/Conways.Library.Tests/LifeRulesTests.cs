using Conway.Library;
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
        [Test]
        public void LiveCell_FewerThan2LiveNeighbors_Dies([Values(0, 1)] int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void LiveCell_2Or3LiveNeighbors_Lives([Values(2, 3)] int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void LiveCell_MoreThan3LiveNeighbors_Dies([Range(4, 8)] int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void DeadCell_Exactly3LiveNeighbors_Lives()
        {
            int liveNeighbors = 3;
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void DeadCell_FewerThan3LiveNeihbors_StaysDead([Range(0, 2)] int liveNeighbors)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void DeadCell_MoreThan3LiveNeighbors_StaysDead([Range(4, 8)] int liveNeighbors)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);
            Assert.AreEqual(CellState.Dead, newState);
        }
    }
}
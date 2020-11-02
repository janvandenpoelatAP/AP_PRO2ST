using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace UnitTesting.Tests
{
    [TestClass()]
    public class NumberGameTests
    {
        [TestMethod()]
        public void RateGuess_Returns_2_When_Guess_Is_Correct()
        {
            // test git
            var die = new Mock<IDie>();
            die.Setup(x => x.Roll()).Returns(5);
            var numberGame = new NumberGame(die.Object);
            var result = numberGame.RateGuess(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void RateGuess_Returns_1_When_Guess_Is_Only_1_Wrong()
        {
            var numberGame = new NumberGame(new DieMock(5));
            var result = numberGame.RateGuess(4);
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void RateGuess_Returns_0_When_Guess_Is_Wrong()
        {
            var numberGame = new NumberGame(new DieMock(5));
            var result = numberGame.RateGuess(3);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void Roll_Method_Rolls_The_Die_Exactly_Once()
        {
            var die = new Mock<IDie>();
            var numberGame = new NumberGame(die.Object);
            numberGame.RateGuess(0);
            die.Verify(x => x.Roll(), Times.Once);
        }
    }
}